using System;

namespace DataService.Models;

public record PhoneCall
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid? FromUserId { get; init; }
    public Guid? ToUserId { get; init; }
    public Guid? CustomerId { get; init; }
    public Guid? AccountId { get; init; }
    public DateTime OccurredAt { get; init; } = DateTime.UtcNow;
    public string? Notes { get; init; }
    public string? Subject { get; init; }
    public int? DurationSeconds { get; init; }
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
    public string PhoneCallNumber { get; init; } = string.Empty;
    public string? PhoneCallTypeCode { get; init; }  //
    public int CallDirectionTypeCode { get; init; }// TODO: 0 for incoming, 1 for outgoing make this an enum

    public string CleanPhoneNumber(string phoneNumber)
    {
        // Simple formatting: remove non-digit characters
        var digits = new string(phoneNumber.Where(char.IsDigit).ToArray());
        if (digits.Length == 10)
        {
            return $"({digits.Substring(0, 3)}) {digits.Substring(3, 3)}-{digits.Substring(6)}";
        }
        return phoneNumber; // Return as is if not 10 digits
    }

    
}
