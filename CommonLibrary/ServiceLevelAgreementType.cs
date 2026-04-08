using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementType
    {
        [Display(Name = "Standard")]
        [Description("Standard service level agreement indicates the basic level of service provided.")]
        Standard,
        [Display(Name = "Premium")]
        [Description("Premium service level agreement indicates a higher level of service provided.")]
        Premium,
        [Display(Name = "Enterprise")]
        [Description("Enterprise service level agreement indicates the highest level of service provided.")]
        Enterprise,
        [Display(Name = "Other")]
        [Description("Other service level agreement indicates a service level that does not fall within the predefined categories.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown service level agreement indicates that the service level is not specified or cannot be determined.")]
        Unknown
    }
