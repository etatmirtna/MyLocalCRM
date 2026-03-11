using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public class ActionRepository : IActionRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public ActionRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task AddAsync(Action action)
    {
        const string sql = @"INSERT INTO Actions (Id, ActionType, Description, PerformedByUserId, PerformedAt, CreatedById, ModifiedById, CreatedAt, ModifiedAt, DeletedById, DeletedAt, CreatedOnBehalfById, ModifiedOnBehalfById)
VALUES (@Id, @ActionType, @Description, @PerformedByUserId, @PerformedAt, @CreatedById, @ModifiedById, @CreatedAt, @ModifiedAt, @DeletedById, @DeletedAt, @CreatedOnBehalfById, @ModifiedOnBehalfById)";

        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", action.Id);
        AddParameter(cmd, "ActionType", action.ActionType);
        AddParameter(cmd, "Description", (object?)action.Description ?? DBNull.Value);
        AddParameter(cmd, "PerformedByUserId", (object?)action.PerformedByUserId ?? DBNull.Value);
        AddParameter(cmd, "PerformedAt", (object?)action.PerformedAt ?? DBNull.Value);
        AddParameter(cmd, "CreatedById", (object?)action.CreatedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)action.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "CreatedAt", action.CreatedAt);
        AddParameter(cmd, "ModifiedAt", (object?)action.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "DeletedById", (object?)action.DeletedById ?? DBNull.Value);
        AddParameter(cmd, "DeletedAt", (object?)action.DeletedAt ?? DBNull.Value);
        AddParameter(cmd, "CreatedOnBehalfById", (object?)action.CreatedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)action.ModifiedOnBehalfById ?? DBNull.Value);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        const string sql = "UPDATE Actions SET DeletedAt = @DeletedAt WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "DeletedAt", DateTime.UtcNow);
        AddParameter(cmd, "Id", id);
        await cmd.ExecuteNonQueryAsync();
    }

    public async Task<IEnumerable<Action>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Actions WHERE DeletedAt IS NULL";
        var results = new List<Action>();
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            results.Add(ReadAction(reader));
        }

        return results;
    }

    public async Task<Action?> GetByIdAsync(Guid id)
    {
        const string sql = "SELECT * FROM Actions WHERE Id = @Id AND DeletedAt IS NULL";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", id);
        await using var reader = await cmd.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return ReadAction(reader);
        }

        return null;
    }

    public async Task UpdateAsync(Action action)
    {
        const string sql = @"UPDATE Actions SET ActionType=@ActionType, Description=@Description, PerformedByUserId=@PerformedByUserId, PerformedAt=@PerformedAt, ModifiedById=@ModifiedById, ModifiedAt=@ModifiedAt, ModifiedOnBehalfById=@ModifiedOnBehalfById
WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "ActionType", action.ActionType);
        AddParameter(cmd, "Description", (object?)action.Description ?? DBNull.Value);
        AddParameter(cmd, "PerformedByUserId", (object?)action.PerformedByUserId ?? DBNull.Value);
        AddParameter(cmd, "PerformedAt", (object?)action.PerformedAt ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)action.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedAt", (object?)action.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)action.ModifiedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "Id", action.Id);
        await cmd.ExecuteNonQueryAsync();
    }

+    private static void AddParameter(DbCommand cmd, string name, object? value)
+    {
+        var p = cmd.CreateParameter();
+        p.ParameterName = "@" + name;
+        p.Value = value ?? DBNull.Value;
+        cmd.Parameters.Add(p);
+    }
+
+    private static Action ReadAction(DbDataReader reader)
+    {
+        var id = reader.GetGuid(reader.GetOrdinal("Id"));
+        var actionType = reader.GetString(reader.GetOrdinal("ActionType"));
+        var description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description"));
+        var performedByUserId = reader.IsDBNull(reader.GetOrdinal("PerformedByUserId")) ? null : reader.GetGuid(reader.GetOrdinal("PerformedByUserId"));
+        var performedAt = reader.IsDBNull(reader.GetOrdinal("PerformedAt")) ? null : reader.GetDateTime(reader.GetOrdinal("PerformedAt"));
+
+        var createdById = reader.IsDBNull(reader.GetOrdinal("CreatedById")) ? null : reader.GetGuid(reader.GetOrdinal("CreatedById"));
+        var modifiedById = reader.IsDBNull(reader.GetOrdinal("ModifiedById")) ? null : reader.GetGuid(reader.GetOrdinal("ModifiedById"));
+        var createdAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"));
+        var modifiedAt = reader.IsDBNull(reader.GetOrdinal("ModifiedAt")) ? null : reader.GetDateTime(reader.GetOrdinal("ModifiedAt"));
+        var deletedById = reader.IsDBNull(reader.GetOrdinal("DeletedById")) ? null : reader.GetGuid(reader.GetOrdinal("DeletedById"));
+        var deletedAt = reader.IsDBNull(reader.GetOrdinal("DeletedAt")) ? null : reader.GetDateTime(reader.GetOrdinal("DeletedAt"));
+        var createdOnBehalfById = reader.IsDBNull(reader.GetOrdinal("CreatedOnBehalfById")) ? null : reader.GetGuid(reader.GetOrdinal("CreatedOnBehalfById"));
+        var modifiedOnBehalfById = reader.IsDBNull(reader.GetOrdinal("ModifiedOnBehalfById")) ? null : reader.GetGuid(reader.GetOrdinal("ModifiedOnBehalfById"));
+
+        return new Action
+        {
+            Id = id,
+            ActionType = actionType,
+            Description = description,
+            PerformedByUserId = performedByUserId,
+            PerformedAt = performedAt,
+            CreatedById = createdById,
+            ModifiedById = modifiedById,
+            CreatedAt = createdAt,
+            ModifiedAt = modifiedAt,
+            DeletedById = deletedById,
+            DeletedAt = deletedAt,
+            CreatedOnBehalfById = createdOnBehalfById,
+            ModifiedOnBehalfById = modifiedOnBehalfById
+        };
+    }
 }
