using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public class LeadRepository : ILeadRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public LeadRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task AddAsync(Lead lead)
    {
        const string sql = @"INSERT INTO Leads (Id, Source, Status, FirstName, LastName, Email, Phone, ActionId, CreatedById, ModifiedById, CreatedAt, ModifiedAt, DeletedById, DeletedAt, CreatedOnBehalfById, ModifiedOnBehalfById)
VALUES (@Id, @Source, @Status, @FirstName, @LastName, @Email, @Phone, @ActionId, @CreatedById, @ModifiedById, @CreatedAt, @ModifiedAt, @DeletedById, @DeletedAt, @CreatedOnBehalfById, @ModifiedOnBehalfById)";

        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", lead.Id);
        AddParameter(cmd, "Source", (object?)lead.Source ?? DBNull.Value);
        AddParameter(cmd, "Status", (object?)lead.Status ?? DBNull.Value);
        AddParameter(cmd, "FirstName", (object?)lead.FirstName ?? DBNull.Value);
        AddParameter(cmd, "LastName", (object?)lead.LastName ?? DBNull.Value);
        AddParameter(cmd, "Email", (object?)lead.Email ?? DBNull.Value);
        AddParameter(cmd, "Phone", (object?)lead.Phone ?? DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)lead.ActionId ?? DBNull.Value);
        AddParameter(cmd, "CreatedById", (object?)lead.CreatedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)lead.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "CreatedAt", lead.CreatedAt);
        AddParameter(cmd, "ModifiedAt", (object?)lead.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "DeletedById", (object?)lead.DeletedById ?? DBNull.Value);
        AddParameter(cmd, "DeletedAt", (object?)lead.DeletedAt ?? DBNull.Value);
        AddParameter(cmd, "CreatedOnBehalfById", (object?)lead.CreatedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)lead.ModifiedOnBehalfById ?? DBNull.Value);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        const string sql = "UPDATE Leads SET DeletedAt = @DeletedAt WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "DeletedAt", DateTime.UtcNow);
        AddParameter(cmd, "Id", id);
        await cmd.ExecuteNonQueryAsync();
    }

    public async Task<IEnumerable<Lead>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Leads WHERE DeletedAt IS NULL";
        var results = new List<Lead>();
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            results.Add(ReadLead(reader));
        }

        return results;
    }

    public async Task<Lead?> GetByIdAsync(Guid id)
    {
        const string sql = "SELECT * FROM Leads WHERE Id = @Id AND DeletedAt IS NULL";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", id);
        await using var reader = await cmd.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return ReadLead(reader);
        }

        return null;
    }

    public async Task UpdateAsync(Lead lead)
    {
        const string sql = @"UPDATE Leads SET Source=@Source, Status=@Status, FirstName=@FirstName, LastName=@LastName, Email=@Email, Phone=@Phone, ActionId=@ActionId, ModifiedById=@ModifiedById, ModifiedAt=@ModifiedAt, ModifiedOnBehalfById=@ModifiedOnBehalfById
WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Source", (object?)lead.Source ?? DBNull.Value);
        AddParameter(cmd, "Status", (object?)lead.Status ?? DBNull.Value);
        AddParameter(cmd, "FirstName", (object?)lead.FirstName ?? DBNull.Value);
        AddParameter(cmd, "LastName", (object?)lead.LastName ?? DBNull.Value);
        AddParameter(cmd, "Email", (object?)lead.Email ?? DBNull.Value);
        AddParameter(cmd, "Phone", (object?)lead.Phone ?? DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)lead.ActionId ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)lead.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedAt", (object?)lead.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)lead.ModifiedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "Id", lead.Id);
        await cmd.ExecuteNonQueryAsync();
    }

    private static void AddParameter(DbCommand cmd, string name, object? value)
    {
        var p = cmd.CreateParameter();
        p.ParameterName = "@" +  name;
        p.Value = value ?? DBNull.Value;
        cmd.Parameters.Add(p);
    }

    private static Lead ReadLead(DbDataReader reader)
    {
        var id = reader.GetGuid(reader.GetOrdinal("Id"));
        var source = reader.IsDBNull(reader.GetOrdinal("Source")) ? null : reader.GetString(reader.GetOrdinal("Source"));
        var status = reader.IsDBNull(reader.GetOrdinal("Status")) ? null : reader.GetString(reader.GetOrdinal("Status"));
        var firstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? null : reader.GetString(reader.GetOrdinal("FirstName"));
        var lastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString(reader.GetOrdinal("LastName"));
        var email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email"));
        var phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? null : reader.GetString(reader.GetOrdinal("Phone"));
        var actionId = reader.IsDBNull(reader.GetOrdinal("ActionId")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("ActionId"));
        var createdById = reader.IsDBNull(reader.GetOrdinal("CreatedById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("CreatedById"));
        var modifiedById = reader.IsDBNull(reader.GetOrdinal("ModifiedById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("ModifiedById"));
        var createdAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"));
        var modifiedAt = reader.IsDBNull(reader.GetOrdinal("ModifiedAt")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("ModifiedAt"));
        var deletedById = reader.IsDBNull(reader.GetOrdinal("DeletedById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("DeletedById"));
        var deletedAt = reader.IsDBNull(reader.GetOrdinal("DeletedAt")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("DeletedAt"));
        var createdOnBehalfById = reader.IsDBNull(reader.GetOrdinal("CreatedOnBehalfById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("CreatedOnBehalfById"));
        var modifiedOnBehalfById = reader.IsDBNull(reader.GetOrdinal("ModifiedOnBehalfById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("ModifiedOnBehalfById"));

        return new Lead
        {
            Id = id,
            Source = source,
            Status = status,
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Phone = phone,
            ActionId = actionId,
            CreatedById = createdById,
            ModifiedById = modifiedById,
            CreatedAt = createdAt,
            ModifiedAt = modifiedAt,
            DeletedById = deletedById,
            DeletedAt = deletedAt,
            CreatedOnBehalfById = createdOnBehalfById,
            ModifiedOnBehalfById = modifiedOnBehalfById
        };
    }
 }
