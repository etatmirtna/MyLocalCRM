using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum MarketingRoleType
    {
        [Display(Name = "Marketing Manager")]
        [Description("Marketing Manager role means that the person is responsible for overseeing marketing strategies and campaigns.")]
        MarketingManager,
        [Display(Name = "Marketing Specialist")]
        [Description("Marketing Specialist role means that the person is responsible for executing marketing strategies and campaigns.")]
        MarketingSpecialist,
        [Display(Name = "Other")]
        [Description("Other role means that the role does not fall into any of the predefined categories and provides an alternative explanation.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown role means that the role is not specified or cannot be determined.")]
        Unknown
    }
