using CommonLibrary;
using System;

namespace DataService.Models;

public record Account
{
    public Guid AccountId { get; init; } = Guid.NewGuid();
    public Guid? ParentAccountId { get; init; }
    public string Name { get; init; } = string.Empty;
    public IndustryType Industry { get; init; }
    public string? Website { get; init; }
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
    public bool? ParticipatesInWorkflow { get; init; }
    public bool? IsRoutable { get; init; }
    public AccountType? AccountType { get; init; }
    public ServiceLevelAgreementType? ServiceLevelAgreement { get; init; }
}
