using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
