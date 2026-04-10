using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum SalesRoleType
    {
        [Display(Name = "Account Manager")]
        [Description("Account Manager role means that the person is responsible for managing client accounts and maintaining relationships.")]
        AccountManager,
        [Display(Name = "Sales Executive")]
        [Description("Sales Executive role means that the person is responsible for driving sales and achieving revenue targets.")]
        SalesExecutive,
        [Display(Name = "Sales Manager")]
        [Description("Sales Manager role means that the person is responsible for overseeing the sales team and ensuring sales targets are met.")]
        SalesManager,
        [Display(Name = "Sales Representative")]
        [Description("Sales Representative role means that the person is responsible for selling products or services to customers and achieving sales targets.")]
        SalesRepresentative,
        [Display(Name = "Other")]
        [Description("Other role means that the role does not fall into any of the predefined categories and provides an alternative explanation.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown role means that the role is not specified or cannot be determined.")]
        Unknown
    }
}