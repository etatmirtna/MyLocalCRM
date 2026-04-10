using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementSatisfactionRatingFollowUpActionType
    {
        [Display(Name = "Contact Customer")]
        [Description("Contact Customer action indicates that the follow-up action involves reaching out to the customer.")]
        ContactCustomer,
        [Display(Name = "Offer Refund")]
        [Description("Offer Refund action indicates that the follow-up action involves providing a refund to the customer.")]
        OfferRefund,
        [Display(Name = "Provide Discount")]
        [Description("Provide Discount action indicates that the follow-up action involves offering a discount to the customer.")]
        ProvideDiscount,
        [Display(Name = "Escalate To Management")]
        [Description("Escalate To Management action indicates that the follow-up action involves escalating the issue to management.")]
        EscalateToManagement,
        [Display(Name = "Other")]
        [Description("Other action indicates that the follow-up action involves an unspecified or custom action.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown action indicates that the follow-up action is not specified or cannot be determined.")]
        Unknown
    }
}