using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum OtherRoleType
    {
        [Display(Name = "Consultant")]
        [Description("Consultant role means that the person provides expert advice in a particular area.")]
        Consultant,
        [Display(Name = "Contractor")]
        [Description("Contractor role means that the person is hired to perform specific tasks or projects for a limited period.")]
        Contractor,
        [Display(Name = "Vendor")]
        [Description("Vendor role means that the person or organization provides products or services to the company.")]
        Vendor,
        [Display(Name = "Partner")]
        [Description("Partner role means that the person or organization collaborates with the company to achieve mutual goals.")]
        Partner,
        [Display(Name = "Other")]
        [Description("Other role means that the role does not fall into any of the predefined categories and provides an alternative explanation.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown role means that the role is not specified or cannot be determined.")]
        Unknown
    }
}