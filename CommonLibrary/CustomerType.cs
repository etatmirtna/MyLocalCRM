using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum CustomerType
    {
        [Display(Name = "Prospect")]
        [Description("Prospect type indicates that the customer is a potential or prospective customer who has shown interest in the organization's products or services but has not yet made a purchase or commitment. This customer may require further nurturing and engagement to move them through the sales funnel and convert them into a paying customer.")]
        Prospect,
        [Display(Name = "Current")]
        [Description("Current type indicates that the customer is an active customer who is currently engaged with the organization's products or services. This customer may have ongoing transactions, subscriptions, or interactions with the organization.")]
        Current,
        [Display(Name = "Former")]
        [Description("Former type indicates that the customer was previously engaged with the organization's products or services but is no longer an active customer. This customer may have discontinued their relationship with the organization for various reasons.")]
        Former,
        [Display(Name = "VIP")]
        [Description("VIP type indicates that the customer is a very important person or entity, often receiving special treatment, privileges, or attention due to their high value, influence, or strategic importance to the organization.")]
        VIP,
        [Display(Name = "High Value")]
        [Description("High Value type indicates that the customer is considered to have a high value to the organization, often based on their purchasing behavior, potential for growth, or strategic importance.")]
        HighValue,
        [Display(Name = "Low Value")]
        [Description("Low Value type indicates that the customer is considered to have a low value to the organization, often based on their purchasing behavior, potential for growth, or strategic importance.")]
        LowValue,
        [Display(Name = "New")]
        [Description("New type indicates that the customer is newly acquired or recently engaged with the organization's products or services. This customer may require onboarding, education, and initial support to ensure a positive experience and successful adoption.")]
        New,
        [Display(Name = "Returning")]
        [Description("Returning type indicates that the customer has previously engaged with the organization's products or services and has returned for additional interactions or purchases. This customer may require personalized engagement and retention strategies to maintain their loyalty and satisfaction.")]
        Returning,
        [Display(Name = "Loyal")]
        [Description("Loyal type indicates that the customer has demonstrated consistent engagement, satisfaction, and commitment to the organization's products or services. This customer may be highly valuable and influential, often serving as a brand advocate or reference.")]
        Loyal,
        [Display(Name = "At Risk")]
                [Description("At Risk type indicates that the customer is at risk of churning or discontinuing their relationship with the organization. This customer may require proactive engagement, support, and retention strategies to prevent churn.")]
        AtRisk,
        [Display(Name = "Churned")]
        [Description("Churned type indicates that the customer has discontinued their relationship with the organization. This customer may no longer engage with the organization's products or services and may require re-engagement strategies if the organization wishes to win them back.")]
        Churned,
        [Display(Name = "Other")]
        [Description("Other type indicates that the customer does not fit into any of the predefined categories. This customer may have unique characteristics or behaviors that require special consideration.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the customer's status or type is not known or has not been determined. This customer may require further investigation or data collection to accurately classify them.")]
        Unknown
    }
