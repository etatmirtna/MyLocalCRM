using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public class PhoneCallRepository : IPhoneCallRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public PhoneCallRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task AddAsync(PhoneCall phoneCall)
    {
        const string sql = @"INSERT INTO PhoneCalls (Id, Subject, OccurredAt, DurationSeconds, FromUserId, ToUserId, AccountId, ContactId, LeadId, Notes, ActionId, CreatedById, ModifiedById, CreatedAt, ModifiedAt, DeletedById, DeletedAt, CreatedOnBehalfById, ModifiedOnBehalfById)
VALUES (@Id, @Subject, @OccurredAt, @DurationSeconds, @FromUserId, @ToUserId, @AccountId, @ContactId, @LeadId, @Notes, @ActionId, @CreatedById, @ModifiedById, @CreatedAt, @ModifiedAt, @DeletedById, @DeletedAt, @CreatedOnBehalfById, @ModifiedOnBehalfById)";

        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", phoneCall.Id);
        AddParameter(cmd, "Subject", (object?)phoneCall.Subject ?? DBNull.Value);
        AddParameter(cmd, "OccurredAt", phoneCall.OccurredAt);
        AddParameter(cmd, "DurationSeconds", (object?)phoneCall.DurationSeconds ?? DBNull.Value);
        AddParameter(cmd, "FromUserId", (object?)phoneCall.FromUserId ?? DBNull.Value);
        AddParameter(cmd, "ToUserId", (object?)phoneCall.ToUserId ?? DBNull.Value);
        AddParameter(cmd, "AccountId", (object?)phoneCall.AccountId ?? DBNull.Value);
        AddParameter(cmd, "ContactId", (object?)phoneCall.CustomerId ?? DBNull.Value);
        AddParameter(cmd, "LeadId", DBNull.Value);
        AddParameter(cmd, "Notes", (object?)phoneCall.Notes ?? DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)phoneCall.ActionId ?? DBNull.Value);
        AddParameter(cmd, "CreatedById", (object?)phoneCall.CreatedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)phoneCall.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "CreatedAt", phoneCall.CreatedAt);
        AddParameter(cmd, "ModifiedAt", (object?)phoneCall.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "DeletedById", (object?)phoneCall.DeletedById ?? DBNull.Value);
        AddParameter(cmd, "DeletedAt", (object?)phoneCall.DeletedAt ?? DBNull.Value);
        AddParameter(cmd, "CreatedOnBehalfById", (object?)phoneCall.CreatedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)phoneCall.ModifiedOnBehalfById ?? DBNull.Value);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        const string sql = "UPDATE PhoneCalls SET DeletedAt = @DeletedAt WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "DeletedAt", DateTime.UtcNow);
        AddParameter(cmd, "Id", id);
        await cmd.ExecuteNonQueryAsync();
    }

    public async Task<IEnumerable<PhoneCall>> GetAllAsync()
    {
        const string sql = "SELECT * FROM PhoneCalls WHERE DeletedAt IS NULL";
        var results = new List<PhoneCall>();
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            results.Add(ReadPhoneCall(reader));
        }

        return results;
    }

    public async Task<PhoneCall?> GetByIdAsync(Guid id)
    {
        const string sql = "SELECT * FROM PhoneCalls WHERE Id = @Id AND DeletedAt IS NULL";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", id);
        await using var reader = await cmd.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return ReadPhoneCall(reader);
        }

        return null;
    }

    public async Task UpdateAsync(PhoneCall phoneCall)
    {
        const string sql = @"UPDATE PhoneCalls SET Subject=@Subject, OccurredAt=@OccurredAt, DurationSeconds=@DurationSeconds, FromUserId=@FromUserId, ToUserId=@ToUserId, AccountId=@AccountId, ContactId=@ContactId, LeadId=@LeadId, Notes=@Notes, ActionId=@ActionId, ModifiedById=@ModifiedById, ModifiedAt=@ModifiedAt, ModifiedOnBehalfById=@ModifiedOnBehalfById
WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Subject", (object?)phoneCall.Subject ?? DBNull.Value);
        AddParameter(cmd, "OccurredAt", phoneCall.OccurredAt);
        AddParameter(cmd, "DurationSeconds", (object?)phoneCall.DurationSeconds ?? DBNull.Value);
        AddParameter(cmd, "FromUserId", (object?)phoneCall.FromUserId ?? DBNull.Value);
        AddParameter(cmd, "ToUserId", (object?)phoneCall.ToUserId ?? DBNull.Value);
        AddParameter(cmd, "AccountId", (object?)phoneCall.AccountId ?? DBNull.Value);
        AddParameter(cmd, "ContactId", (object?)phoneCall.CustomerId ?? DBNull.Value);
        AddParameter(cmd, "LeadId", DBNull.Value);
        AddParameter(cmd, "Notes", (object?)phoneCall.Notes ?? DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)phoneCall.ActionId ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)phoneCall.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedAt", (object?)phoneCall.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)phoneCall.ModifiedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "Id", phoneCall.Id);
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
+    private static PhoneCall ReadPhoneCall(DbDataReader reader)
+    {
+        var id = reader.GetGuid(reader.GetOrdinal("Id"));
+        var subject = reader.IsDBNull(reader.GetOrdinal("Subject")) ? null : reader.GetString(reader.GetOrdinal("Subject"));
+        var occurredAt = reader.GetDateTime(reader.GetOrdinal("OccurredAt"));
+        var duration = reader.IsDBNull(reader.GetOrdinal("DurationSeconds")) ? null : reader.GetInt32(reader.GetOrdinal("DurationSeconds"));
+        var fromUserId = reader.IsDBNull(reader.GetOrdinal("FromUserId")) ? null : reader.GetGuid(reader.GetOrdinal("FromUserId"));
+        var toUserId = reader.IsDBNull(reader.GetOrdinal("ToUserId")) ? null : reader.GetGuid(reader.GetOrdinal("ToUserId"));
+        var accountId = reader.IsDBNull(reader.GetOrdinal("AccountId")) ? null : reader.GetGuid(reader.GetOrdinal("AccountId"));
+        var contactId = reader.IsDBNull(reader.GetOrdinal("ContactId")) ? null : reader.GetGuid(reader.GetOrdinal("ContactId"));
+        var leadId = reader.IsDBNull(reader.GetOrdinal("LeadId")) ? null : reader.GetGuid(reader.GetOrdinal("LeadId"));
+        var notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes"));
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
+        return new PhoneCall
+        {
+            Id = id,
+            FromUserId = fromUserId,
+            ToUserId = toUserId,
+            CustomerId = contactId,
+            AccountId = accountId,
+            OccurredAt = occurredAt,
+            Notes = notes,
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
