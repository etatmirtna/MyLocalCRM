using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public AccountRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task AddAsync(Account account)
    {
        const string sql = @"INSERT INTO Accounts (Id, Name, Industry, Website, ActionId, CreatedById, ModifiedById, CreatedAt, ModifiedAt, DeletedById, DeletedAt, CreatedOnBehalfById, ModifiedOnBehalfById)
VALUES (@Id, @Name, @Industry, @Website, @ActionId, @CreatedById, @ModifiedById, @CreatedAt, @ModifiedAt, @DeletedById, @DeletedAt, @CreatedOnBehalfById, @ModifiedOnBehalfById)";

        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", account.Id);
        AddParameter(cmd, "Name", account.Name);
        AddParameter(cmd, "Industry", (object?)account.Industry ?? DBNull.Value);
        AddParameter(cmd, "Website", (object?)account.Website ?? DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)account.ActionId ?? DBNull.Value);
        AddParameter(cmd, "CreatedById", (object?)account.CreatedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)account.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "CreatedAt", account.CreatedAt);
        AddParameter(cmd, "ModifiedAt", (object?)account.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "DeletedById", (object?)account.DeletedById ?? DBNull.Value);
        AddParameter(cmd, "DeletedAt", (object?)account.DeletedAt ?? DBNull.Value);
        AddParameter(cmd, "CreatedOnBehalfById", (object?)account.CreatedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)account.ModifiedOnBehalfById ?? DBNull.Value);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        const string sql = "UPDATE Accounts SET DeletedAt = @DeletedAt WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "DeletedAt", DateTime.UtcNow);
        AddParameter(cmd, "Id", id);
        await cmd.ExecuteNonQueryAsync();
    }

    public async Task<IEnumerable<Account>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Accounts WHERE DeletedAt IS NULL";
        var results = new List<Account>();
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            results.Add(ReadAccount(reader));
        }

        return results;
    }

    public async Task<Account?> GetByIdAsync(Guid id)
    {
        const string sql = "SELECT * FROM Accounts WHERE Id = @Id AND DeletedAt IS NULL";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", id);
        await using var reader = await cmd.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return ReadAccount(reader);
        }

        return null;
    }

    public async Task UpdateAsync(Account account)
    {
        const string sql = @"UPDATE Accounts SET Name=@Name, Industry=@Industry, Website=@Website, ActionId=@ActionId, ModifiedById=@ModifiedById, ModifiedAt=@ModifiedAt, ModifiedOnBehalfById=@ModifiedOnBehalfById
WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Name", account.Name);
        AddParameter(cmd, "Industry", (object?)account.Industry ?? DBNull.Value);
        AddParameter(cmd, "Website", (object?)account.Website ?? DBNull.Value);
        AddParameter(cmd, "ActionId", (object?)account.ActionId ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)account.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedAt", (object?)account.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)account.ModifiedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "Id", account.Id);
        await cmd.ExecuteNonQueryAsync();
    }

    private static void AddParameter(DbCommand cmd, string name, object? value)
    {
        var p = cmd.CreateParameter();
        p.ParameterName = "@" + name;
        p.Value = value ?? DBNull.Value;
        cmd.Parameters.Add(p);
    }

    /// <summary>
    /// Creates an Account instance by reading the current row from the specified data reader.
    /// </summary>
    /// <remarks>The method expects the reader to contain columns matching the Account properties. Nullable
    /// database fields are mapped to default values or null as appropriate.</remarks>
    /// <param name="reader">The data reader positioned at the row containing account data. Must not be null.</param>
    /// <returns>An Account object populated with values from the current row of the reader.</returns>
    private static Account ReadAccount(DbDataReader reader)
    {
        var id = reader.GetGuid(reader.GetOrdinal("Id"));
        var name = reader.GetString(reader.GetOrdinal("Name"));
        var industry = reader.IsDBNull(reader.GetOrdinal("Industry")) ? null : reader.GetString(reader.GetOrdinal("Industry"));
        var website = reader.IsDBNull(reader.GetOrdinal("Website")) ? null : reader.GetString(reader.GetOrdinal("Website"));
        var actionId = reader.IsDBNull(reader.GetOrdinal("ActionId")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("ActionId"));
        var createdById = reader.IsDBNull(reader.GetOrdinal("CreatedById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("CreatedById"));
        var modifiedById = reader.IsDBNull(reader.GetOrdinal("ModifiedById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("ModifiedById"));
        var createdAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"));
        var modifiedAt = reader.IsDBNull(reader.GetOrdinal("ModifiedAt")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("ModifiedAt"));
        var deletedById = reader.IsDBNull(reader.GetOrdinal("DeletedById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("DeletedById"));
        var deletedAt = reader.IsDBNull(reader.GetOrdinal("DeletedAt")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("DeletedAt"));
        var createdOnBehalfById = reader.IsDBNull(reader.GetOrdinal("CreatedOnBehalfById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("CreatedOnBehalfById"));
        var modifiedOnBehalfById = reader.IsDBNull(reader.GetOrdinal("ModifiedOnBehalfById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("ModifiedOnBehalfById"));

        return new Account
        {
            Id = id,
            Name = name,
            Industry = industry,
            Website = website,
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
