using System;

namespace DataService.Models;

public record Calendar
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public string? TimeZone { get; init; }
    public Guid? OwnerUserId { get; init; }

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
