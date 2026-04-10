using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum AddressType
    {
        [Display(Name = "Billing")]
        [Description("Billing type indicates that the address is used for billing purposes, such as invoicing, payment processing, or other financial-related activities. This address may be associated with the billing contact and is typically used for communication and transactions related to billing and financial matters.")]
        Billing,
        [Display(Name = "Shipping")]
        [Description("Shipping type indicates that the address is used for shipping purposes, such as delivering products or services to the associated account or organization. This address may be associated with the shipping contact and is typically used for communication and transactions related to shipping and logistics.")]
        Shipping,
        [Display(Name = "Primary")]
        [Description("Primary type indicates that the address is the main or primary address for the associated account or organization. This address is typically used for general communication and correspondence.")]
        Primary,
        [Display(Name = "Secondary")]
        [Description("Secondary type indicates that the address is an additional or secondary address for the associated account or organization. This address may be used for specific purposes or as an alternative to the primary address.")]
        Secondary,
        [Display(Name = "Other")]
        [Description("Other type indicates that the address does not fall into any of the predefined categories and may be used for miscellaneous or unspecified purposes.")]
        Other,
        [Display(Name = "Headquarters")]
        [Description("Headquarters type indicates that the address is the main office or central location of the associated account or organization. This address is typically used for official communication and administrative purposes.")]
        Headquarters,
        [Display(Name = "Branch")]
        [Description("Branch type indicates that the address is a branch office or secondary location of the associated account or organization. This address is typically used for local communication and operational purposes.")]
        Branch,
        [Display(Name = "Warehouse")]
        [Description("Warehouse type indicates that the address is used for storing goods, materials, or inventory for the associated account or organization. This address is typically used for logistics, distribution, and inventory management purposes.")]
        Warehouse,
        [Display(Name = "Office")]
        [Description("Office type indicates that the address is used for office purposes, such as administrative or operational activities. This address may be associated with the office contact and is typically used for communication and coordination within the organization.")]
        Office,
        [Display(Name = "Factory")]
        [Description("Factory type indicates that the address is used for manufacturing or production purposes. This address may be associated with the factory contact and is typically used for communication and coordination related to production activities.")]
        Factory,
        [Display(Name = "Store")]
        [Description("Store type indicates that the address is used for retail or commercial purposes. This address may be associated with the store contact and is typically used for communication and transactions related to sales and customer service.")]
        Store,
        [Display(Name = "Residence")]
        [Description("Residence type indicates that the address is used for residential purposes. This address may be associated with the resident contact and is typically used for personal communication and correspondence.")]
        Residence,
        [Display(Name = "Mailing")]
        [Description("Mailing type indicates that the address is used for mailing purposes, such as receiving correspondence, invoices, or other communications. This address may be associated with the mailing contact and is typically used for communication and correspondence purposes.")]
        Mailing,
        [Display(Name = "Physical")]
        [Description("Physical type indicates that the address is used for physical location purposes, such as visiting or delivering goods. This address may be associated with the physical contact and is typically used for logistical and operational purposes.")]
        Physical,
        [Display(Name = "Legal")]
        [Description("Legal type indicates that the address is used for legal purposes, such as official registration or legal correspondence. This address may be associated with the legal contact and is typically used for legal and regulatory matters.")]
        Legal,
        [Display(Name = "Registered")]
        [Description("Registered type indicates that the address is officially registered with the relevant authorities. This address may be associated with the registered contact and is typically used for legal and regulatory purposes.")]
        Registered,
        [Display(Name = "Main")]
        [Description("Main type indicates that the address is the primary location or main office of the associated account or organization. This address is typically used for official communication and administrative purposes.")]
        Main,
        [Display(Name = "Sub")]
        [Description("Sub type indicates that the address is a secondary or subsidiary location of the associated account or organization. This address is typically used for additional communication and operational purposes.")]
        Sub,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the address type is not specified or recognized. This address may be associated with an unknown contact and is typically used when the address type cannot be determined.")]
        Unknown
    }
}
