using System;

namespace DataService.Models;

public record Appointment
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Title { get; init; } = string.Empty;
    public string? Description { get; init; }
    public DateTime Start { get; init; }
    public DateTime End { get; init; }
    public Guid? CustomerId { get; init; }
    public Guid? AccountId { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
}
