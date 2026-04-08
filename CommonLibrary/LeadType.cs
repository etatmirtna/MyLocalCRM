using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum LeadType
    {
        [Display(Name = "New")]
        [Description("New type indicates that the lead is a new prospect or potential customer who has shown interest in the organization's products or services. This lead may require further qualification and nurturing to determine their potential as a customer and to move them through the sales funnel.")]
        New,
        [Display(Name = "Contacted")]
        [Description("Contacted type indicates that the lead has been contacted by the sales team or other representatives of the organization. This lead may have engaged in communication, such as responding to outreach efforts, expressing interest, or requesting more information about the organization's products or services.")]
        Contacted,
        [Display(Name = "Qualified")]
        [Description("Qualified type indicates that the lead has been evaluated and meets certain criteria that suggest they have a higher likelihood of becoming a customer. This lead may have demonstrated a strong interest in the organization's products or services, has a need that the organization can address, and has the potential to move further along the sales funnel.")]
        Qualified,
        [Display(Name = "Unqualified")]
        [Description("Unqualified type indicates that the lead has been evaluated and does not meet the criteria for being considered a qualified lead. This lead may have shown limited interest, may not have a need that the organization can address, or may not have the potential to become a customer. Unqualified leads may require further nurturing or may be disqualified from the sales process.")]
        Unqualified,
        [Display(Name = "Converted")]
        [Description("Converted type indicates that the lead has successfully converted into a customer. This lead has gone through the sales process, has made a purchase or commitment to the organization's products or services, and is now considered a customer. Converted leads may require ongoing relationship management and support to ensure customer satisfaction and retention.")]
        Converted,
        [Display(Name = "Recycled")]
        [Description("Recycled type indicates that the lead has been recycled back into the sales process after being previously disqualified or marked as unqualified. This lead may have shown renewed interest, may have a change in circumstances, or may have been re-evaluated and deemed to have potential as a customer. Recycled leads may require further qualification and nurturing to determine their potential and to move them through the sales funnel.")]
        Recycled,
        [Display(Name = "Other")]
        [Description("Other type indicates that the lead does not fit into any of the predefined categories and may be related to a variety of topics or circumstances. It may require further assessment or information to determine the appropriate handling and response for the lead.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the lead's status or category is not known or has not been specified. This lead may require further clarification or information to determine their specific status and how they fit into the overall sales process and strategy.")]
        Unknown
    }
