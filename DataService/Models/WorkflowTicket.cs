using System;

namespace DataService.Models;

/// <summary>
/// The workflow ticket represents the state of an interaction as it moves through the workflow engine. 
/// It tracks the current state, priority, routing attributes, processing attempts, and audit information. 
/// The workflow engine uses this ticket to determine which handler should process the interaction 
/// and to manage retries and failures.
/// </summary>
public record WorkflowTicket
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid InteractionId { get; init; }
    public string CurrentState { get; init; } = "Pending";
    public int Priority { get; init; } = 0;
    public string? RouteAttributesJson { get; init; }
    public string? NextProcessor { get; init; }
    public int Attempts { get; init; }
    public string? LockedBy { get; init; }
    public DateTime? LockedAt { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime? DueAt { get; init; }
    public DateTime? CompletedAt { get; init; }
    public string? ResultJson { get; init; }

    // audit
    public Guid? CreatedById { get; init; }
    public DateTime? ModifiedAt { get; init; }
}
