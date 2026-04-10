using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
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
}