using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public class ChatRepository : IChatRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public ChatRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task AddAsync(ChatMessage chat)
    {
        const string sql = @"INSERT INTO Chats (Id, Message, SentAt, FromUserId, ToUserId, AccountId, ContactId, LeadId, ActionId, CreatedById, ModifiedById, CreatedAt, ModifiedAt, DeletedById, DeletedAt, CreatedOnBehalfById, ModifiedOnBehalfById)
VALUES (@Id, @Message, @SentAt, @FromUserId, @ToUserId, @AccountId, @ContactId, @LeadId, @ActionId, @CreatedById, @ModifiedById, @CreatedAt, @ModifiedAt, @DeletedById, @DeletedAt, @CreatedOnBehalfById, @ModifiedOnBehalfById)";

        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", chat.Id);
        AddParameter(cmd, "Message", chat.Message);
        AddParameter(cmd, "SentAt", chat.SentAt);
        AddParameter(cmd, "FromUserId", (object?)chat.FromUserId ?? DBNull.Value);
        AddParameter(cmd, "ToUserId", (object?)chat.ToUserId ?? DBNull.Value);
        AddParameter(cmd, "AccountId", (object?)chat.AccountId ?? DBNull.Value);
        AddParameter(cmd, "ContactId", (object?)chat.CustomerId ?? DBNull.Value);
        AddParameter(cmd, "LeadId", DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)chat.ActionId ?? DBNull.Value);
        AddParameter(cmd, "CreatedById", (object?)chat.CreatedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)chat.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "CreatedAt", chat.CreatedAt);
        AddParameter(cmd, "ModifiedAt", (object?)chat.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "DeletedById", (object?)chat.DeletedById ?? DBNull.Value);
        AddParameter(cmd, "DeletedAt", (object?)chat.DeletedAt ?? DBNull.Value);
        AddParameter(cmd, "CreatedOnBehalfById", (object?)chat.CreatedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)chat.ModifiedOnBehalfById ?? DBNull.Value);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        const string sql = "UPDATE Chats SET DeletedAt = @DeletedAt WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "DeletedAt", DateTime.UtcNow);
        AddParameter(cmd, "Id", id);
        await cmd.ExecuteNonQueryAsync();
    }

    public async Task<IEnumerable<ChatMessage>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Chats WHERE DeletedAt IS NULL";
        var results = new List<ChatMessage>();
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            results.Add(ReadChat(reader));
        }

        return results;
    }

    public async Task<ChatMessage?> GetByIdAsync(Guid id)
    {
        const string sql = "SELECT * FROM Chats WHERE Id = @Id AND DeletedAt IS NULL";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", id);
        await using var reader = await cmd.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return ReadChat(reader);
        }

        return null;
    }

    public async Task UpdateAsync(ChatMessage chat)
    {
        const string sql = @"UPDATE Chats SET Message=@Message, SentAt=@SentAt, FromUserId=@FromUserId, ToUserId=@ToUserId, AccountId=@AccountId, ContactId=@ContactId, LeadId=@LeadId, ActionId=@ActionId, ModifiedById=@ModifiedById, ModifiedAt=@ModifiedAt, ModifiedOnBehalfById=@ModifiedOnBehalfById
WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Message", chat.Message);
        AddParameter(cmd, "SentAt", chat.SentAt);
        AddParameter(cmd, "FromUserId", (object?)chat.FromUserId ?? DBNull.Value);
        AddParameter(cmd, "ToUserId", (object?)chat.ToUserId ?? DBNull.Value);
        AddParameter(cmd, "AccountId", (object?)chat.AccountId ?? DBNull.Value);
        AddParameter(cmd, "ContactId", (object?)chat.CustomerId ?? DBNull.Value);
        AddParameter(cmd, "LeadId", DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)chat.ActionId ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)chat.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedAt", (object?)chat.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)chat.ModifiedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "Id", chat.Id);
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
+    private static ChatMessage ReadChat(DbDataReader reader)
+    {
+        var id = reader.GetGuid(reader.GetOrdinal("Id"));
+        var message = reader.IsDBNull(reader.GetOrdinal("Message")) ? null : reader.GetString(reader.GetOrdinal("Message"));
+        var sentAt = reader.GetDateTime(reader.GetOrdinal("SentAt"));
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
+        return new ChatMessage
+        {
+            Id = id,
+            Message = message ?? string.Empty,
+            SentAt = sentAt,
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
