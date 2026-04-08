using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementTypeOfServiceType
    {
        [Display(Name = "Support")]
        [Description("Support service level agreement indicates that the agreement is related to support services.")]
        Support,
        [Display(Name = "Maintenance")]
        [Description("Maintenance service level agreement indicates that the agreement is related to maintenance services.")]
        Maintenance,
        [Display(Name = "Consulting")]
        [Description("Consulting service level agreement indicates that the agreement is related to consulting services.")]
        Consulting,
        [Display(Name = "Other")]
        [Description("Other service level agreement indicates that the agreement is related to services that do not fall within the predefined categories.")]
        Other,
        [Display(Name = "Unknown")] 
        [Description("Unknown service level agreement indicates that the agreement is not specified or cannot be determined.")]
        Unknown
    }
