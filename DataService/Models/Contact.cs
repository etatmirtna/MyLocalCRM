using System;

namespace DataService.Models;

public record Contact
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? ContactType { get; init; }
    public string? Email { get; init; }
    public string? Phone { get; init; }

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
