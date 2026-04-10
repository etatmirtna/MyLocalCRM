using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum CaseType
    {
        [Display(Name = "Question")]
        [Description("Case is a question.")]
        Question,
        [Display(Name = "Problem")]
        [Description("Case is a problem.")]
        Problem,
        [Display(Name = "Feature Request")]
        [Description("Case is a feature request.")]
        FeatureRequest,
        [Display(Name = "Complaint")]
        [Description("Case is a complaint.")]
        Complaint,
        [Display(Name = "Other")]
        [Description("Case is of other type.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Case is of unknown type.")]
        Unknown
    }
}