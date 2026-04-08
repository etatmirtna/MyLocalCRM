using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum AccountType
    {
        [Display(Name = "Customer")]
        [Description("Customer account type.")]
        Customer,
        [Display(Name = "Vendor")]
        [Description("Vendor account type.")]
        Vendor,
        [Display(Name = "Partner")]
        [Description("Partner account type.")]
        Partner,
        [Display(Name = "Competitor")]
        [Description("Competitor account type.")]
        Competitor,
        [Display(Name = "Other")]
        [Description("Other account type.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown account type.")]
        Unknown
    }
