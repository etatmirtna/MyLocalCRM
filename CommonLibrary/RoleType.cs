using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum RoleType
    {
        [Display(Name = "System Administrator")]
        [Description("System Administrator role means that the person has administrative privileges and is responsible for managing and maintaining the system, including user accounts, security settings, and overall system configuration.")]
        SystemAdministrator,
        [Display(Name = "Salesperson")]
        [Description("Salesperson role means that the person is responsible for selling products or services to customers and achieving sales targets.")]
        Salesperson,
        [Display(Name = "Customer Service Representative")]
        [Description("Customer Service Representative role means that the person is responsible for assisting customers with their inquiries and issues.")]
        CustomerServiceRep,
        [Display(Name = "Marketing Specialist")]
        [Description("Marketing Specialist role means that the person is responsible for developing and implementing marketing strategies to promote products or services.")]
        MarketingSpecialist,
        [Display(Name = "Project Manager")]
        [Description("Project Manager role means that the person is responsible for planning, executing, and closing projects, ensuring that project goals are met on time and within budget.")]
        ProjectManager,
        [Display(Name = "Business Analyst")]
        [Description("Business Analyst role means that the person is responsible for analyzing business needs and requirements, and providing solutions to improve business processes.")]
        BusinessAnalyst,
        [Display(Name = "Data Analyst")]
        [Description("Data Analyst role means that the person is responsible for analyzing and interpreting complex data to help organizations make informed business decisions.")]
        DataAnalyst,
        [Display(Name = "Developer")]
        [Description("Developer role means that the person is responsible for designing, coding, and testing software applications.")]
        Developer,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }
}