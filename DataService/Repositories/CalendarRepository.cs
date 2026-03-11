using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public class CalendarRepository : ICalendarRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public CalendarRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task AddAsync(Calendar calendar)
    {
        const string sql = @"INSERT INTO Calendars (Id, Name, Description, TimeZone, OwnerUserId, ActionId, CreatedById, ModifiedById, CreatedAt, ModifiedAt, DeletedById, DeletedAt, CreatedOnBehalfById, ModifiedOnBehalfById)
VALUES (@Id, @Name, @Description, @TimeZone, @OwnerUserId, @ActionId, @CreatedById, @ModifiedById, @CreatedAt, @ModifiedAt, @DeletedById, @DeletedAt, @CreatedOnBehalfById, @ModifiedOnBehalfById)";

        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", calendar.Id);
        AddParameter(cmd, "Name", calendar.Name);
        AddParameter(cmd, "Description", (object?)calendar.Description ?? DBNull.Value);
        AddParameter(cmd, "TimeZone", (object?)calendar.TimeZone ?? DBNull.Value);
        AddParameter(cmd, "OwnerUserId", (object?)calendar.OwnerUserId ?? DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)calendar.ActionId ?? DBNull.Value);
        AddParameter(cmd, "CreatedById", (object?)calendar.CreatedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)calendar.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "CreatedAt", calendar.CreatedAt);
        AddParameter(cmd, "ModifiedAt", (object?)calendar.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "DeletedById", (object?)calendar.DeletedById ?? DBNull.Value);
        AddParameter(cmd, "DeletedAt", (object?)calendar.DeletedAt ?? DBNull.Value);
        AddParameter(cmd, "CreatedOnBehalfById", (object?)calendar.CreatedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)calendar.ModifiedOnBehalfById ?? DBNull.Value);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        const string sql = "UPDATE Calendars SET DeletedAt = @DeletedAt WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "DeletedAt", DateTime.UtcNow);
        AddParameter(cmd, "Id", id);
        await cmd.ExecuteNonQueryAsync();
    }

    public async Task<IEnumerable<Calendar>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Calendars WHERE DeletedAt IS NULL";
        var results = new List<Calendar>();
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            results.Add(ReadCalendar(reader));
        }

        return results;
    }

    public async Task<Calendar?> GetByIdAsync(Guid id)
    {
        const string sql = "SELECT * FROM Calendars WHERE Id = @Id AND DeletedAt IS NULL";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", id);
        await using var reader = await cmd.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return ReadCalendar(reader);
        }

        return null;
    }

    public async Task UpdateAsync(Calendar calendar)
    {
        const string sql = @"UPDATE Calendars SET Name=@Name, Description=@Description, TimeZone=@TimeZone, OwnerUserId=@OwnerUserId, ActionId=@ActionId, ModifiedById=@ModifiedById, ModifiedAt=@ModifiedAt, ModifiedOnBehalfById=@ModifiedOnBehalfById
WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Name", calendar.Name);
        AddParameter(cmd, "Description", (object?)calendar.Description ?? DBNull.Value);
        AddParameter(cmd, "TimeZone", (object?)calendar.TimeZone ?? DBNull.Value);
        AddParameter(cmd, "OwnerUserId", (object?)calendar.OwnerUserId ?? DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)calendar.ActionId ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)calendar.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedAt", (object?)calendar.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)calendar.ModifiedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "Id", calendar.Id);
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
+    private static Calendar ReadCalendar(DbDataReader reader)
+    {
+        var id = reader.GetGuid(reader.GetOrdinal("Id"));
+        var name = reader.GetString(reader.GetOrdinal("Name"));
+        var description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description"));
+        var timeZone = reader.IsDBNull(reader.GetOrdinal("TimeZone")) ? null : reader.GetString(reader.GetOrdinal("TimeZone"));
+        var ownerUserId = reader.IsDBNull(reader.GetOrdinal("OwnerUserId")) ? null : reader.GetGuid(reader.GetOrdinal("OwnerUserId"));
+        var actionId = reader.IsDBNull(reader.GetOrdinal("ActionId")) ? null : reader.GetGuid(reader.GetOrdinal("ActionId"));
+        var createdById = reader.IsDBNull(reader.GetOrdinal("CreatedById")) ? null : reader.GetGuid(reader.GetOrdinal("CreatedById"));
+        var modifiedById = reader.IsDBNull(reader.GetOrdinal("ModifiedById")) ? null : reader.GetGuid(reader.GetOrdinal("ModifiedById"));
+        var createdAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"));
+        var modifiedAt = reader.IsDBNull(reader.GetOrdinal("ModifiedAt")) ? null : reader.GetDateTime(reader.GetOrdinal("ModifiedAt"));
+        var deletedById = reader.IsDBNull(reader.GetOrdinal("DeletedById")) ? null : reader.GetGuid(reader.GetOrdinal("DeletedById"));
+        var deletedAt = reader.IsDBNull(reader.GetOrdinal("DeletedAt")) ? null : reader.GetDateTime(reader.GetOrdinal("DeletedAt"));
+        var createdOnBehalfById = reader.IsDBNull(reader.GetOrdinal("CreatedOnBehalfById")) ? null : reader.GetGuid(reader.GetOrdinal("CreatedOnBehalfById"));
+        var modifiedOnBehalfById = reader.IsDBNull(reader.GetOrdinal("ModifiedOnBehalfById")) ? null : reader.GetGuid(reader.GetOrdinal("ModifiedOnBehalfById"));
+
+        return new Calendar
+        {
+            Id = id,
+            Name = name,
+            Description = description,
+            TimeZone = timeZone,
+            OwnerUserId = ownerUserId,
+            ActionId = actionId,
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
