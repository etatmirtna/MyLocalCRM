using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ContactType
    {
        [Display(Name = "Primary")]
        [Description("Primary type indicates that the contact is the main point of contact for the associated account or organization. This contact is typically responsible for managing the relationship with the account, handling communication, and serving as the primary liaison between the account and the organization.")]
        Primary,
        [Display(Name = "Secondary")]
        [Description("Secondary type indicates that the contact is an additional point of contact for the associated account or organization. This contact may provide support to the primary contact, handle specific communication or tasks related to the account, or serve as a backup contact in case the primary contact is unavailable.")]
        Secondary,
        [Display(Name = "Billing")]
        [Description("Billing type indicates that the contact is responsible for handling billing-related communication and tasks for the associated account or organization. This contact may be responsible for managing invoices, processing payments, addressing billing inquiries, and ensuring that billing-related matters are handled efficiently and accurately.")]
        Billing,
        [Display(Name = "Shipping")]
        [Description("Shipping type indicates that the contact is responsible for handling shipping-related communication and tasks for the associated account or organization. This contact may be responsible for managing shipping addresses, coordinating shipments, addressing shipping inquiries, and ensuring that shipping-related matters are handled efficiently and accurately.")]
        Shipping,
        [Display(Name = "Technical")]
        [Description("Technical type indicates that the contact is responsible for handling technical communication and tasks for the associated account or organization. This contact may be responsible for addressing technical inquiries, providing technical support, coordinating technical resources, and ensuring that technical-related matters are handled efficiently and effectively to support the needs of the account or organization.")]
        Technical,
        [Display(Name = "Legal")]
        [Description("Legal type indicates that the contact is responsible for handling legal communication and tasks for the associated account or organization. This contact may be responsible for addressing legal inquiries, providing legal support, coordinating legal resources, and ensuring that legal-related matters are handled efficiently and effectively to support the needs of the account or organization while ensuring compliance with applicable laws and regulations.")]
        Legal,
        [Display(Name = "Financial")]
        [Description("Financial type indicates that the contact is responsible for handling financial communication and tasks for the associated account or organization. This contact may be responsible for managing financial inquiries, providing financial support, coordinating financial resources, and ensuring that financial-related matters are handled efficiently and effectively to support the needs of the account or organization while ensuring sound financial management practices.")]
        Financial,
        [Display(Name = "Vendor")]
        [Description("Vendor type indicates that the contact is responsible for handling communication and tasks related to vendors for the associated account or organization. This contact may be responsible for managing vendor relationships, coordinating vendor communication, addressing vendor inquiries, and ensuring that vendor-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining positive relationships with vendors.")]
        Vendor,
        [Display(Name = "Supplier")]
        [Description("Supplier type indicates that the contact is responsible for handling communication and tasks related to suppliers for the associated account or organization. This contact may be responsible for managing supplier relationships, coordinating supplier communication, addressing supplier inquiries, and ensuring that supplier-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining positive relationships with suppliers.")]
        Supplier,
        [Display(Name = "Customer")]
        [Description("Customer type indicates that the contact is responsible for handling communication and tasks related to customers for the associated account or organization. This contact may be responsible for managing customer relationships, coordinating customer communication, addressing customer inquiries, and ensuring that customer-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining positive relationships with customers.")]
        Customer,
        [Display(Name = "Security")]
        [Description("Security type indicates that the contact is responsible for handling communication and tasks related to security for the associated account or organization. This contact may be responsible for managing security-related inquiries, providing security support, coordinating security resources, and ensuring that security-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a secure environment.")]
        Security,
        [Display(Name = "Health and Safety")]
        [Description("Health and Safety type indicates that the contact is responsible for handling communication and tasks related to health and safety for the associated account or organization. This contact may be responsible for managing health and safety-related inquiries, providing health and safety support, coordinating health and safety resources, and ensuring that health and safety-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a safe environment.")]
        HealthAndSafety,
        [Display(Name = "Cleaning")]
        [Description("Cleaning type indicates that the contact is responsible for handling communication and tasks related to cleaning for the associated account or organization. This contact may be responsible for managing cleaning-related inquiries, providing cleaning support, coordinating cleaning resources, and ensuring that cleaning-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a clean environment.")]
        Cleaning,

        [Display(Name = "Groundskeeping")]
        [Description("Groundskeeping type indicates that the contact is responsible for handling communication and tasks related to groundskeeping for the associated account or organization. This contact may be responsible for managing groundskeeping-related inquiries, providing groundskeeping support, coordinating groundskeeping resources, and ensuring that groundskeeping-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a well-kept environment.")]
        Groundskeeping,
        [Display(Name = "Transportation")]
        [Description("Transportation type indicates that the contact is responsible for handling communication and tasks related to transportation for the associated account or organization. This contact may be responsible for managing transportation-related inquiries, providing transportation support, coordinating transportation resources, and ensuring that transportation-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a reliable transportation system.")]
        Transportation,
        [Display(Name = "Maintenance")]
        [Description("Maintenance type indicates that the contact is responsible for handling communication and tasks related to maintenance for the associated account or organization. This contact may be responsible for managing maintenance-related inquiries, providing maintenance support, coordinating maintenance resources, and ensuring that maintenance-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a well-maintained environment.")]
        Maintenance,
        [Display(Name = "Food Service")]
        [Description("Food Service type indicates that the contact is responsible for handling communication and tasks related to food service for the associated account or organization. This contact may be responsible for managing food service-related inquiries, providing food service support, coordinating food service resources, and ensuring that food service-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a high-quality food service environment.")]
        FoodService,
        [Display(Name = "Marketing")]
        [Description("Marketing type indicates that the contact is responsible for handling communication and tasks related to marketing for the associated account or organization. This contact may be responsible for managing marketing-related inquiries, providing marketing support, coordinating marketing resources, and ensuring that marketing-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a strong market presence.")]
        Marketing,
        [Display(Name = "Event Planning")]
        [Description("Event Planning type indicates that the contact is responsible for handling communication and tasks related to event planning for the associated account or organization. This contact may be responsible for managing event planning-related inquiries, providing event planning support, coordinating event planning resources, and ensuring that event planning-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a successful event environment.")]
        EventPlanning,
        [Display(Name = "Emergency")]
        [Description("Emergency type indicates that the contact is responsible for handling communication and tasks related to emergency situations for the associated account or organization. This contact may be responsible for managing emergency-related inquiries, providing emergency support, coordinating emergency resources, and ensuring that emergency-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a safe environment.")]
        Emergency,
        [Display(Name = "Employment")]
        [Description("Employment type indicates that the contact is responsible for handling communication and tasks related to employment for the associated account or organization. This contact may be responsible for managing employment-related inquiries, providing employment support, coordinating employment resources, and ensuring that employment-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a productive work environment.")]
        Employment,
        [Display(Name = "Compliance")]
        [Description("Compliance type indicates that the contact is responsible for handling communication and tasks related to compliance for the associated account or organization. This contact may be responsible for managing compliance-related inquiries, providing compliance support, coordinating compliance resources, and ensuring that compliance-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining regulatory adherence.")]
        Compliance,
        [Display(Name = "Coaching")]
        [Description("Coaching type indicates that the contact is responsible for handling communication and tasks related to coaching for the associated account or organization. This contact may be responsible for managing coaching-related inquiries, providing coaching support, coordinating coaching resources, and ensuring that coaching-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a productive coaching environment.")]
        Coaching,
        [Display(Name = "Business Development")]
        [Description("Business Development type indicates that the contact is responsible for handling communication and tasks related to business development for the associated account or organization. This contact may be responsible for managing business development-related inquiries, providing business development support, coordinating business development resources, and ensuring that business development-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a successful business development environment.")]
        BusinessDevelopment,
        [Display(Name = "Consulting")]
        [Description("Consulting type indicates that the contact is responsible for handling communication and tasks related to consulting for the associated account or organization. This contact may be responsible for managing consulting-related inquiries, providing consulting support, coordinating consulting resources, and ensuring that consulting-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a productive consulting environment.")]
        Consulting,
        [Display(Name = "Facilities Management")]
        [Description("Facilities Management type indicates that the contact is responsible for handling communication and tasks related to facilities management for the associated account or organization. This contact may be responsible for managing facilities management-related inquiries, providing facilities management support, coordinating facilities management resources, and ensuring that facilities management-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a safe and functional environment.")]
        FacilitiesManagement,
        [Display(Name = "IT Support")]
        [Description("IT Support type indicates that the contact is responsible for handling communication and tasks related to IT support for the associated account or organization. This contact may be responsible for managing IT support-related inquiries, providing IT support, coordinating IT resources, and ensuring that IT support-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a functional IT environment.")]
        ITSupport,
        [Display(Name = "Inventory Management")]
        [Description("Inventory Management type indicates that the contact is responsible for handling communication and tasks related to inventory management for the associated account or organization. This contact may be responsible for managing inventory-related inquiries, providing inventory support, coordinating inventory resources, and ensuring that inventory-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining an organized inventory environment.")]
        InventoryManagement,
        [Display(Name = "Environmental")]
        [Description("Environmental type indicates that the contact is responsible for handling communication and tasks related to environmental matters for the associated account or organization. This contact may be responsible for managing environmental-related inquiries, providing environmental support, coordinating environmental resources, and ensuring that environmental-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a sustainable and compliant environment.")]
        Environmental,
        [Display(Name = "Education and Training")]
        [Description("Education and Training type indicates that the contact is responsible for handling communication and tasks related to education and training for the associated account or organization. This contact may be responsible for managing education and training-related inquiries, providing education and training support, coordinating education and training resources, and ensuring that education and training-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a knowledgeable and skilled workforce.")]
        EducationAndTraining,
        [Display(Name = "Human Resources")]
        [Description("Human Resources type indicates that the contact is responsible for handling communication and tasks related to human resources for the associated account or organization. This contact may be responsible for managing human resources-related inquiries, providing human resources support, coordinating human resources resources, and ensuring that human resources-related matters are handled efficiently and effectively to support the needs of the account or organization while maintaining a productive and compliant workforce.")]
        HumanResources,
        [Display(Name = "Other")]
        [Description("Other type indicates that the contact does not fit into any of the predefined categories and may be responsible for handling communication and tasks that are specific to their role or relationship with the associated account or organization. This contact may have unique responsibilities or areas of expertise that do not align with the other defined contact types, and their role may vary based on the specific needs and dynamics of the account or organization.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the contact's role or relationship with the associated account or organization is not known or has not been specified. This contact may require further clarification or information to determine their specific responsibilities and how they fit into the overall communication and relationship management strategy for the account or organization.")]
        Unknown
    }
}