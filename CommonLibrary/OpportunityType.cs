using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum OpportunityType
    {
        [Display(Name = "New Business")]
        [Description("New Business indicates that the opportunity is for a new customer or account that has not previously done business with the company. It represents a potential revenue stream from a new source and may require additional effort to establish the relationship and close the deal.")]
        NewBusiness,
        [Display(Name = "Existing Business")]
        [Description("Existing Business indicates that the opportunity is for an existing customer or account that has previously done business with the company. It represents a potential revenue stream from an established relationship and may require less effort to close the deal compared to new business opportunities.")]
        ExistingBusiness,
        [Display(Name = "Renewal")]
        [Description("Renewal indicates that the opportunity is for the renewal of an existing contract or subscription. It represents a potential revenue stream from an existing customer or account and may require effort to retain the customer and ensure continued business.")]
        Renewal,
        [Display(Name = "Upsell")]
        [Description("Upsell indicates that the opportunity is for the sale of additional products or services to an existing customer or account. It represents a potential revenue stream from an existing relationship and may require effort to identify and promote relevant offerings to the customer.")]
        Upsell,
        [Display(Name = "Cross Sell")]
        [Description("Cross Sell indicates that the opportunity is for the sale of complementary products or services to an existing customer or account. It represents a potential revenue stream from an existing relationship and may require effort to identify and promote relevant offerings to the customer.")]
        CrossSell,
        [Display(Name = "Other")]
        [Description("Other indicates that the opportunity does not fit into any of the predefined categories and may require further analysis to determine the appropriate classification. It represents a potential revenue stream that may require additional effort to understand and close the deal.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown indicates that the type of opportunity has not been determined or is not applicable. It may require further assessment or information to determine the appropriate classification for the opportunity.")]
        Unknown
    }
