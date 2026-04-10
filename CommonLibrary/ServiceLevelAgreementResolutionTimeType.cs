using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementResolutionTimeType
    {
        [Display(Name = "4 Hours")]
        [Description("4 Hours resolution time indicates that the service provider will resolve the customer's request within four hours.")]
        FourHours,
        [Display(Name = "8 Hours")]
        [Description("8 Hours resolution time indicates that the service provider will resolve the customer's request within eight hours.")]
        EightHours,
        [Display(Name = "24 Hours")]
        [Description("24 Hours resolution time indicates that the service provider will resolve the customer's request within twenty-four hours.")]
        TwentyFourHours,
        [Display(Name = "48 Hours")]
        [Description("48 Hours resolution time indicates that the service provider will resolve the customer's request within forty-eight hours.")]
        FortyEightHours,
        [Display(Name = "72 Hours")]
        [Description("72 Hours resolution time indicates that the service provider will resolve the customer's request within seventy-two hours.")]
        SeventyTwoHours,
        [Display(Name = "Other")]
        [Description("Other resolution time indicates that the resolution time is not specified or does not fall within the predefined categories.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown resolution time indicates that the resolution time is not specified or cannot be determined.")]
        Unknown
    }
}