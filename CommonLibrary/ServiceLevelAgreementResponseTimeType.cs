using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementResponseTimeType
    {
        [Display(Name = "1 Hour")]
        [Description("1 Hour response time indicates that the service provider will respond to the customer's request within one hour.")]
        OneHour,
        [Display(Name = "4 Hours")]
        [Description("4 Hours response time indicates that the service provider will respond to the customer's request within four hours.")]
        FourHours,
        [Display(Name = "8 Hours")]
        [Description("8 Hours response time indicates that the service provider will respond to the customer's request within eight hours.")]
        EightHours,
        [Display(Name = "24 Hours")]
        [Description("24 Hours response time indicates that the service provider will respond to the customer's request within twenty-four hours.")]
        TwentyFourHours,
        [Display(Name = "48 Hours")]
        [Description("48 Hours response time indicates that the service provider will respond to the customer's request within forty-eight hours.")]
        FortyEightHours,
        [Display(Name = "72 Hours")]
        [Description("72 Hours response time indicates that the service provider will respond to the customer's request within seventy-two hours.")]
        SeventyTwoHours,
        [Display(Name = "Other")]
        [Description("Other response time indicates that the response time is not specified or does not fall within the predefined categories.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown response time indicates that the response time is not specified or cannot be determined.")]
        Unknown
    }
}