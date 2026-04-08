using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
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
