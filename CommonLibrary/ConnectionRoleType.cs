using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ConnectionRoleType
    {
        [Display(Name = "Colleague")]
        [Description("Indicates a professional relationship, such as a coworker or business associate.")]
        [Category("Professional")]
        Colleague,
        [Display(Name = "Friend")]
        [Description("Indicates a personal relationship, such as a friend or acquaintance.")]
        [Category("Personal")]
        Friend,
        [Display(Name = "Family")]
        [Description("Indicates a familial relationship, such as a family member or relative.")]
        [Category("Personal")]
        Family,
        [Display(Name = "Business Partner")]
        [Description("Indicates a business relationship, such as a client, vendor, or partner.")]
        [Category("Professional")]
        BusinessPartner,
        [Display(Name = "Other")]
        [Description("Indicates a relationship that does not fit into the other categories.")]
        [Category("Other")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Indicates an unknown or unspecified relationship.")]
        [Category("Other")]
        Unknown
    }
