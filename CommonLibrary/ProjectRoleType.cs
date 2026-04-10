using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ProjectRoleType
    {
        [Display(Name = "Project Manager")]
        [Description("Project Manager role means that the person is responsible for planning, executing, and closing projects.")]
        ProjectManager,
        [Display(Name = "Developer")]
        [Description("Developer role means that the person is responsible for writing and maintaining code for the project.")]
        Developer,
        [Display(Name = "Tester")]
        [Description("Tester role means that the person is responsible for testing the project to ensure it meets the required standards.")]
        Tester,
        [Display(Name = "Other")]
        [Description("Other role means that the role does not fall into any of the predefined categories and provides an alternative explanation.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown role means that the role is not specified or cannot be determined.")]
        Unknown
    }
}