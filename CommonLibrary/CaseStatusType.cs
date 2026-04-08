using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum CaseStatusType
    {
        [Display(Name = "New")]
        [Description("New status indicates that the case has been created but has not yet been assigned or worked on. This status is typically used for cases that are in the initial stages of the case management process and may require further triage or assignment before work can begin.")]
        New,
        [Display(Name = "Active")]
        [Description("Active status indicates that the case is currently being worked on. This status is used for cases that have been assigned and are in progress.")]
        Active,
        [Display(Name = "Resolved")]
        [Description("Resolved status indicates that the case has been addressed and a resolution has been provided. This status is used for cases that have been completed but may still require verification or follow-up.")]
        Resolved,
        [Display(Name = "Closed")]
        [Description("Closed status indicates that the case has been finalized and no further action is required. This status is used for cases that have been completed and verified.")]
        Closed,
        [Display(Name = "Canceled")]
        [Description("Canceled status indicates that the case has been terminated before completion. This status is used for cases that are no longer active and will not be resolved.")]
        Canceled,
        [Display(Name = "Unknown")]
        [Description("Unknown status indicates that the case status is not recognized or has not been set.")]
        Unknown
    }
