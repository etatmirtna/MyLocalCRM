using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public UserRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task AddAsync(User user)
    {
        const string sql = @"INSERT INTO Users (Id, Username, FullName, Email, PasswordHash, IsActive, ActionId, CreatedById, ModifiedById, CreatedAt, ModifiedAt, DeletedById, DeletedAt, CreatedOnBehalfById, ModifiedOnBehalfById)
VALUES (@Id, @Username, @FullName, @Email, @PasswordHash, @IsActive, @ActionId, @CreatedById, @ModifiedById, @CreatedAt, @ModifiedAt, @DeletedById, @DeletedAt, @CreatedOnBehalfById, @ModifiedOnBehalfById)";

        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", user.Id);
        AddParameter(cmd, "Username", user.Username);
        AddParameter(cmd, "FullName", (object?)user.FullName ?? DBNull.Value);
        AddParameter(cmd, "Email", (object?)user.Email ?? DBNull.Value);
        AddParameter(cmd, "PasswordHash", (object?)user.PasswordHash ?? DBNull.Value);
        AddParameter(cmd, "IsActive", user.IsActive);
        AddParameter(cmd, "ActionId", (object?)user.ActionId ?? DBNull.Value);
        AddParameter(cmd, "CreatedById", (object?)user.CreatedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)user.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "CreatedAt", user.CreatedAt);
        AddParameter(cmd, "ModifiedAt", (object?)user.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "DeletedById", (object?)user.DeletedById ?? DBNull.Value);
        AddParameter(cmd, "DeletedAt", (object?)user.DeletedAt ?? DBNull.Value);
        AddParameter(cmd, "CreatedOnBehalfById", (object?)user.CreatedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)user.ModifiedOnBehalfById ?? DBNull.Value);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        const string sql = "UPDATE Users SET DeletedAt = @DeletedAt WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "DeletedAt", DateTime.UtcNow);
        AddParameter(cmd, "Id", id);
        await cmd.ExecuteNonQueryAsync();
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Users WHERE DeletedAt IS NULL";
        var results = new List<User>();
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            results.Add(ReadUser(reader));
        }

        return results;
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        const string sql = "SELECT * FROM Users WHERE Id = @Id AND DeletedAt IS NULL";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Id", id);
        await using var reader = await cmd.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return ReadUser(reader);
        }

        return null;
    }

    public async Task UpdateAsync(User user)
    {
        const string sql = @"UPDATE Users SET Username=@Username, FullName=@FullName, Email=@Email, PasswordHash=@PasswordHash, IsActive=@IsActive, ActionId=@ActionId, ModifiedById=@ModifiedById, ModifiedAt=@ModifiedAt, ModifiedOnBehalfById=@ModifiedOnBehalfById
WHERE Id = @Id";
        await using var conn = _connectionFactory.CreateConnection();
        await conn.OpenAsync();
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        AddParameter(cmd, "Username", user.Username);
        AddParameter(cmd, "FullName", (object?)user.FullName ?? DBNull.Value);
        AddParameter(cmd, "Email", (object?)user.Email ?? DBNull.Value);
        AddParameter(cmd, "PasswordHash", (object?)user.PasswordHash ?? DBNull.Value);
        AddParameter(cmd, "IsActive", user.IsActive);
        AddParameter(cmd, "ActionId", (object?)user.ActionId ?? DBNull.Value);
        AddParameter(cmd, "ModifiedById", (object?)user.ModifiedById ?? DBNull.Value);
        AddParameter(cmd, "ModifiedAt", (object?)user.ModifiedAt ?? DBNull.Value);
        AddParameter(cmd, "ModifiedOnBehalfById", (object?)user.ModifiedOnBehalfById ?? DBNull.Value);
        AddParameter(cmd, "Id", user.Id);
        await cmd.ExecuteNonQueryAsync();
    }

    private static void AddParameter(DbCommand cmd, string name, object? value)
    {
        var p = cmd.CreateParameter();
        p.ParameterName = $"@{name}";
        p.Value = value ?? DBNull.Value;
        cmd.Parameters.Add(p);
    }

    private static User ReadUser(DbDataReader reader)
    {
        var id = reader.GetGuid(reader.GetOrdinal("Id"));
        var username = reader.GetString(reader.GetOrdinal("Username"));
        var fullName = reader.IsDBNull(reader.GetOrdinal("FullName")) ? null : reader.GetString(reader.GetOrdinal("FullName"));
        var email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email"));
        var passwordHash = reader.IsDBNull(reader.GetOrdinal("PasswordHash")) ? null : reader.GetString(reader.GetOrdinal("PasswordHash"));
        var isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
        var actionId = reader.IsDBNull(reader.GetOrdinal("ActionId")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("ActionId"));
        var createdById = reader.IsDBNull(reader.GetOrdinal("CreatedById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("CreatedById"));
        var modifiedById = reader.IsDBNull(reader.GetOrdinal("ModifiedById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("ModifiedById"));
        var createdAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"));
        var modifiedAt = reader.IsDBNull(reader.GetOrdinal("ModifiedAt")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("ModifiedAt"));
        var deletedById = reader.IsDBNull(reader.GetOrdinal("DeletedById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("DeletedById"));
        var deletedAt = reader.IsDBNull(reader.GetOrdinal("DeletedAt")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("DeletedAt"));
        var createdOnBehalfById = reader.IsDBNull(reader.GetOrdinal("CreatedOnBehalfById")) ? Guid.Empty: reader.GetGuid(reader.GetOrdinal("CreatedOnBehalfById"));
        var modifiedOnBehalfById = reader.IsDBNull(reader.GetOrdinal("ModifiedOnBehalfById")) ? Guid.Empty : reader.GetGuid(reader.GetOrdinal("ModifiedOnBehalfById"));

        return new User
        {
            Id = id,
            Username = username,
            FullName = fullName ?? string.Empty,
            Email = email,
            PasswordHash = passwordHash,
            IsActive = isActive,
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
