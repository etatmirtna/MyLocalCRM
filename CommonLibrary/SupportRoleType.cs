using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum SupportRoleType
    {
        [Display(Name = "Support Engineer")]
        [Description("Support Engineer role means that the person is responsible for providing technical support and assistance to customers.")]
        SupportEngineer,
        [Display(Name = "Support Manager")]
        [Description("Support Manager role means that the person is responsible for overseeing the support team and ensuring customer issues are resolved efficiently.")]
        SupportManager,
        [Display(Name = "Customer Service Representative")]
        [Description("Customer Service Representative role means that the person is responsible for assisting customers with their inquiries and issues.")]
        CustomerServiceRep,
        [Display(Name = "Other")]
        [Description("Other role means that the role does not fall into any of the predefined categories and provides an alternative explanation.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown role means that the role is not specified or cannot be determined.")]
        Unknown
    }
}