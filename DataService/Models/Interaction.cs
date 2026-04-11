using System;

namespace DataService.Models;

public record Interaction
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string InteractionType { get; init; } = string.Empty;
    public Guid? AccountId { get; init; }
    public Guid? ContactId { get; init; }
    public Guid? LeadId { get; init; }
    public Guid? PerformedByUserId { get; init; }
    public DateTime PerformedAt { get; init; } = DateTime.UtcNow;
    public string? PayloadJson { get; init; }

    // audit
    public Guid? ActionId { get; init; }
    public Guid? CreatedById { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
}
