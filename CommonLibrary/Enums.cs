using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace CommonLibrary
{
    public enum IncidentType
    {
        [Display(Name = "Information")]
        [Description("Information type indicates that the incident is related to general information, updates, or inquiries. It may involve sharing information about products, services, policies, or other relevant topics to provide clarity and support to customers or stakeholders.")]
        Info,
        [Display(Name = "Problem")]
        [Description("Problem type indicates that the incident is related to a specific issue, challenge, or problem that needs to be addressed. It may involve troubleshooting, problem-solving, or providing solutions to resolve the issue and ensure customer satisfaction.")]
        Problem,
        [Display(Name = "Question")]
        [Description("Question type indicates that the incident is related to a specific question or inquiry from a customer or stakeholder. It may involve providing answers, clarifications, or guidance to address the question and support the needs of the customer or stakeholder.")]
        Question,
        [Display(Name = "Feature Request")]
        [Description("Feature Request type indicates that the incident is related to a request for a new feature, enhancement, or improvement to a product or service. It may involve gathering feedback, evaluating the feasibility of the request, and providing updates on the status of the request to ensure customer satisfaction and continuous improvement of products or services.")]
        FeatureRequest,
        [Display(Name = "Complaint")]
        [Description("Complaint type indicates that the incident is related to a specific complaint or dissatisfaction expressed by a customer or stakeholder. It may involve addressing the complaint, providing solutions, and ensuring that the customer's concerns are heard and resolved to maintain customer satisfaction and loyalty.")]
        Complaint,
        [Display(Name = "Other")]
        [Description("Other type indicates that the incident does not fit into any of the predefined categories and may be related to a variety of topics or issues. It may require further assessment or information to determine the appropriate handling and response for the incident.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the incident's nature or category is not known or has not been specified. It may require further clarification or information to determine the appropriate handling and response for the incident.")]
        Unknown
    }

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

    public enum PhoneNumberType
    {
        [Display(Name = "Mobile")]
        Mobile,
        [Display(Name = "Work")]
        Work,
        [Display(Name = "Home")]
        Home,
        [Display(Name = "Fax")]
        Fax,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }


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

    public enum CustomerType
    {
        [Display(Name = "Prospect")]
        Prospect,
        [Display(Name = "Current")]
        Current,
        [Display(Name = "Former")]
        Former,
        [Display(Name = "VIP")]
        VIP,
        [Display(Name = "High Value")]
        HighValue,
        [Display(Name = "Low Value")]
        LowValue,
        [Display(Name = "New")]
        New,
        [Display(Name = "Returning")]
        Returning,
        [Display(Name = "Loyal")]
        Loyal,
        [Display(Name = "At Risk")]
        AtRisk,
        [Display(Name = "Churned")]
        Churned,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum UserType
    {
        [Display(Name = "Administrator")]
        Admin,
        [Display(Name = "Standard User")]
        Standard,
        [Display(Name = "Guest")]
        Guest,
        [Display(Name = "External")]
        External,
        [Display(Name = "Internal")]
        Internal,
        [Display(Name = "Power User")]
        PowerUser,
        [Display(Name = "Read Only")]
        ReadOnly,
        [Display(Name = "System")]
        System,
        [Display(Name = "Service Account")]
        ServiceAccount,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum TeamType
    {
        [Display(Name = "Sales")]
        [Description("Sales team type indicates that the team is responsible for sales-related activities, such as prospecting, lead generation, customer acquisition, and revenue generation. This team may be focused on driving sales growth, managing customer relationships, and achieving sales targets to contribute to the overall success of the organization.")]  
        Sales,
        [Display(Name = "Support")]
        [Description("Support team type indicates that the team is responsible for providing customer support and assistance, such as addressing customer inquiries, resolving issues, and ensuring customer satisfaction. This team may be focused on maintaining positive relationships with customers, providing timely and effective support, and contributing to the overall success of the organization by ensuring customer loyalty and retention.")]
        Support,
        [Display(Name = "Marketing")]
        [Description("Marketing team type indicates that the team is responsible for marketing-related activities, such as market research, advertising, branding, and promotional campaigns. This team may be focused on creating awareness and interest in the organization's products or services, generating leads, and supporting sales efforts to drive business growth and success.")]
        Marketing,
        [Display(Name = "Development")]
        [Description("Development team type indicates that the team is responsible for software development and related activities, such as coding, testing, and deployment of software applications. This team may be focused on creating and maintaining software solutions that meet the needs of the organization and its customers, contributing to the overall success of the organization by delivering high-quality software products and services.")]
        Development,
        [Display(Name = "Human Resources")]
        [Description("Human Resources team type indicates that the team is responsible for managing human resources-related activities, such as recruitment, employee relations, performance management, and training and development. This team may be focused on attracting and retaining top talent, fostering a positive work environment, and supporting the overall success of the organization by ensuring effective management of its human capital.")]
        HR,
        [Display(Name = "Finance")]
        [Description("Finance team type indicates that the team is responsible for managing financial-related activities, such as budgeting, accounting, financial reporting, and financial analysis. This team may be focused on ensuring sound financial management practices, supporting strategic decision-making with financial insights, and contributing to the overall success of the organization by maintaining financial stability and growth.")]
        Finance,
        [Display(Name = "Operations")]
        [Description("Operations team type indicates that the team is responsible for managing operational-related activities, such as supply chain management, logistics, production, and quality control. This team may be focused on ensuring efficient and effective operations, optimizing processes, and contributing to the overall success of the organization by delivering high-quality products or services to customers in a timely manner.")]
        Operations,
        [Display(Name = "Executive")]
        [Description("Executive team type indicates that the team is responsible for providing strategic leadership and direction to the organization, making high-level decisions, and overseeing overall organizational performance. This team may be focused on setting organizational goals, developing and implementing strategies, and contributing to the overall success of the organization by ensuring effective leadership and governance.")]
        Executive,
        [Display(Name = "Management")]
        [Description("Management team type indicates that the team is responsible for managing and overseeing specific functions, departments, or projects within the organization. This team may be focused on coordinating resources, managing teams, and ensuring successful execution of initiatives to contribute to the overall success of the organization by achieving operational excellence and delivering results.")]
        Management,
        [Display(Name = "Customer Service")]
        [Description("Customer Service team type indicates that the team is responsible for providing customer service and support, such as addressing customer inquiries, resolving issues, and ensuring customer satisfaction. This team may be focused on maintaining positive relationships with customers, providing timely and effective support, and contributing to the overall success of the organization by ensuring customer loyalty and retention.")]
        CustomerService,
        [Display(Name = "Research and Development")]
        [Description("Research and Development team type indicates that the team is responsible for conducting research and development activities, such as exploring new technologies, developing innovative products or services, and driving continuous improvement. This team may be focused on fostering a culture of innovation, staying ahead of industry trends, and contributing to the overall success of the organization by delivering cutting-edge solutions that meet the evolving needs of customers and the market.")]
        RnD,
        [Display(Name = "Legal")]
        [Description("Legal team type indicates that the team is responsible for managing legal-related activities, such as contract management, compliance, risk management, and legal counsel. This team may be focused on ensuring compliance with applicable laws and regulations, mitigating legal risks, and contributing to the overall success of the organization by providing sound legal advice and support to protect the organization's interests and reputation.")]
        Legal,
        [Display(Name = "IT")]
        [Description("IT team type indicates that the team is responsible for managing information technology-related activities, such as IT infrastructure, software development, cybersecurity, and technical support. This team may be focused on ensuring the availability, reliability, and security of IT systems and services, supporting business operations with technology solutions, and contributing to the overall success of the organization by enabling digital transformation and innovation through effective use of technology.")]
        IT,
        [Display(Name = "Administration")]
        [Description("Administration team type indicates that the team is responsible for managing administrative-related activities, such as office management, facilities management, and general administrative support. This team may be focused on ensuring smooth and efficient administrative operations, providing support to other teams and departments, and contributing to the overall success of the organization by maintaining a well-organized and productive work environment.")]
        Administration,
        [Display(Name = "Other")]
        [Description("Other team type indicates that the team does not fit into any of the predefined categories and may be responsible for managing activities that are specific to their role or function within the organization. This team may have unique responsibilities or areas of expertise that do not align with the other defined team types, and their role may vary based on the specific needs and dynamics of the organization.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown team type indicates that the team's role or function within the organization is not known or has not been specified. This team may require further clarification or information to determine their specific responsibilities and how they fit into the overall organizational structure and strategy.")]
        Unknown
    }


    public enum AppointmentType
    {
        [Display(Name = "Scheduled")]
        Scheduled,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Unscheduled")]
        Unscheduled,
        [Display(Name = "Rescheduled")]
        Rescheduled,
        [Display(Name = "Recurring")]
        Recurring
    }

    public enum MeetingType
    {
        [Display(Name = "General Meeting")]
        [Description("General Meeting type indicates that the meeting is intended for general discussion, collaboration, or information sharing among participants. It may cover a wide range of topics and may not have a specific focus or agenda, allowing for open communication and exchange of ideas among attendees.")]
        Meeting,
        [Display(Name = "Phone Call")]
        [Description("Phone Call type indicates that the meeting is conducted over the phone, allowing participants to communicate and collaborate remotely. It may be used for various purposes, such as discussing project updates, addressing customer inquiries, or conducting sales calls, providing a convenient and efficient way for participants to connect and engage in meaningful discussions without the need for physical presence.")]
        Call,
        [Display(Name = "Email")]
        [Description("Email type indicates that the meeting is conducted through email communication, allowing participants to exchange information, updates, or discussions asynchronously. It may be used for various purposes, such as sharing project updates, addressing customer inquiries, or conducting sales communication, providing a flexible and efficient way for participants to communicate and collaborate without the need for real-time interaction.")]
        Email,
        [Display(Name = "Sales Meeting")]
        [Description("Sales Meeting type indicates that the meeting is focused on sales-related activities, such as discussing sales strategies, reviewing sales performance, or addressing sales opportunities. It may involve sales teams, managers, or other stakeholders involved in the sales process, providing a platform for collaboration and alignment on sales goals and initiatives to drive revenue growth.")]
        Sales,
        [Display(Name = "Support Meeting")]
        [Description("Support Meeting type indicates that the meeting is focused on customer support-related activities, such as addressing customer inquiries, resolving issues, or providing assistance. It may involve support teams, managers, or other stakeholders involved in customer support, providing a platform for collaboration and alignment on support goals and initiatives to ensure customer satisfaction and maintain positive relationships with customers.")]
        Support,
        [Display(Name = "Training")]
        [Description("Training type indicates that the meeting is focused on training-related activities, such as providing training materials, conducting training sessions, or following up on training-related inquiries. It may involve trainers, trainees, or other stakeholders involved in training and development initiatives, providing a platform for collaboration and alignment on training goals and initiatives to facilitate effective learning and development within the organization.")]
        Training,
        [Display(Name = "Networking")]
        [Description("Networking type indicates that the meeting is focused on networking-related activities, such as connecting with industry peers, building professional relationships, or engaging in networking events. It may involve professionals from various industries, backgrounds, or roles, providing a platform for collaboration and relationship-building opportunities within the industry or professional community to foster connections and facilitate knowledge sharing.")]
        Networking,
        [Display(Name = "Personal")]
        [Description("")]
        Personal,
        [Display(Name = "Vendor")]
        [Description("Vendor type indicates that the meeting is focused on communication and collaboration with vendors, such as discussing vendor relationships, negotiating contracts, or addressing vendor-related inquiries. It may involve vendor representatives, procurement teams, or other stakeholders involved in vendor management, providing a platform for effective communication and relationship management with vendors to ensure successful procurement and supply chain operations.")]
        Vendor,
        [Display(Name = "Customer")]
        [Description("Customer type indicates that the meeting is focused on communication and collaboration with customers, such as addressing customer inquiries, providing support, or discussing customer-related topics. It may involve customer representatives, support teams, or other stakeholders involved in customer relationship management, providing a platform for effective communication and relationship management with customers to ensure customer satisfaction and loyalty.")]
        Customer,
        [Display(Name = "Partner")]
        [Description("Partner type indicates that the meeting is focused on communication and collaboration with partners, such as discussing partnership opportunities, addressing partner-related inquiries, or engaging in joint initiatives. It may involve partner representatives, business development teams, or other stakeholders involved in partner relationship management, providing a platform for effective communication and relationship management with partners to ensure successful collaboration and mutual benefit in business partnerships.")]
        Partner,
        [Description("Team type indicates that the meeting is focused on communication and collaboration within a team, such as project updates, team announcements, or other communication relevant to team collaboration. It may involve team members, project managers, or other stakeholders involved in team activities, providing a platform for effective communication and collaboration within the team to ensure alignment and successful completion of team objectives.")]
        [Display(Name = "Team")]
        Team,
        [Display(Name = "Management")]
        [Description("Management type indicates that the meeting is focused on communication and collaboration with management, such as updates, reports, or other communication relevant to management-level activities. It may involve managers, executives, or other stakeholders involved in management responsibilities, providing a platform for effective communication and relationship management with management to ensure alignment with organizational goals and successful execution of management responsibilities.")]
        Management,
        [Display(Name = "Human Resources")]
        [Description("Human Resources type indicates that the meeting is focused on communication and collaboration with or about human resources, such as employee inquiries, HR policies, or other communication relevant to HR activities. It may involve HR representatives, employees, or other stakeholders involved in HR-related matters, providing a platform for effective communication and relationship management with HR to ensure successful resolution of HR-related issues and effective support for employees within the organization.")]
        HR,
        [Display(Name = "Finance")]
        [Description("Finance type indicates that the meeting is focused on communication and collaboration with or about finance, such as financial inquiries, budgeting, or other communication relevant to financial activities. It may involve finance representatives, financial analysts, or other stakeholders involved in financial management, providing a platform for effective communication and relationship management with finance to ensure sound financial management practices and support for the financial needs of the organization.")]
        Finance,
        [Display(Name = "Complaint")]
        [Description("Complaint type indicates that the meeting is focused on addressing complaints, such as customer complaints, employee grievances, or other types of complaints. It may involve relevant stakeholders, such as customer service representatives, HR personnel, or other parties involved in complaint resolution, providing a platform for effective communication and resolution of complaints to ensure customer satisfaction, employee well-being, and overall organizational success.")]
        Complaint,
        [Display(Name = "Conference")]
        [Description("")]
        Conference,
        [Display(Name = "Other")]
        [Description("Other type indicates that the meeting does not fit into any of the predefined categories and may be related to a variety of topics or purposes. It may require further assessment or information to determine the appropriate handling and response for the meeting communication and collaboration.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the meeting's purpose or topic is not known or has not been specified. It may require further clarification or information to determine the appropriate handling and response for the meeting communication and collaboration.")]
        Unknown
    }

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
        [Display(Name = "Other")]
        [Description("Other type indicates that the contact does not fit into any of the predefined categories and may be responsible for handling communication and tasks that are specific to their role or relationship with the associated account or organization. This contact may have unique responsibilities or areas of expertise that do not align with the other defined contact types, and their role may vary based on the specific needs and dynamics of the account or organization.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the contact's role or relationship with the associated account or organization is not known or has not been specified. This contact may require further clarification or information to determine their specific responsibilities and how they fit into the overall communication and relationship management strategy for the account or organization.")]
        Unknown
    }

    public enum AddressType
    {
        [Display(Name = "Billing")]
        Billing,
        [Display(Name = "Shipping")]
        Shipping,
        [Display(Name = "Primary")]
        Primary,
        [Display(Name = "Secondary")]
        Secondary,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Headquarters")]
        Headquarters,
        [Display(Name = "Branch")]
        Branch,
        [Display(Name = "Warehouse")]
        Warehouse,
        [Display(Name = "Office")]
        Office,
        [Display(Name = "Factory")]
        Factory,
        [Display(Name = "Store")]
        Store,
        [Display(Name = "Residence")]
        Residence,
        [Display(Name = "Mailing")]
        Mailing,
        [Display(Name = "Physical")]
        Physical,
        [Display(Name = "Legal")]
        Legal,
        [Display(Name = "Registered")]
        Registered,
        [Display(Name = "Main")]
        Main,
        [Display(Name = "Sub")]
        Sub,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum PhoneCallType
    {
        [Display(Name = "Information")]
        Info,
        [Display(Name = "Sales")]
        Sales,
        [Display(Name = "Support")]
        Support,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Competitor")]
        Competitor,
        [Display(Name = "Follow Up")]
        FollowUp,
        [Display(Name = "Prospecting")]
        Prospecting,
        [Display(Name = "Qualifying")]
        Qualifying,
        [Display(Name = "Closing")]
        Closing,
        [Display(Name = "Post Sale")]
        PostSale,
        [Display(Name = "Internal")]
        Internal,
        [Display(Name = "External")]
        External,
        [Display(Name = "Training")]
        Training,
        [Display(Name = "Conference")]
        Conference,
        [Display(Name = "Networking")]
        Networking,
        [Display(Name = "Personal")]
        Personal,
        [Display(Name = "Emergency")]
        Emergency,
        [Display(Name = "Vendor")]
        Vendor,
        [Display(Name = "Customer")]
        Customer,
        [Display(Name = "Partner")]
        Partner,
        [Display(Name = "Team")]
        Team,
        [Display(Name = "Management")]
        Management,
        [Display(Name = "Human Resources")]
        HR,
        [Display(Name = "Finance")]
        Finance,
        [Display(Name = "Complaint")]
        Complaint,
        [Display(Name = "Feedback")]
        Feedback,
        [Display(Name = "Survey")]
        Survey,
        [Display(Name = "Appointment")]
        Appointment,
        [Display(Name = "Reminder")]
        Reminder,
        [Display(Name = "Check In")]
        CheckIn,
        [Display(Name = "Check Out")]
        CheckOut,
        [Display(Name = "Introduction")]
        Introduction,
        [Display(Name = "Negotiation")]
        Negotiation,
        [Display(Name = "Contract Discussion")]
        ContractDiscussion,
        [Display(Name = "Product Demonstration")]
        ProductDemo,
        [Display(Name = "Technical Support")]
        TechnicalSupport,
        [Display(Name = "Billing Inquiry")]
        BillingInquiry,
        [Display(Name = "Collection")]
        Collection,
        [Display(Name = "Recruitment")]
        Recruitment,
        [Display(Name = "Interview")]
        Interview,
        [Display(Name = "Performance Review")]
        PerformanceReview,
        [Display(Name = "Coaching")]
        Coaching,
        [Display(Name = "Mentoring")]
        Mentoring,
        [Display(Name = "Project Update")]
        ProjectUpdate,
        [Display(Name = "Status Update")]
        StatusUpdate,
        [Display(Name = "Brainstorming")]
        Brainstorming,
        [Display(Name = "Problem Solving")]
        ProblemSolving,
        [Display(Name = "Decision Making")]
        DecisionMaking,
        [Display(Name = "Strategy Planning")]
        StrategyPlanning,
        [Display(Name = "Crisis Management")]
        CrisisManagement,
        [Display(Name = "Innovation")]
        Innovation,
        [Display(Name = "Collaboration")]
        Collaboration,
        [Display(Name = "Team Building")]
        TeamBuilding,
        [Display(Name = "Social")]
        Social,
        [Display(Name = "Casual")]
        Casual,
        [Display(Name = "Other Internal")]
        OtherInternal,
        [Display(Name = "Other External")]
        OtherExternal,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum PhoneCallDirection
    {
        [Display(Name = "Incoming")]
        Incoming,
        [Display(Name = "Outgoing")]
        Outgoing,
        [Display(Name = "Missed")]
        Missed,
        [Display(Name = "Voicemail")]
        Voicemail,
        [Display(Name = "Callback")]
        Callback,
        [Display(Name = "Forwarded")]
        Forwarded,
        [Display(Name = "Conference")]
        Conference,
        [Display(Name = "Internal")]
        Internal,
        [Display(Name = "External")]
        External,
        [Display(Name = "Uknown")]
        Unknown
    }

    public enum PhoneCallStatus
    {
        [Display(Name = "Scheduled")]
        Scheduled,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "No Show")]
        NoShow,
        [Display(Name = "Rescheduled")]
        Rescheduled,
        [Display(Name = "In Progress")]
        InProgress,
        [Display(Name = "Postponed")]
        Postponed,
        [Display(Name = "Deferred")]
        Deferred,
        [Display(Name = "Waiting For Callback")]
        WaitingForCallback,
        [Display(Name = "Left Voicemai")]
        LeftVoicemail,
        [Display(Name = "Not Answered")]
        NotAnswered,
        [Display(Name = "Answered Elsewhere")]
        AnsweredElsewhere,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum PhoneCallPriority
    {
        [Display(Name = "Low")]
        Low,
        [Display(Name = "Normal")]
        Normal,
        [Display(Name = "High")]
        High,
        [Display(Name = "Urgent")]
        Urgent,
        [Display(Name = "Critical")]
        Critical,
        [Display(Name = "Routine")]
        Routine,
        [Display(Name = "Important")]
        Important,
        [Display(Name = "Time Sensitive")]
        TimeSensitive,
        [Display(Name = "Non Urgent")]
        NonUrgent,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum EmailType
    {
        [Display(Name = "Information")]
        [Description("Information type indicates that the email is intended to convey general information or updates to the recipient. It may include news, announcements, or other non-urgent communication that does not require immediate action from the recipient.")]
        Info,
        [Display(Name = "Sales")]
        [Description("Sales type indicates that the email is related to sales activities, such as promoting products or services, providing pricing information, or following up on sales leads. It may require attention or response from the recipient to facilitate the sales process and drive revenue growth.")]
        Sales,
        [Display(Name = "Support")]
        [Description("Support type indicates that the email is related to customer support activities, such as addressing customer inquiries, resolving issues, or providing assistance. It may require attention or response from the recipient to ensure customer satisfaction and maintain positive relationships with customers.")]
        Support,
        [Display(Name = "Other")]
        [Description("Other type indicates that the email does not fit into any of the predefined categories and may be related to a variety of topics or purposes. It may require further assessment or information to determine the appropriate handling and response for the email communication.")]
        Other,
        [Display(Name = "Competitor")]
        [Description("Competitor type indicates that the email is related to competitive intelligence or activities, such as monitoring competitor offerings, analyzing market trends, or gathering information about competitors. It may require attention or response from the recipient to inform strategic decision-making and maintain a competitive edge in the market.")]
        Competitor,
        [Display(Name = "Follow Up")]
        [Description("Follow Up type indicates that the email is intended to follow up on a previous communication or interaction, such as a meeting, phone call, or previous email. It may require attention or response from the recipient to ensure continuity of communication and effective follow-up on any outstanding issues or requests.")]
        FollowUp,
        [Display(Name = "Prospecting")]
        [Description("Prospecting type indicates that the email is related to prospecting activities, such as reaching out to potential customers, generating leads, or initiating contact with new business opportunities. It may require attention or response from the recipient to facilitate the prospecting process and drive business growth.")]
        Prospecting,
        [Display(Name = "Qualifying")]
        [Description("Qualifying type indicates that the email is related to qualifying activities, such as assessing the suitability of a lead or opportunity, gathering information to determine fit, or evaluating potential business opportunities. It may require attention or response from the recipient to facilitate the qualifying process and ensure effective prioritization of leads and opportunities.")]
        Qualifying,
        [Display(Name = "Closing")]
        [Description("Closing type indicates that the email is related to closing activities, such as finalizing a sale, negotiating terms, or confirming agreements. It may require attention or response from the recipient to facilitate the closing process and ensure successful completion of sales transactions or business agreements.")]
        Closing,
        [Display(Name = "Post Sale")]
        [Description("Post Sale type indicates that the email is related to post-sale activities, such as providing customer support, addressing post-sale inquiries, or following up on customer satisfaction. It may require attention or response from the recipient to ensure ongoing customer satisfaction and maintain positive relationships with customers after a sale has been completed.")]
        PostSale,
        [Display(Name = "Internal")]
        [Description("Internal type indicates that the email is intended for internal communication within the organization, such as communication between employees, departments, or teams. It may include updates, announcements, or other communication that is relevant to internal operations and may require attention or response from the recipient to facilitate effective internal communication and collaboration.")]
        Internal,
        [Display(Name = "External")]
        [Description("External type indicates that the email is intended for communication with external parties, such as customers, partners, vendors, or other stakeholders outside of the organization. It may include communication related to sales, support, marketing, or other external-facing activities and may require attention or response from the recipient to facilitate effective communication and relationship management with external stakeholders.")]
        External,   
        [Display(Name = "Training")]
        [Description("Training type indicates that the email is related to training activities, such as providing training materials, scheduling training sessions, or following up on training-related inquiries. It may require attention or response from the recipient to facilitate effective training and development initiatives within the organization.")]
        Training,
        [Display(Name = "Conference")]
        [Description("Conference type indicates that the email is related to conference activities, such as promoting conference events, providing conference information, or following up on conference-related inquiries. It may require attention or response from the recipient to facilitate effective communication and engagement with conference attendees and stakeholders.")]
        Conference,
        [Display(Name = "Networking")]
        [Description("Networking type indicates that the email is related to networking activities, such as connecting with industry peers, building professional relationships, or engaging in networking events. It may require attention or response from the recipient to facilitate effective networking and relationship-building opportunities within the industry or professional community.")]
        Networking,
        [Display(Name = "Personal")]
        [Description("Personal type indicates that the email is related to personal communication, such as communication between friends, family members, or other personal contacts. It may include non-business-related communication and may require attention or response from the recipient based on the nature of the personal relationship and communication context.")]
        Personal,
        [Display(Name = "Emergency")]
        [Description("Emergency type indicates that the email is related to urgent or critical situations that require immediate attention and response from the recipient. It may include communication related to emergencies, crises, or other time-sensitive situations that necessitate prompt action to mitigate risks, ensure safety, or address critical issues effectively.")]
        Emergency,
        [Display(Name ="Vendor")]
        [Description("Vendor type indicates that the email is related to communication with vendors, such as inquiries, negotiations, or other communication related to vendor relationships. It may require attention or response from the recipient to facilitate effective communication and relationship management with vendors, ensuring successful procurement and supply chain operations.")]
        Vendor,
        [Display(Name = "Customer")]
        [Description("Customer type indicates that the email is related to communication with customers, such as inquiries, support requests, or other communication related to customer relationships. It may require attention or response from the recipient to facilitate effective communication and relationship management with customers, ensuring customer satisfaction and loyalty.")]
        Customer,
        [Display(Name = "Partner")]
        [Description("Partner type indicates that the email is related to communication with partners, such as collaboration, joint ventures, or other communication related to partner relationships. It may require attention or response from the recipient to facilitate effective communication and relationship management with partners, ensuring successful collaboration and mutual benefit in business partnerships.")]
        Partner,
        [Display(Name = "Team")]
        [Description("Team type indicates that the email is related to communication within a team, such as project updates, team announcements, or other communication relevant to team collaboration. It may require attention or response from the recipient to facilitate effective communication and collaboration within the team, ensuring alignment and successful completion of team objectives.")]
        Team,
        [Display(Name = "Management")]
        [Description("Management type indicates that the email is related to communication with management, such as updates, reports, or other communication relevant to management-level activities. It may require attention or response from the recipient to facilitate effective communication and relationship management with management, ensuring alignment with organizational goals and successful execution of management responsibilities.")]
        Management,
        [Display(Name = "Human Resources")]
        [Description("Human Resources type indicates that the email is related to communication with or about human resources, such as employee inquiries, HR policies, or other communication relevant to HR activities. It may require attention or response from the recipient to facilitate effective communication and relationship management with HR, ensuring successful resolution of HR-related issues and effective support for employees within the organization.")]
        HR,
        [Display(Name = "Finance")]
        [Description("Finance type indicates that the email is related to communication with or about finance, such as financial inquiries, budgeting, or other communication relevant to financial activities. It may require attention or response from the recipient to facilitate effective communication and relationship management with finance, ensuring successful resolution of financial-related issues and effective support for financial operations within the organization.")]
        Finance,
        [Display(Name = "Complaint")]
        [Description("Complaint type indicates that the email is related to a complaint or issue raised by a customer, partner, or other stakeholder. It may require attention or response from the recipient to facilitate effective resolution of the complaint, ensuring customer satisfaction and maintaining positive relationships with stakeholders.")]
        Complaint,
        [Display(Name = "Feedback")]
        [Description("Feedback type indicates that the email is related to feedback provided by a customer, partner, or other stakeholder. It may include suggestions, comments, or other feedback that can be valuable for improving products, services, or overall customer experience. It may require attention or response from the recipient to acknowledge and address the feedback effectively, demonstrating responsiveness and commitment to continuous improvement.")]
        Feedback,
        [Display(Name = "Survey")]
        [Description("Survey type indicates that the email is related to a survey or questionnaire sent to customers, partners, or other stakeholders. It may include requests for feedback, opinions, or other information that can be valuable for market research, customer satisfaction assessment, or other purposes. It may require attention or response from the recipient to encourage participation in the survey and ensure effective collection of valuable insights from stakeholders.")]
        Survey,
        [Display(Name = "Appointment")]
        [Description("Appointment type indicates that the email is related to scheduling or confirming an appointment, such as a meeting, phone call, or other scheduled event. It may require attention or response from the recipient to confirm attendance, reschedule if necessary, or provide any additional information related to the appointment to ensure successful coordination and execution of the scheduled event.")]
        Appointment,
        [Display(Name = "Reminder")]
        [Description("Reminder type indicates that the email is intended to serve as a reminder for an upcoming event, deadline, or other important date. It may require attention or response from the recipient to acknowledge the reminder, take necessary actions, or provide any additional information related to the reminder to ensure successful preparation and execution of the upcoming event or deadline.")]
        Reminder,
        [Display(Name = "Check In")]
        [Description("Check In type indicates that the email is intended to check in with the recipient, such as following up on a previous communication, providing updates, or simply checking in to maintain communication and relationship with the recipient. It may require attention or response from the recipient to acknowledge the check-in, provide any necessary updates or information, or simply maintain ongoing communication and engagement with the sender.")]
        CheckIn,
        [Display(Name = "Check Out")]
        [Description("Check Out type indicates that the email is intended to check out with the recipient, such as following up after a meeting, providing final updates, or simply checking out to conclude communication and relationship with the recipient. It may require attention or response from the recipient to acknowledge the check-out, provide any necessary final updates or information, or simply conclude ongoing communication and engagement with the sender in a professional and courteous manner.")]
        CheckOut,
        [Display(Name = "Introduction")]
        [Description("Introduction type indicates that the email is intended to introduce the sender to the recipient, such as a self-introduction, introduction of a colleague or contact, or other communication related to introductions. It may require attention or response from the recipient to acknowledge the introduction, provide any necessary information or context, or simply establish a connection and relationship with the sender for future communication and collaboration opportunities.")]
        Introduction,
        [Display(Name = "Negotiation")]
        [Description("Negotiation type indicates that the email is related to negotiation activities, such as discussing terms, pricing, or other aspects of a potential agreement or deal. It may require attention or response from the recipient to engage in the negotiation process, provide necessary information or concessions, or work towards reaching a mutually beneficial agreement with the sender.")]
        Negotiation,
        [Display(Name = "Contract Discussion")]
        [Description("Contract Discussion type indicates that the email is related to discussions about a contract, such as reviewing contract terms, negotiating contract details, or addressing any issues or concerns related to a contract. It may require attention or response from the recipient to engage in the contract discussion process, provide necessary information or feedback, or work towards reaching a successful resolution of any contract-related matters with the sender.")]
        ContractDiscussion,
        [Display(Name = "Product Demonstration")]
        [Description("Product Demonstration type indicates that the email is related to a product demonstration, such as scheduling a demo, providing information about a demo, or following up on a demo-related inquiry. It may require attention or response from the recipient to confirm attendance, provide any necessary information or materials for the demo, or simply engage in communication related to the product demonstration to facilitate successful execution and potential sales opportunities.")]
        ProductDemo,
        [Display(Name = "Technical Support")]
        [Description("Technical Support type indicates that the email is related to technical support activities, such as addressing technical issues, providing troubleshooting assistance, or following up on technical support inquiries. It may require attention or response from the recipient to facilitate effective resolution of technical issues, ensuring customer satisfaction and maintaining positive relationships with customers who require technical support.")]
        TechnicalSupport,
        [Display(Name = "Billing Inquiry")]
        [Description("Billing Inquiry type indicates that the email is related to billing inquiries, such as questions about invoices, payment issues, or other billing-related communication. It may require attention or response from the recipient to address the billing inquiry effectively, ensuring customer satisfaction and maintaining positive relationships with customers who have billing-related concerns or questions.")]
        BillingInquiry,
        [Display(Name = "Collection")]
        [Description("Collection type indicates that the email is related to collection activities, such as following up on overdue payments, addressing collection-related inquiries, or communicating with customers about outstanding balances. It may require attention or response from the recipient to facilitate effective collection efforts, ensuring timely resolution of outstanding payments and maintaining positive relationships with customers while addressing collection-related matters.")]
        Collection,
        [Display(Name = "Recruitment")]
        [Description("Recruitment type indicates that the email is related to recruitment activities, such as job postings, candidate inquiries, or communication with potential candidates. It may require attention or response from the recipient to facilitate effective recruitment efforts, ensuring successful identification and engagement of qualified candidates for job opportunities within the organization.")]
        Recruitment,
        [Display(Name = "Interview")]
        [Description("Interview type indicates that the email is related to interview activities, such as scheduling interviews, providing interview information, or following up on interview-related inquiries. It may require attention or response from the recipient to confirm interview details, provide any necessary information or materials for the interview, or simply engage in communication related to the interview process to facilitate successful execution and potential hiring opportunities.")]
        Interview,
        [Display(Name = "Performance Review")]
        [Description("Performance Review type indicates that the email is related to performance review activities, such as scheduling performance reviews, providing performance review information, or following up on performance review-related inquiries. It may require attention or response from the recipient to confirm performance review details, provide any necessary information or materials for the performance review, or simply engage in communication related to the performance review process to facilitate successful execution and potential employee development opportunities.")]
        PerformanceReview,
        [Display(Name = "Coaching")]
        [Description("Coaching type indicates that the email is related to coaching activities, such as providing coaching materials, scheduling coaching sessions, or following up on coaching-related inquiries. It may require attention or response from the recipient to facilitate effective coaching and development initiatives within the organization, ensuring successful support for employee growth and performance improvement through coaching efforts.")]
        Coaching,
        [Display(Name = "Mentoring")]
        [Description("Mentoring type indicates that the email is related to mentoring activities, such as providing mentoring materials, scheduling mentoring sessions, or following up on mentoring-related inquiries. It may require attention or response from the recipient to facilitate effective mentoring relationships and development initiatives within the organization, ensuring successful support for employee growth and career development through mentoring efforts.")]
        Mentoring,
        [Display(Name = "Project Update")]
        [Description("Project Update type indicates that the email is related to providing updates on a project, such as progress reports, milestone achievements, or other communication relevant to project status. It may require attention or response from the recipient to acknowledge the project update, provide any necessary feedback or information, or simply stay informed about the progress and status of the project to facilitate effective project management and successful completion of project objectives.")]
        ProjectUpdate,
        [Display(Name = "Status Update")]
        [Description("Status Update type indicates that the email is related to providing updates on the status of a task, issue, or other matter, such as progress reports, resolution updates, or other communication relevant to status. It may require attention or response from the recipient to acknowledge the status update, provide any necessary feedback or information, or simply stay informed about the status of the matter to facilitate effective communication and successful resolution of any outstanding issues or tasks.")]
        StatusUpdate,
        [Display(Name = "Brainstorming")]
        [Description("Brainstorming type indicates that the email is related to brainstorming activities, such as generating ideas, discussing potential solutions, or engaging in creative thinking. It may require attention or response from the recipient to actively participate in the brainstorming process, provide input and ideas, or simply engage in communication related to brainstorming efforts to facilitate effective idea generation and problem-solving within the organization.")]
        Brainstorming,
        [Display(Name = "Problem Solving")]
        [Description("Problem Solving type indicates that the email is related to problem-solving activities, such as addressing challenges, finding solutions, or engaging in critical thinking. It may require attention or response from the recipient to actively participate in the problem-solving process, provide insights and suggestions, or simply engage in communication related to problem-solving efforts to facilitate effective resolution of issues and challenges within the organization.")]
        ProblemSolving,
        [Display(Name = "Decision Making")]
        [Description("Decision Making type indicates that the email is related to decision-making activities, such as discussing options, evaluating alternatives, or engaging in discussions to reach a decision. It may require attention or response from the recipient to actively participate in the decision-making process, provide input and perspectives, or simply engage in communication related to decision-making efforts to facilitate effective decision-making and successful outcomes for the organization.")]
        DecisionMaking,
        [Display(Name = "Strategy Planning")]
        [Description("Strategy Planning type indicates that the email is related to strategy planning activities, such as discussing strategic goals, developing plans, or engaging in discussions to shape the strategic direction of the organization. It may require attention or response from the recipient to actively participate in the strategy planning process, provide insights and perspectives, or simply engage in communication related to strategy planning efforts to facilitate effective strategic planning and successful execution of organizational strategies.")]   
        StrategyPlanning,
        [Display(Name = "Crisis Management")]
        [Description("Crisis Management type indicates that the email is related to managing a crisis or critical situation, such as addressing urgent issues, coordinating response efforts, or communicating with stakeholders during a crisis. It may require immediate attention and response from the recipient to facilitate effective crisis management, ensuring timely resolution of the crisis and minimizing negative impacts on the organization and its stakeholders.")]
        CrisisManagement,
        [Display(Name = "Innovation")]
        [Description("Innovation type indicates that the email is related to innovation activities, such as discussing new ideas, sharing innovative solutions, or engaging in communication related to fostering innovation within the organization. It may require attention or response from the recipient to actively participate in innovation efforts, provide insights and suggestions, or simply engage in communication related to innovation to facilitate a culture of creativity and continuous improvement within the organization.")]
        Innovation,
        [Display(Name = "Collaboration")]
        [Description("Collaboration type indicates that the email is related to collaboration activities, such as working together on a project, sharing information, or engaging in communication to facilitate teamwork and cooperation. It may require attention or response from the recipient to actively participate in collaborative efforts, provide input and support, or simply engage in communication related to collaboration to facilitate effective teamwork and successful outcomes for the organization.")]
        Collaboration,
        [Display(Name = "Team Building")]
        [Description("Team Building type indicates that the email is related to team-building activities, such as organizing team events, providing team-building resources, or engaging in communication to foster team cohesion and camaraderie. It may require attention or response from the recipient to actively participate in team-building efforts, provide input and support, or simply engage in communication related to team building to facilitate a positive and collaborative team environment within the organization.")]
        TeamBuilding,
        [Display(Name = "Social")]
        [Description("Social type indicates that the email is related to social activities, such as organizing social events, sharing social updates, or engaging in communication to foster social connections and relationships. It may require attention or response from the recipient to actively participate in social efforts, provide input and support, or simply engage in communication related to social activities to facilitate a positive and engaging social environment within the organization.")]    
        Social,
        [Display(Name = "Casual")]
        [Description("Casual type indicates that the email is related to casual communication, such as informal updates, friendly check-ins, or other communication that is not necessarily business-related. It may require attention or response from the recipient based on the nature of the relationship and communication context, but it generally represents a more relaxed and informal style of communication compared to other email types.")]
        Casual,
        [Display(Name = "Other Internal")]
        [Description("Other Internal type indicates that the email is related to internal communication within the organization that does not fit into any of the predefined categories. It may include communication on a variety of topics or purposes that are relevant to internal operations and may require attention or response from the recipient to facilitate effective internal communication and collaboration.")]
        OtherInternal,
        [Display(Name = "Other External")]
        [Description("Other External type indicates that the email is related to communication with external parties that does not fit into any of the predefined categories. It may include communication on a variety of topics or purposes that are relevant to external-facing activities and may require attention or response from the recipient to facilitate effective communication and relationship management with external stakeholders.")]
        OtherExternal,
        [Display(Name = "Unknown")]
        [Description("")]
        Unknown
    }

    public enum EmailStatus
    {
        [Display(Name = "Draft")]
        [Description("Draft status indicates that the email is still being composed and has not yet been sent. It represents a work in progress that may require further editing, review, or approval before it can be sent to the intended recipients.")]
        Draft,
        [Display(Name = "Sent")]
        [Description("Sent status indicates that the email has been successfully sent to the intended recipients. It represents a completed communication that may require follow-up or tracking to ensure successful delivery and response.")]
        Sent,
        [Display(Name = "Received")]
        [Description("Received status indicates that the email has been successfully received by the recipient's email server. It represents a completed communication that may require attention or response from the recipient, but it does not necessarily indicate that the email has been read or acknowledged by the recipient.")]
        Received,
        [Display(Name = "Read")]
        [Description("Read status indicates that the email has been opened and viewed by the recipient. It represents a completed communication that has been acknowledged by the recipient, but it does not necessarily indicate that the recipient has taken any specific action in response to the email.")]
        Read,
        [Display(Name = "Unread")]
        [Description("Unread status indicates that the email has been received by the recipient but has not yet been opened or viewed. It represents a completed communication that may require attention or response from the recipient, but it has not yet been acknowledged or acted upon by the recipient.")]
        Unread,
        [Display(Name = "Replied")]
        [Description("Replied status indicates that the recipient has responded to the email by sending a reply message. It represents a completed communication that has been acknowledged and acted upon by the recipient, and it may require further follow-up or tracking to ensure successful resolution of any issues or requests raised in the original email.")]
        Replied,
        [Display(Name = "Replied All")]
        [Description("Replied All status indicates that the recipient has responded to the email by sending a reply message to all recipients of the original email. It represents a completed communication that has been acknowledged and acted upon by the recipient, and it may require further follow-up or tracking to ensure successful resolution of any issues or requests raised in the original email, as well as effective communication with all parties involved.")]
        Forwarded,
        [Display(Name = "Scheduled")]
        [Description("Scheduled status indicates that the email has been composed and is scheduled to be sent at a future date and time. It represents a planned communication that may require further editing, review, or approval before it can be sent to the intended recipients, and it may require tracking to ensure successful delivery and response when the scheduled time arrives.")]
        Scheduled,
        [Display(Name = "Canceled")]
        [Description("Canceled status indicates that the email was scheduled to be sent but has been canceled before it was sent. It represents a communication that will not be delivered to the intended recipients, and it may require follow-up or tracking to ensure that any necessary adjustments are made to the communication plan or schedule.")]
        Canceled,
        [Display(Name = "Failed")]
        [Description("Failed status indicates that an attempt was made to send the email, but it was not successfully delivered to the intended recipients. It represents a communication that may require troubleshooting or follow-up to identify and resolve any issues that prevented successful delivery, and it may require rescheduling or alternative communication methods to ensure that the intended message is effectively conveyed to the recipients.")]
        Failed,
        [Display(Name = "Deferred")]
        [Description("Deferred status indicates that the email has been temporarily delayed in the sending process, often due to issues with the recipient's email server or network connectivity. It represents a communication that may require monitoring and follow-up to ensure successful delivery once the underlying issues are resolved, and it may require rescheduling or alternative communication methods if the delay persists.")]
        Deferred,
        [Display(Name = "Waiting For Reply")]
        [Description("Waiting For Reply status indicates that the email has been sent and is awaiting a response from the recipient. It represents a communication that has been acknowledged by the recipient but has not yet received a reply, and it may require follow-up or tracking to ensure timely response and resolution of any issues or requests raised in the original email.")]
        WaitingForReply,
        [Display(Name = "Not Delivered")]
        [Description("Not Delivered status indicates that the email was not successfully delivered to the intended recipients, often due to issues with the recipient's email server, invalid email addresses, or other technical problems. It represents a communication that may require troubleshooting or follow-up to identify and resolve any issues that prevented successful delivery, and it may require rescheduling or alternative communication methods to ensure that the intended message is effectively conveyed to the recipients.")]
        NotDelivered,
        [Display(Name = "Delivered Elsewhere")]
        [Description("Delivered Elsewhere status indicates that the email was successfully delivered, but not to the intended recipient's primary email address. This may occur if the recipient has multiple email addresses or if there are forwarding rules in place. It represents a communication that has been acknowledged by the recipient but may require follow-up or tracking to ensure that the intended message is effectively conveyed to the correct email address and that any necessary adjustments are made to the communication plan or schedule.")]
        DeliveredElsewhere,
        [Display(Name = "Unknown")]
        [Description("Unknown status indicates that the current status of the email cannot be determined or is not applicable. It may require further investigation or information to determine the appropriate status for the email communication, and it may require monitoring or follow-up to ensure that any necessary actions are taken to resolve any issues or requests raised in the original email.")]
        Unknown
    }

    public enum EmailPriority
    {
        [Display(Name = "Low")]
        [Description("Low priority indicates that the email can be addressed after higher priority emails have been resolved. It may not require immediate attention and can be scheduled for response at a later time.")]
        Low,
        [Display(Name = "Normal")]
        [Description("Normal priority indicates that the email should be addressed in a timely manner, but it does not require immediate attention. It represents standard communication that may require a response within a reasonable timeframe.")]
        Normal,
        [Display(Name = "High")]
        [Description("High priority indicates that the email requires prompt attention and should be addressed as soon as possible. It represents communication that may have a significant impact on business operations, customer satisfaction, or other critical factors and may require immediate action to resolve.")]
        High,
        [Display(Name = "Urgent")]
        [Description("Urgent priority indicates that the email requires immediate attention and should be addressed without delay. It represents communication that may have a critical impact on business operations, customer satisfaction, or other time-sensitive factors and may require urgent action to resolve.")]
        Urgent,
        [Display(Name = "Critical")]
        [Description("Critical priority indicates that the email requires immediate attention and should be addressed as a top priority. It represents communication that may have a severe impact on business operations, customer satisfaction, or other critical factors and may require immediate and decisive action to resolve.")]
        Critical,
        [Display(Name = "Routine")]
        [Description("Routine priority indicates that the email can be addressed in the normal course of business and does not require immediate attention. It represents standard communication that may not have a significant impact on business operations or customer satisfaction and can be scheduled for response at a later time.")]
        Routine,
        [Display(Name = "Important")]
        [Description("Important priority indicates that the email requires attention and should be addressed in a timely manner. It represents communication that may have a significant impact on business operations, customer satisfaction, or other important factors and may require prompt action to resolve.")]
        Important,
        [Display(Name = "Time Sensitive")]
        [Description("Time Sensitive priority indicates that the email requires attention within a specific timeframe and should be addressed as soon as possible. It represents communication that may have a significant impact on business operations, customer satisfaction, or other time-sensitive factors and may require timely action to resolve.")]
        TimeSensitive,
        [Display(Name = "NonUrgent")]
        [Description("Non Urgent priority indicates that the email does not require immediate attention and can be addressed after higher priority emails have been resolved. It represents communication that may not have a significant impact on business operations or customer satisfaction and can be scheduled for response at a later time.")]
        NonUrgent,
        [Display(Name = "Unknown")]
        [Description("Unknown priority indicates that the priority of the email has not been determined or is not applicable. It may require further assessment or information to determine the appropriate level of urgency for addressing the email communication.")]
        Unknown
    }

    public enum EmailDirection
    {
        [Display(Name = "Incoming")]
        [Description("Incoming indicates that the email was received by the recipient from an external source. It represents communication initiated by someone outside of the organization and may require attention or response from the recipient.")]
        Incoming,
        [Display(Name = "Outgoing")]
        [Description("Outgoing indicates that the email was sent by the sender to an external recipient. It represents communication initiated by someone within the organization and may require follow-up or tracking to ensure successful delivery and response.")]
        Outgoing,
        [Display(Name = "Internal")]
        [Description("Internal indicates that the email was sent and received within the same organization. It represents communication between individuals or teams within the organization and may require coordination or collaboration to achieve shared goals.")]
        Internal,
        [Display(Name = "External")]
        [Description("External indicates that the email was sent or received from an external source outside of the organization. It represents communication that may involve customers, partners, vendors, or other stakeholders and may require careful management to maintain relationships and ensure effective communication.")]
        External,
        [Display(Name = "Unknown")]
        [Description("Unknown indicates that the direction of the email has not been determined or is not applicable. It may require further assessment or information to determine the appropriate classification for the email communication.")]
        Unknown
    }

    public enum EmailAttachmentType
    {
        [Display(Name = "Document")]
        Document,
        [Display(Name = "Spreadsheet")]
        Spreadsheet,
        [Display(Name = "Presentation")]
        Presentation,
        [Display(Name = "Image")]
        Image,
        [Display(Name = "PDF")]
        PDF,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown

    }

    public enum TaskType
    {
        [Display(Name = "To Do")]
        ToDo,
        [Display(Name = "In Progress")]
        InProgress,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Deferred")]
        Deferred,
        [Display(Name = "Waiting For Someone Else")]
        WaitingForSomeoneElse,
        [Display(Name = "Waiting For Something")]
        WaitingForSomething,
        [Display(Name = "Not Started")]
        NotStarted,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum TaskPriority
    {
        [Display(Name = "Low")]
        Low,
        [Display(Name = "Normal")]
        Normal,
        [Display(Name = "High")]
        High,
        [Display(Name = "Urgent")]
        Urgent,
        [Display(Name = "Critical")]
        Critical,
        [Display(Name = "Routine")]
        Routine,
        [Display(Name = "Important")]
        Important,
        [Display(Name = "Time Sensitive")]
        TimeSensitive,
        [Display(Name = "Non Urgent")]
        NonUrgent,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum TaskStatus
    {
        [Display(Name = "Not Started")]
        NotStarted,
        [Display(Name = "In Progress")]
        InProgress,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Deferred")]
        Deferred,
        [Display(Name = "Waiting For Someone Else")]
        WaitingForSomeoneElse,
        [Display(Name = "Waiting For Something")]
        WaitingForSomething,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum AccountType
    {
        [Display(Name = "Customer")]
        Customer,
        [Display(Name = "Vendor")]
        Vendor,
        [Display(Name = "Partner")]
        Partner,
        [Display(Name = "Competitor")]
        Competitor,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

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

    public enum CaseType
    {
        [Display(Name = "Question")]
        Question,
        [Display(Name = "Problem")]
        Problem,
        [Display(Name = "Feature Request")]
        FeatureRequest,
        [Display(Name = "Complaint")]
        Complaint,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum CasePriority
    {
        [Display(Name = "Low")]
        Low,
        [Display(Name = "Normal")]
        Normal,
        [Display(Name = "High")]
        High,
        [Display(Name = "Urgent")]
        Urgent,
        [Display(Name = "Critical")]
        Critical,
        [Display(Name = "Routine")]
        Routine,
        [Display(Name = "Important")]
        Important,
        [Display(Name = "Time Sensitive")]
        TimeSensitive,
        [Display(Name = "Non Urgent")]
        NonUrgent,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum CaseStatus
    {
        [Display(Name = "New")]
        New,
        [Display(Name = "Active")]
        Active,
        [Display(Name = "Resolved")]
        Resolved,
        [Display(Name = "Closed")]
        Closed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementType
    {
        [Display(Name = "Standard")]
        Standard,
        [Display(Name = "Premium")]
        Premium,
        [Display(Name = "Enterprise")]
        Enterprise,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementStatus
    {
        [Display(Name = "Active")]
        Active,
        [Display(Name = "Expired")]
        Expired,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementPriority
    {
        [Display(Name = "Low")]
        [Description("Low priority indicates that the issue can be addressed after higher priority issues have been resolved. It may not require immediate attention and can be scheduled for resolution at a later time.")]
        Low,
        [Display(Name = "Normal")]
        [Description("Normal priority indicates that the issue should be addressed in a timely manner, but it is not critical. It may require attention within a reasonable timeframe, but it does not require immediate action.")]
        Normal,
        [Display(Name = "High")]
        [Description("High priority indicates that the issue is important and should be addressed as soon as possible. It may have a significant impact on the business or customer experience, and it requires immediate attention to prevent further issues or damage.")]
        High,
        [Display(Name = "Urgent")]
        [Description("Urgent priority indicates that the issue is critical and requires immediate attention. It may have a severe impact on the business or customer experience, and it requires immediate action to prevent further issues or damage.")]
        Urgent,
        [Display(Name = "Critical")]
        [Description("Critical priority indicates that the issue is of utmost importance and requires immediate attention. It may have a catastrophic impact on the business or customer experience, and it requires immediate action to prevent further issues or damage.")]
        Critical,
        [Display(Name = "Routine")]
        [Description("Routine priority indicates that the issue is of low importance and can be addressed at a later time. It may not have a significant impact on the business or customer experience, and it does not require immediate attention.")]
        Routine,
        [Display(Name = "Important")]
        [Description("Important priority indicates that the issue is significant and should be addressed in a timely manner. It may have a moderate impact on the business or customer experience, and it requires attention within a reasonable timeframe to prevent further issues or damage.")]
        Important,
        [Display(Name = "Time Sensitive")]
        [Description("Time Sensitive priority indicates that the issue is important and requires attention within a specific timeframe. It may have a significant impact on the business or customer experience if not addressed within the specified timeframe, and it requires timely action to prevent further issues or damage.")]
        TimeSensitive,
        [Display(Name = "Non Urgent")]
        [Description("Non Urgent priority indicates that the issue is of low importance and does not require immediate attention. It may have a minimal impact on the business or customer experience, and it can be addressed at a later time without significant consequences.")] 
        NonUrgent,
        [Display(Name = "Unknown")]
        [Description("Unknown priority indicates that the priority level of the issue has not been determined or is not applicable. It may require further assessment or information to determine the appropriate priority level for resolution.")]
        Unknown
    }

    public enum ServiceLevelAgreementDirection
    {
        [Display(Name = "Inbound")]
        Inbound,
        [Display(Name = "Outbound")]
        Outbound,
        [Display(Name = "Internal")]
        Internal,
        [Display(Name = "External")]
        External,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementTypeOfService
    {
        [Display(Name = "Support")]
        Support,
        [Display(Name = "Maintenance")]
        Maintenance,
        [Display(Name = "Consulting")]
        Consulting,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementResponseTime
    {
        [Display(Name = "1 Hour")]
        OneHour,
        [Display(Name = "4 Hours")]
        FourHours,
        [Display(Name = "8 Hours")]
        EightHours,
        [Display(Name = "24 Hours")]
        TwentyFourHours,
        [Display(Name = "48 Hours")]
        FortyEightHours,
        [Display(Name = "72 Hours")]
        SeventyTwoHours,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementResolutionTime
    {
        [Display(Name = "4 Hours")]
        FourHours,
        [Display(Name = "8 Hours")]
        EightHours,
        [Display(Name = "24 Hours")]
        TwentyFourHours,
        [Display(Name = "48 Hours")]
        FortyEightHours,
        [Display(Name = "72 Hours")]
        SeventyTwoHours,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRating
    {
        [Display(Name = "Very Satisfied")]
        VerySatisfied,
        [Display(Name = "Satisfied")]
        Satisfied,
        [Display(Name = "Neutral")]
        Neutral,
        [Display(Name = "Dissatisfied")]
        Dissatisfied,
        [Display(Name = "Very Dissatisfied")]
        VeryDissatisfied,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingReason
    {
        [Display(Name = "Quality Of Service")]
        QualityOfService,
        [Display(Name = "Timeliness")]
        Timeliness,
        [Display(Name = "Professionalism")]
        Professionalism,
        [Display(Name = "Communication")]
        Communication,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingFeedback
    {
        [Display(Name = "Positive")]
        Positive,
        [Display(Name = "Neutral")]
        Neutral,
        [Display(Name = "Negative")]
        Negative,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingFollowUpAction
    {
        [Display(Name = "Contact Customer")]
        ContactCustomer,
        [Display(Name = "Offer Refund")]
        OfferRefund,
        [Display(Name = "Provide Discount")]
        ProvideDiscount,
        [Display(Name = "Escalate To Management")]
        EscalateToManagement,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingFollowUpActionStatus
    {
        [Display(Name = "Not Started")]
        NotStarted,
        [Display(Name = "In Progress")]
        InProgress,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Deferred")]
        Deferred,
        [Display(Name = "Waiting For Someone Else")]
        WaitingForSomeoneElse,
        [Display(Name = "Waiting For Something")]
        WaitingForSomething,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingFollowUpActionPriority
    {
        [Display(Name = "Low")]
        Low,
        [Display(Name = "Normal")]
        Normal,
        [Display(Name = "High")]
        High,
        [Display(Name = "Urgent")]
        Urgent,
        [Display(Name = "Critical")]
        Critical,
        [Display(Name = "Routine")]
        Routine,
        [Display(Name = "Important")]
        Important,
        [Display(Name = "Time Sensitive")]
        TimeSensitive,
        [Display(Name = "Non Urgent")]
        NonUrgent,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingFollowUpActionType
    {
        [Display(Name = "Phone Call")]
        PhoneCall,
        [Display(Name = "Email")]
        Email,
        [Display(Name = "Meeting")]
        Meeting,
        [Display(Name = "Task")]
        Task,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum RoleType
    {
        [Display(Name = "System Administrator")]
        SystemAdministrator,
        [Display(Name = "Salesperson")]
        Salesperson,
        [Display(Name = "Customer Service Representative")]
        CustomerServiceRep,
        [Display(Name = "Marketing Specialist")]
        MarketingSpecialist,
        [Display(Name = "Project Manager")]
        ProjectManager,
        [Display(Name = "Developer")]
        Developer,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum SalesRoleType
    {
        [Display(Name = "Account Manager")]
        AccountManager,
        [Display(Name = "Sales Executive")]
        SalesExecutive,
        [Display(Name = "Sales Manager")]
        SalesManager,
        [Display(Name = "Sales Representative")]
        SalesRepresentative,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum SupportRoleType
    {
        [Display(Name = "Support Engineer")]
        SupportEngineer,
        [Display(Name = "Support Manager")]
        SupportManager,
        [Display(Name = "Customer Service Representative")]
        CustomerServiceRep,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum MarketingRoleType
    {
        [Display(Name = "Marketing Manager")]
        MarketingManager,
        [Display(Name = "Marketing Specialist")]
        MarketingSpecialist,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ProjectRoleType
    {
        [Display(Name = "Project Manager")]
        ProjectManager,
        [Display(Name = "Developer")]
        Developer,
        [Display(Name = "Tester")]
        Tester,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum OtherRoleType
    {
        [Display(Name = "Consultant")]
        Consultant,
        [Display(Name = "Contractor")]
        Contractor,
        [Display(Name = "Vendor")]
        Vendor,
        [Display(Name = "Partner")]
        Partner,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum TeamRoleType
    {
        [Display(Name = "Team Lead")]
        TeamLead,
        [Display(Name = "Team Member")]
        TeamMember,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum BusinessUnitType
    {
        [Display(Name = "Sales")]
        [Description("The sales business unit is responsible for generating revenue for the company by selling products or services to customers.")]
        Sales,
        [Display(Name = "Support")]
        [Description("The support business unit is responsible for providing assistance to customers who have purchased products or services from the company, including troubleshooting, technical support, and customer service.")]
        Support,
        [Display(Name = "Marketing")]
        [Description("The marketing business unit is responsible for promoting the company's products or services to potential customers, including advertising, public relations, and market research.")]
        Marketing,
        [Display(Name = "Development")]
        [Description("The development business unit is responsible for creating and improving the company's products or services, including software development, product design, and research and development.")]
        Development,
        [Display(Name = "Human Resources")]
        [Description("The human resources business unit is responsible for managing the company's workforce, including recruiting, hiring, training, and employee relations.")]
        HR,
        [Display(Name = "Finance")]
        [Description("The finance business unit is responsible for managing the company's financial resources, including accounting, budgeting, and financial reporting.")]
        Finance,
        [Display(Name = "Operations")]
        [Description("The operations business unit is responsible for managing the company's day-to-day activities, including supply chain management, logistics, and facilities management.")]
        Operations,
        [Display(Name = "Executive")]
        [Description("The executive business unit is responsible for setting the overall direction and strategy of the company, including making high-level decisions and managing relationships with key stakeholders.")]
        Executive,
        [Display(Name = "Management")]
        [Description("The management business unit is responsible for overseeing the company's various departments and ensuring that they are working together effectively to achieve the company's goals.")]
        Management,
        [Display(Name = "Customer Service")]
        [Description("The customer service business unit is responsible for providing support and assistance to customers before, during, and after a purchase, including answering questions, resolving issues, and ensuring customer satisfaction.")]
        CustomerService,
        [Display(Name = "Research and Development")]
        [Description("The research and development business unit is responsible for conducting research and developing new products or services, as well as improving existing ones, to meet the changing needs of customers and stay competitive in the market.")]
        RnD,
        [Display(Name = "Legal")]
        [Description("The legal business unit is responsible for managing the company's legal affairs, including contracts, compliance, intellectual property, and litigation.")]
        Legal,
        [Display(Name = "IT")]
        [Description("The IT business unit is responsible for managing the company's technology infrastructure, including hardware, software, networks, and data management, to support the company's operations and strategic goals.")]
        IT,
        [Display(Name = "Administration")]
        [Description("The administration business unit is responsible for managing the company's administrative functions, including office management, facilities management, and general administrative support to ensure the smooth operation of the company.")]
        Administration,
        [Display(Name = "Other")]
        [Description("A business unit that does not fit into the other categories.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown")]   
        Unknown
    }

    public enum BusinessProcessFlowType
    {
        [Display(Name = "Lead Qualification")]
        [Description("The process of evaluating a lead to determine if they are a good fit for the company's products or services.")]
        LeadQualification,
        [Display(Name = "Opportunity Management")]
        [Description("The process of managing a sales opportunity from initial contact to close, including activities such as needs analysis, proposal development, and negotiation.")]
        OpportunityManagement,
        [Display(Name = "Case Resolution")]
        [Description("The process of resolving a customer service case, including activities such as troubleshooting, providing solutions, and communicating with the customer.")]
        CaseResolution,
        [Display(Name = "Project Management")]
        [Description("The process of managing a project from initiation to completion, including activities such as planning, execution, monitoring, and control.")]
        ProjectManagement,
        [Display(Name = "Other")]
        [Description("A business process flow type that does not fit into the other categories.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown")]
        Unknown
    }

    public enum BusinessProcessFlowStageType
    {
        [Display(Name = "Lead Qualification")]
        [Description("The process of evaluating a lead to determine if they are a good fit for the company's products or services.")]
        LeadQualification,
        [Display(Name = "Opportunity Management")]
        [Description("The process of managing a sales opportunity from initial contact to close, including activities such as needs analysis, proposal development, and negotiation.")]
        OpportunityManagement,
        [Display(Name = "Case Resolution")]
        [Description("The process of resolving a customer service case, including activities such as troubleshooting, providing solutions, and communicating with the customer.")]
        CaseResolution,
        [Display(Name = "Project Management")]
        [Description("The process of managing a project from initiation to completion, including activities such as planning, execution, monitoring, and control.")]   
        ProjectManagement,
        [Display(Name = "Other")]
        [Description("A stage type that does not fit into the other categories.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown")]
        Unknown
    }

    public enum BusinessProcessFlowStageStatus
    {
        [Display(Name = "Not Started")]
        NotStarted,
        [Display(Name = "In Progress")]
        InProgress,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum BusinessProcessFlowStageCategory
    {
        [Display(Name = "Qualify")]
        Qualify,
        [Display(Name = "Develop")]
        Develop,
        [Display(Name = "Propose")]
        Propose,
        [Display(Name = "Close")]
        Close,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum BusinessProcessFlowStageStatusReason
    {
        [Display(Name = "None")]
        None,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Failed")]
        Failed,
        [Display(Name = "Success")]
        Success,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum StatusType
    {
        [Display(Name = "Active")]
        Active,
        [Display(Name = "Inactive")]
        Inactive,
        [Display(Name = "Pending")]
        Pending,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum StatusReasonType
    {
        [Display(Name = "None")]
        None,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Failed")]
        Failed,
        [Display(Name = "Success")]
        Success,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum StateType
    {
        [Display(Name = "Active")]
        Active,
        [Display(Name = "Inactive")]
        Inactive,
        [Display(Name = "Draft")]
        Draft,
        [Display(Name = "Submitted")]
        Submitted,
        [Display(Name = "Approved")]
        Approved,
        [Display(Name = "Rejected")]
        Rejected,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum StateReasonType
    {
        [Display(Name = "None")]
        [Description("Indicates that there is no specific reason for the current state.")]
        [Category("General")]
        None,
        [Display(Name = "Canceled")]
        [Description("Indicates that the record was canceled, either by the user or by the system.")]
        [Category("General")]
        Canceled,
        [Display(Name = "Failed")]
        [Description("Indicates that the record failed to complete its intended process, either due to an error or because of a business rule violation.")]
        [Category("General")]
        Failed,
        [Display(Name = "Success")]
        [Description("Indicates that the record successfully completed its intended process.")]
        [Category("General")]
        Success,
        [Display(Name = "Other")]
        [Description("Indicates that there is a reason for the current state that does not fit into the other categories.")]
        [Category("Other")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Indicates that the reason for the current state is unknown or unspecified.")]
        [Category("Other")]
        Unknown
    }

    public enum RelationshipType
    {
        [Display(Name = "Parent")]
        Parent,
        [Display(Name = "Child")]
        Child,
        [Display(Name = "Sibling")]
        Sibling,
        [Display(Name = "Spouse")]
        Spouse,
        [Display(Name = "Partner")]
        Partner,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

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



    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum value)
        {
            var member = value.GetType().GetMember(value.ToString());
            var attribute = member[0].GetCustomAttribute<DisplayAttribute>();

            return attribute?.Name ?? value.ToString();
        }

    }