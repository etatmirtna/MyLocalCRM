using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public CustomerRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task AddAsync(Customer customer)
    {
        const string sql = @"INSERT INTO Customers (Id, FirstName, LastName, Email, Phone, AccountId, ActionId, CreatedById, ModifiedById, CreatedAt, ModifiedAt, DeletedById, DeletedAt, CreatedOnBehalfById, ModifiedOnBehalfById)
VALUES (@Id, @FirstName, @LastName, @Email, @Phone, @AccountId, @ActionId, @CreatedById, @ModifiedById, @CreatedAt, @ModifiedAt, @DeletedById, @DeletedAt, @CreatedOnBehalfById, @ModifiedOnBehalfById)";

        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", customer.Id);
        AddParameter(cmd, "FirstName", customer.FirstName);
        AddParameter(cmd, "LastName", customer.LastName);
        AddParameter(cmd, "Email", (object?)customer.Email ?? DBNull.Value);
        AddParameter(cmd, "Phone", (object?)customer.Phone ?? DBNull.Value);
        AddParameter(cmd, "AccountId", (object?)customer.AccountId ?? DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)customer.ActionId ?? DBNull.Value);
        AddParameter(cmd, "CreatedById", (object?)customer.CreatedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)customer.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "CreatedAt", customer.CreatedAt);
        AddParameter(cmd, "ModifiedAt", (object?)customer.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "DeletedById", (object?)customer.DeletedById ?? DBNull.Value);
        AddParameter(cmd, "DeletedAt", (object?)customer.DeletedAt ?? DBNull.Value);
        AddParameter(cmd, "CreatedOnBehalfById", (object?)customer.CreatedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)customer.ModifiedOnBehalfById ?? DBNull.Value);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        // soft-delete: set DeletedAt and DeletedById; caller should provide DeletedById through a separate method or update
        const string sql = "UPDATE Customers SET DeletedAt = @DeletedAt WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "DeletedAt", DateTime.UtcNow);
        AddParameter(cmd, "Id", id);
        await cmd.ExecuteNonQueryAsync();
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Customers WHERE DeletedAt IS NULL";
        var results = new List<Customer>();
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            results.Add(ReadCustomer(reader));
        }

        return results;
    }

    public async Task<Customer?> GetByIdAsync(Guid id)
    {
        const string sql = "SELECT * FROM Customers WHERE Id = @Id AND DeletedAt IS NULL";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", id);
        await using var reader = await cmd.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return ReadCustomer(reader);
        }

        return null;
    }

    public async Task UpdateAsync(Customer customer)
    {
        const string sql = @"UPDATE Customers SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Phone=@Phone, AccountId=@AccountId, ActionId=@ActionId, ModifiedById=@ModifiedById, ModifiedAt=@ModifiedAt, ModifiedOnBehalfById=@ModifiedOnBehalfById
WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "FirstName", customer.FirstName);
        AddParameter(cmd, "LastName", customer.LastName);
        AddParameter(cmd, "Email", (object?)customer.Email ?? DBNull.Value);
        AddParameter(cmd, "Phone", (object?)customer.Phone ?? DBNull.Value);
        AddParameter(cmd, "AccountId", (object?)customer.AccountId ?? DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)customer.ActionId ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)customer.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedAt", (object?)customer.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)customer.ModifiedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "Id", customer.Id);
        await cmd.ExecuteNonQueryAsync();
    }

    private static void AddParameter(DbCommand cmd, string name, object? value)
    {
        var p = cmd.CreateParameter();
        p.ParameterName = "@" + name;
        p.Value = value ?? DBNull.Value;
        cmd.Parameters.Add(p);
    }

    private static Customer ReadCustomer(DbDataReader reader)
    {
        Guid? GetGuidOrNull(int idx) => reader.IsDBNull(idx) ? null : reader.GetGuid(idx);
        DateTime? GetDateOrNull(int idx) => reader.IsDBNull(idx) ? null : reader.GetDateTime(idx);

        // Map by column name to be resilient to ordering
        var id = reader.GetGuid(reader.GetOrdinal("Id"));
        var firstName = reader.GetString(reader.GetOrdinal("FirstName"));
        var lastName = reader.GetString(reader.GetOrdinal("LastName"));
        var email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email"));
        var phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? null : reader.GetString(reader.GetOrdinal("Phone"));
        var accountId = reader.IsDBNull(reader.GetOrdinal("AccountId")) ? null : reader.GetGuid(reader.GetOrdinal("AccountId"));
        var actionId = reader.IsDBNull(reader.GetOrdinal("ActionId")) ? null : reader.GetGuid(reader.GetOrdinal("ActionId"));
        var createdById = reader.IsDBNull(reader.GetOrdinal("CreatedById")) ? null : reader.GetGuid(reader.GetOrdinal("CreatedById"));
        var modifiedById = reader.IsDBNull(reader.GetOrdinal("ModifiedById")) ? null : reader.GetGuid(reader.GetOrdinal("ModifiedById"));
        var createdAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"));
        var modifiedAt = reader.IsDBNull(reader.GetOrdinal("ModifiedAt")) ? null : reader.GetDateTime(reader.GetOrdinal("ModifiedAt"));
        var deletedById = reader.IsDBNull(reader.GetOrdinal("DeletedById")) ? null : reader.GetGuid(reader.GetOrdinal("DeletedById"));
        var deletedAt = reader.IsDBNull(reader.GetOrdinal("DeletedAt")) ? null : reader.GetDateTime(reader.GetOrdinal("DeletedAt"));
        var createdOnBehalfById = reader.IsDBNull(reader.GetOrdinal("CreatedOnBehalfById")) ? null : reader.GetGuid(reader.GetOrdinal("CreatedOnBehalfById"));
        var modifiedOnBehalfById = reader.IsDBNull(reader.GetOrdinal("ModifiedOnBehalfById")) ? null : reader.GetGuid(reader.GetOrdinal("ModifiedOnBehalfById"));

        return new Customer
        {
            Id = id,
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Phone = phone,
            AccountId = accountId,
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
