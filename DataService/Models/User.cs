using System;

namespace DataService.Models;

public record User
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Username { get; init; } = string.Empty;
    public string FullName { get; init; } = string.Empty;
    public string? Email { get; init; }
    public string? PasswordHash { get; init; }
    public bool IsActive { get; init; } = true;
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
}
