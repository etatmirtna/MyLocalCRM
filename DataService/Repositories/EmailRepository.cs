using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public class EmailRepository : IEmailRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public EmailRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task AddAsync(EmailMessage email)
    {
        const string sql = @"INSERT INTO Emails (Id, Subject, Body, SentAt, FromUserId, ToUserId, AccountId, ContactId, LeadId, ActionId, CreatedById, ModifiedById, CreatedAt, ModifiedAt, DeletedById, DeletedAt, CreatedOnBehalfById, ModifiedOnBehalfById)
VALUES (@Id, @Subject, @Body, @SentAt, @FromUserId, @ToUserId, @AccountId, @ContactId, @LeadId, @ActionId, @CreatedById, @ModifiedById, @CreatedAt, @ModifiedAt, @DeletedById, @DeletedAt, @CreatedOnBehalfById, @ModifiedOnBehalfById)";

        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", email.Id);
        AddParameter(cmd, "Subject", (object?)email.Subject ?? DBNull.Value);
        AddParameter(cmd, "Body", (object?)email.Body ?? DBNull.Value);
        AddParameter(cmd, "SentAt", (object?)email.SentAt ?? DBNull.Value);
        AddParameter(cmd, "FromUserId", (object?)email.FromUserId ?? DBNull.Value);
        AddParameter(cmd, "ToUserId", (object?)email.ToUserId ?? DBNull.Value);
        AddParameter(cmd, "AccountId", (object?)email.AccountId ?? DBNull.Value);
        AddParameter(cmd, "ContactId", (object?)email.CustomerId ?? DBNull.Value);
        AddParameter(cmd, "LeadId", DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)email.ActionId ?? DBNull.Value);
        AddParameter(cmd, "CreatedById", (object?)email.CreatedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)email.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "CreatedAt", email.CreatedAt);
        AddParameter(cmd, "ModifiedAt", (object?)email.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "DeletedById", (object?)email.DeletedById ?? DBNull.Value);
        AddParameter(cmd, "DeletedAt", (object?)email.DeletedAt ?? DBNull.Value);
        AddParameter(cmd, "CreatedOnBehalfById", (object?)email.CreatedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)email.ModifiedOnBehalfById ?? DBNull.Value);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        const string sql = "UPDATE Emails SET DeletedAt = @DeletedAt WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "DeletedAt", DateTime.UtcNow);
        AddParameter(cmd, "Id", id);
        await cmd.ExecuteNonQueryAsync();
    }

    public async Task<IEnumerable<EmailMessage>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Emails WHERE DeletedAt IS NULL";
        var results = new List<EmailMessage>();
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            results.Add(ReadEmail(reader));
        }

        return results;
    }

    public async Task<EmailMessage?> GetByIdAsync(Guid id)
    {
        const string sql = "SELECT * FROM Emails WHERE Id = @Id AND DeletedAt IS NULL";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", id);
        await using var reader = await cmd.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return ReadEmail(reader);
        }

        return null;
    }

    public async Task UpdateAsync(EmailMessage email)
    {
        const string sql = @"UPDATE Emails SET Subject=@Subject, Body=@Body, SentAt=@SentAt, FromUserId=@FromUserId, ToUserId=@ToUserId, AccountId=@AccountId, ContactId=@ContactId, LeadId=@LeadId, ActionId=@ActionId, ModifiedById=@ModifiedById, ModifiedAt=@ModifiedAt, ModifiedOnBehalfById=@ModifiedOnBehalfById
WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Subject", (object?)email.Subject ?? DBNull.Value);
        AddParameter(cmd, "Body", (object?)email.Body ?? DBNull.Value);
        AddParameter(cmd, "SentAt", (object?)email.SentAt ?? DBNull.Value);
        AddParameter(cmd, "FromUserId", (object?)email.FromUserId ?? DBNull.Value);
        AddParameter(cmd, "ToUserId", (object?)email.ToUserId ?? DBNull.Value);
        AddParameter(cmd, "AccountId", (object?)email.AccountId ?? DBNull.Value);
        AddParameter(cmd, "ContactId", (object?)email.CustomerId ?? DBNull.Value);
        AddParameter(cmd, "LeadId", DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)email.ActionId ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)email.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedAt", (object?)email.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)email.ModifiedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "Id", email.Id);
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
+    private static EmailMessage ReadEmail(DbDataReader reader)
+    {
+        var id = reader.GetGuid(reader.GetOrdinal("Id"));
+        var subject = reader.IsDBNull(reader.GetOrdinal("Subject")) ? null : reader.GetString(reader.GetOrdinal("Subject"));
+        var body = reader.IsDBNull(reader.GetOrdinal("Body")) ? null : reader.GetString(reader.GetOrdinal("Body"));
+        var sentAt = reader.IsDBNull(reader.GetOrdinal("SentAt")) ? null : reader.GetDateTime(reader.GetOrdinal("SentAt"));
+        var fromUserId = reader.IsDBNull(reader.GetOrdinal("FromUserId")) ? null : reader.GetGuid(reader.GetOrdinal("FromUserId"));
+        var toUserId = reader.IsDBNull(reader.GetOrdinal("ToUserId")) ? null : reader.GetGuid(reader.GetOrdinal("ToUserId"));
+        var accountId = reader.IsDBNull(reader.GetOrdinal("AccountId")) ? null : reader.GetGuid(reader.GetOrdinal("AccountId"));
+        var contactId = reader.IsDBNull(reader.GetOrdinal("ContactId")) ? null : reader.GetGuid(reader.GetOrdinal("ContactId"));
+        var leadId = reader.IsDBNull(reader.GetOrdinal("LeadId")) ? null : reader.GetGuid(reader.GetOrdinal("LeadId"));
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
+        return new EmailMessage
+        {
+            Id = id,
+            Subject = subject ?? string.Empty,
+            Body = body ?? string.Empty,
+            SentAt = sentAt ?? DateTime.MinValue,
+            FromUserId = fromUserId,
+            ToUserId = toUserId,
+            AccountId = accountId,
+            CustomerId = contactId,
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
