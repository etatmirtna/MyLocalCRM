using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementStatusType
    {
        [Display(Name = "Active")]
        [Description("Active service level agreement indicates that the agreement is currently in effect.")]
        Active,
        [Display(Name = "Expired")]
        [Description("Expired service level agreement indicates that the agreement is no longer in effect.")]
        Expired,
        [Display(Name = "Canceled")]
        [Description("Canceled service level agreement indicates that the agreement has been terminated before its expiration.")]
        Canceled,
        [Display(Name = "Unknown")]
        [Description("Unknown service level agreement indicates that the agreement is not specified or cannot be determined.")]
        Unknown
    }
