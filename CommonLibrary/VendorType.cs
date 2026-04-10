using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum VendorType
    {
        [Display(Name = "Preferred")]
        [Description("Preferred type indicates that the vendor is a preferred supplier or partner for the organization. This vendor may have a strong track record of delivering high-quality products or services, competitive pricing, and excellent customer service. Preferred vendors may receive priority consideration for procurement opportunities and may have a closer relationship with the organization.")]
        Preferred,
        [Display(Name = "Standard")]
        [Description("Standard type indicates that the vendor is a regular supplier or partner for the organization. This vendor may provide products or services that meet the organization's requirements and standards, but may not have the same level of preference or priority as preferred vendors. Standard vendors may still be considered for procurement opportunities based on their capabilities and offerings.")]
        Standard,
        [Display(Name = "Approved")]
        [Description("Approved type indicates that the vendor has been approved for procurement by the organization. This vendor may have undergone a vetting process, met certain criteria, and received approval to provide products or services to the organization. Approved vendors may be eligible for procurement opportunities based on their qualifications and compliance with organizational policies.")]
        Approved,
        [Display(Name = "Unapproved")]
        [Description("Unapproved type indicates that the vendor has not been approved for procurement by the organization. This vendor may not have undergone a vetting process, may not meet certain criteria, or may not have received approval to provide products or services to the organization. Unapproved vendors may not be eligible for procurement opportunities and may require further evaluation or approval before being considered for procurement.")]
        Unapproved,
        [Display(Name = "Local")]
        [Description("Local type indicates that the vendor is located in the same geographic area or region as the organization. This vendor may have a closer proximity to the organization, which can facilitate communication, logistics, and support. Local vendors may be preferred for certain procurement opportunities based on their accessibility and ability to provide timely service.")]
        Local,
        [Display(Name = "International")]
        [Description("International type indicates that the vendor is located in a different geographic area or region than the organization. This vendor may have a global presence, which can provide access to a wider range of products or services, but may also involve additional considerations such as shipping, customs, and communication challenges. International vendors may be considered for procurement opportunities based on their capabilities and offerings, but may require additional evaluation and coordination.")]
        International,
        [Display(Name = "Small Business")]
        [Description("Small Business type indicates that the vendor is classified as a small business according to relevant criteria, such as revenue, number of employees, or industry classification. This vendor may be eligible for certain procurement opportunities or incentives aimed at supporting small businesses, and may have unique capabilities or offerings that can benefit the organization.")]
        SmallBusiness,
        [Display(Name = "Large Business")]
        [Description("Large Business type indicates that the vendor is classified as a large business according to relevant criteria, such as revenue, number of employees, or industry classification. This vendor may have extensive resources, capabilities, and offerings that can benefit the organization, but may also involve additional considerations such as pricing, contract terms, and relationship management. Large businesses may be considered for procurement opportunities based on their qualifications and fit with the organization's needs.")]
        LargeBusiness,
        [Display(Name = "Government")]
        [Description("Government type indicates that the vendor is a government entity or agency. This vendor may provide products or services to the organization based on government contracts, grants, or other arrangements. Government vendors may have specific requirements, regulations, and processes that need to be followed for procurement, and may require additional coordination and compliance efforts.")]
        Government,
        [Display(Name = "Non Profit")]
        [Description("Non Profit type indicates that the vendor is a non-profit organization. This vendor may provide products or services to the organization based on their mission, values, and social impact. Non-profit vendors may have unique capabilities or offerings that align with the organization's goals and values, and may be considered for procurement opportunities based on their qualifications and fit with the organization's needs.")]
        NonProfit,
        [Display(Name = "Other")]
        [Description("Other type indicates that the vendor does not fit into any of the predefined categories and may be related to a variety of topics or circumstances. It may require further assessment or information to determine the appropriate handling and response for the vendor.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the vendor's classification or category is not known or has not been specified. This vendor may require further clarification or information to determine their specific classification and how they fit into the overall procurement strategy and vendor management processes of the organization.")]
        Unknown
    }
}