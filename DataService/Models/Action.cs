using System;

namespace DataService.Models;

public record Action
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string ActionType { get; init; } = string.Empty;
    public string? Description { get; init; }
    public Guid? PerformedByUserId { get; init; }
    public DateTime? PerformedAt { get; init; }

    public Guid? CreatedById { get; init; }
    public Guid? ModifiedById { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime? ModifiedAt { get; init; }
    public Guid? DeletedById { get; init; }
    public DateTime? DeletedAt { get; init; }
    public Guid? CreatedOnBehalfById { get; init; }
    public Guid? ModifiedOnBehalfById { get; init; }
}
