using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum TeamRoleType
    {
        [Display(Name = "Team Lead")]
        [Description("Team Lead role means that the person is responsible for leading the team and managing its activities.")]
        TeamLead,
        [Display(Name = "Team Member")]
        [Description("Team Member role means that the person is a member of the team and contributes to the team's activities.")]
        TeamMember,
        [Display(Name = "Other")]
        [Description("Other role means that the role does not fall into any of the predefined categories and provides an alternative explanation.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown role means that the role is not specified or cannot be determined.")]
        Unknown
    }
}