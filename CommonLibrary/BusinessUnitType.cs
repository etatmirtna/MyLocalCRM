using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
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
