using System;

namespace DataService.Models;

public record ChatMessage
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid? FromUserId { get; init; }
    public Guid? ToUserId { get; init; }
    public string Message { get; init; } = string.Empty;
    public DateTime SentAt { get; init; } = DateTime.UtcNow;
    public Guid? AccountId { get; init; }
    public Guid? CustomerId { get; init; }
    public Guid? LeadId { get; init; }

    public Guid? ActionId { get; init; }
    public Guid? CreatedById { get; init; }
    public Guid? ModifiedById { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime? ModifiedAt { get; init; }
    public Guid? DeletedById { get; init; }
    public DateTime? DeletedAt { get; init; }
    public Guid? CreatedOnBehalfById { get; init; }
    public Guid? ModifiedOnBehalfById { get; init; }
}
