using System;
using CommonLibrary;

namespace DataService.Models;

public record Calendar
{
    public Guid CalendarId { get; init; } = Guid.NewGuid();
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

public record CalendarEvent
{
    public Guid CalendarEventId { get; init; } = Guid.NewGuid();
    public Guid CalendarId { get; init; }
    public string Subject { get; init; } = string.Empty;
    public string? Description { get; init; }
    public DateTime StartTime { get; init; }
    public DateTime EndTime { get; init; }
    public bool IsAllDay { get; init; }
    public string? Location { get; init; }
    public Guid? OrganizerUserId { get; init; }
    public Guid? ActionId { get; init; }
    public Guid? CreatedById { get; init; }
    public Guid? ModifiedById { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime? ModifiedAt { get; init; }
    public Guid? DeletedById { get; init; }
    public DateTime? DeletedAt { get; init; }
    public Guid? CreatedOnBehalfById { get; init; }
    public Guid? ModifiedOnBehalfById { get; init; }
    public Guid? OwnedById { get; init; } 
    public Guid? OwningBusinessUnitId { get; init; }
    public CalendarEventType { get; init; }
}