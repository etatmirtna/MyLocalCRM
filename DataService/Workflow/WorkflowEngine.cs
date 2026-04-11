using System;
using System.Data.Common;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using DataService.Models;
using DataService.Repositories;

namespace DataService.Workflow;

public class WorkflowEngine : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IDbConnectionFactory _connectionFactory;

    public WorkflowEngine(IServiceProvider serviceProvider, IDbConnectionFactory connectionFactory)
    {
        _serviceProvider = serviceProvider;
        _connectionFactory = connectionFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            WorkflowTicket? ticket = null;
            try
            {
                ticket = await ClaimNextTicketAsync(stoppingToken);
            }
            catch
            {
                // ignore
            }

            if (ticket == null)
            {
                await Task.Delay(500, stoppingToken);
                continue;
            }

            using var scope = _serviceProvider.CreateScope();
            var handlers = scope.ServiceProvider.GetServices<IInteractionHandler>().ToArray();
            var handler = handlers.FirstOrDefault(h => string.Equals(h.Name, ticket.NextProcessor, StringComparison.OrdinalIgnoreCase))
                          ?? handlers.FirstOrDefault(h => string.Equals(h.Name, "Default", StringComparison.OrdinalIgnoreCase));

            if (handler == null)
            {
                // No handler available, mark failed
                await MarkTicketFailedAsync(ticket, "No handler registered", stoppingToken);
                continue;
            }

            HandlerResult result;
            try
            {
                result = await handler.HandleAsync(ticket, stoppingToken);
            }
            catch (Exception ex)
            {
                await MarkTicketFailedAsync(ticket, ex.Message, stoppingToken);
                continue;
            }

            // Update ticket based on result
            try
            {
                await UpdateTicketAfterResultAsync(ticket, result, stoppingToken);
            }
            catch
            {
                // ignore
            }
        }
    }

    private async Task<WorkflowTicket?> ClaimNextTicketAsync(CancellationToken ct)
    {
        const string sql = @"
UPDATE WorkflowTickets
SET LockedBy = @locker, LockedAt = SYSUTCDATETIME()
OUTPUT inserted.Id, inserted.InteractionId, inserted.CurrentState, inserted.Priority, inserted.RouteAttributesJson, inserted.NextProcessor, inserted.Attempts, inserted.CreatedAt, inserted.DueAt, inserted.CompletedAt, inserted.ResultJson, inserted.LockedBy, inserted.LockedAt
WHERE Id = (
    SELECT TOP (1) Id FROM WorkflowTickets WITH (ROWLOCK, READPAST)
    WHERE LockedAt IS NULL AND (DueAt IS NULL OR DueAt <= SYSUTCDATETIME()) AND CurrentState = 'Pending'
    ORDER BY Priority DESC, CreatedAt
)";

        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync(ct);
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        var locker = Guid.NewGuid().ToString();
        var p = cmd.CreateParameter();
        p.ParameterName = "@locker";
        p.Value = locker;
        cmd.Parameters.Add(p);

        await using var reader = await cmd.ExecuteReaderAsync(ct);
        if (!await reader.ReadAsync(ct)) return null;

        var ticket = new WorkflowTicket
        {
            Id = reader.GetGuid(reader.GetOrdinal("Id")),
            InteractionId = reader.GetGuid(reader.GetOrdinal("InteractionId")),
            CurrentState = reader.IsDBNull(reader.GetOrdinal("CurrentState")) ? "Pending" : reader.GetString(reader.GetOrdinal("CurrentState")),
            Priority = reader.IsDBNull(reader.GetOrdinal("Priority")) ? 0 : reader.GetInt32(reader.GetOrdinal("Priority")),
            RouteAttributesJson = reader.IsDBNull(reader.GetOrdinal("RouteAttributesJson")) ? null : reader.GetString(reader.GetOrdinal("RouteAttributesJson")),
            NextProcessor = reader.IsDBNull(reader.GetOrdinal("NextProcessor")) ? null : reader.GetString(reader.GetOrdinal("NextProcessor")),
            Attempts = reader.IsDBNull(reader.GetOrdinal("Attempts")) ? 0 : reader.GetInt32(reader.GetOrdinal("Attempts")),
            LockedBy = reader.IsDBNull(reader.GetOrdinal("LockedBy")) ? locker : reader.GetString(reader.GetOrdinal("LockedBy")),
            LockedAt = reader.IsDBNull(reader.GetOrdinal("LockedAt")) ? DateTime.UtcNow : reader.GetDateTime(reader.GetOrdinal("LockedAt")),
            CreatedAt = reader.IsDBNull(reader.GetOrdinal("CreatedAt")) ? DateTime.UtcNow : reader.GetDateTime(reader.GetOrdinal("CreatedAt")),
            DueAt = reader.IsDBNull(reader.GetOrdinal("DueAt")) ? null : reader.GetDateTime(reader.GetOrdinal("DueAt")),
            CompletedAt = reader.IsDBNull(reader.GetOrdinal("CompletedAt")) ? null : reader.GetDateTime(reader.GetOrdinal("CompletedAt")),
            ResultJson = reader.IsDBNull(reader.GetOrdinal("ResultJson")) ? null : reader.GetString(reader.GetOrdinal("ResultJson"))
        };

        return ticket;
    }

    private async Task MarkTicketFailedAsync(WorkflowTicket ticket, string error, CancellationToken ct)
    {
        const string sql = @"UPDATE WorkflowTickets SET Attempts = Attempts + 1, NextProcessor = NULL, CurrentState = 'Failed', ResultJson = @result, LockedBy = NULL, LockedAt = NULL WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync(ct);
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "result", JsonSerializer.Serialize(new { error }));
        AddParameter(cmd, "Id", ticket.Id);
        await cmd.ExecuteNonQueryAsync(ct);
    }

    private async Task UpdateTicketAfterResultAsync(WorkflowTicket ticket, HandlerResult result, CancellationToken ct)
    {
        if (result.Completed)
        {
            const string sql = @"UPDATE WorkflowTickets SET Attempts = Attempts + 1, CurrentState = 'Completed', CompletedAt = SYSUTCDATETIME(), ResultJson = @result, LockedBy = NULL, LockedAt = NULL WHERE Id = @Id";
            await using var conn = _connectionFactory.CreateConnection();
            await conn.OpenAsync(ct);
            await using var cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            AddParameter(cmd, "result", result.ResultJson ?? JsonSerializer.Serialize(new { message = "ok" }));
            AddParameter(cmd, "Id", ticket.Id);
            await cmd.ExecuteNonQueryAsync(ct);
            return;
        }

        // Not completed: requeue or send to next processor
        const string sqlRequeue = @"UPDATE WorkflowTickets SET Attempts = Attempts + 1, NextProcessor = @next, DueAt = DATEADD(second, @delay, SYSUTCDATETIME()), ResultJson = @result, LockedBy = NULL, LockedAt = NULL WHERE Id = @Id";
        await using var conn2 = _connectionFactory.CreateConnection();
        await conn2.OpenAsync(ct);
        await using var cmd2 = conn2.CreateCommand();
        cmd2.CommandText = sqlRequeue;
        AddParameter(cmd2, "next", result.NextProcessor ?? string.Empty);
        AddParameter(cmd2, "delay", result.DelaySeconds);
        AddParameter(cmd2, "result", result.ResultJson ?? JsonSerializer.Serialize(new { }));
        AddParameter(cmd2, "Id", ticket.Id);
        await cmd2.ExecuteNonQueryAsync(ct);
    }

    private static void AddParameter(DbCommand cmd, string name, object? value)
    {
        var p = cmd.CreateParameter();
        p.ParameterName = "@" + name;
        p.Value = value ?? DBNull.Value;
        cmd.Parameters.Add(p);
    }
}
