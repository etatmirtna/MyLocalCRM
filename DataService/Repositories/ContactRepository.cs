using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public class ContactRepository : IContactRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public ContactRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task AddAsync(Contact contact)
    {
        const string sql = @"INSERT INTO Contacts (Id, FirstName, LastName, ContactType, Email, Phone, ActionId, CreatedById, ModifiedById, CreatedAt, ModifiedAt, DeletedById, DeletedAt, CreatedOnBehalfById, ModifiedOnBehalfById)
VALUES (@Id, @FirstName, @LastName, @ContactType, @Email, @Phone, @ActionId, @CreatedById, @ModifiedById, @CreatedAt, @ModifiedAt, @DeletedById, @DeletedAt, @CreatedOnBehalfById, @ModifiedOnBehalfById)";

        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", contact.Id);
        AddParameter(cmd, "FirstName", (object?)contact.FirstName ?? DBNull.Value);
        AddParameter(cmd, "LastName", (object?)contact.LastName ?? DBNull.Value);
        AddParameter(cmd, "ContactType", (object?)contact.ContactType ?? DBNull.Value);
        AddParameter(cmd, "Email", (object?)contact.Email ?? DBNull.Value);
        AddParameter(cmd, "Phone", (object?)contact.Phone ?? DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)contact.ActionId ?? DBNull.Value);
        AddParameter(cmd, "CreatedById", (object?)contact.CreatedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)contact.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "CreatedAt", contact.CreatedAt);
        AddParameter(cmd, "ModifiedAt", (object?)contact.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "DeletedById", (object?)contact.DeletedById ?? DBNull.Value);
        AddParameter(cmd, "DeletedAt", (object?)contact.DeletedAt ?? DBNull.Value);
        AddParameter(cmd, "CreatedOnBehalfById", (object?)contact.CreatedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)contact.ModifiedOnBehalfById ?? DBNull.Value);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        const string sql = "UPDATE Contacts SET DeletedAt = @DeletedAt WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "DeletedAt", DateTime.UtcNow);
        AddParameter(cmd, "Id", id);
        await cmd.ExecuteNonQueryAsync();
    }

    public async Task<IEnumerable<Contact>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Contacts WHERE DeletedAt IS NULL";
        var results = new List<Contact>();
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            results.Add(ReadContact(reader));
        }

        return results;
    }

    public async Task<Contact?> GetByIdAsync(Guid id)
    {
        const string sql = "SELECT * FROM Contacts WHERE Id = @Id AND DeletedAt IS NULL";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", id);
        await using var reader = await cmd.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return ReadContact(reader);
        }

        return null;
    }

    public async Task UpdateAsync(Contact contact)
    {
        const string sql = @"UPDATE Contacts SET FirstName=@FirstName, LastName=@LastName, ContactType=@ContactType, Email=@Email, Phone=@Phone, ActionId=@ActionId, ModifiedById=@ModifiedById, ModifiedAt=@ModifiedAt, ModifiedOnBehalfById=@ModifiedOnBehalfById
WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "FirstName", (object?)contact.FirstName ?? DBNull.Value);
        AddParameter(cmd, "LastName", (object?)contact.LastName ?? DBNull.Value);
        AddParameter(cmd, "ContactType", (object?)contact.ContactType ?? DBNull.Value);
        AddParameter(cmd, "Email", (object?)contact.Email ?? DBNull.Value);
        AddParameter(cmd, "Phone", (object?)contact.Phone ?? DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)contact.ActionId ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)contact.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedAt", (object?)contact.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)contact.ModifiedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "Id", contact.Id);
        await cmd.ExecuteNonQueryAsync();
    }

    private static void AddParameter(DbCommand cmd, string name, object? value)
    {
        var p = cmd.CreateParameter();
        p.ParameterName = $"@ {name}";
        p.Value = value ?? DBNull.Value;
        cmd.Parameters.Add(p);
    }

    private static Contact ReadContact(DbDataReader reader)
    {
        var id = reader.GetGuid(reader.GetOrdinal("Id"));
        var firstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? null : reader.GetString(reader.GetOrdinal("FirstName"));
        var lastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString(reader.GetOrdinal("LastName"));
        var contactType = reader.IsDBNull(reader.GetOrdinal("ContactType")) ? null : reader.GetString(reader.GetOrdinal("ContactType"));
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

        return new Contact
        {
            Id = id,
            FirstName = firstName,
            LastName = lastName,
            ContactType = contactType,
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
