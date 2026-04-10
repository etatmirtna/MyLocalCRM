using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum BusinessProcessFlowStageStatus
    {
        [Display(Name = "Not Started")]
        [Description("Not Started status means that the stage has not yet begun.")]
        NotStarted,
        [Display(Name = "In Progress")]
        [Description("In Progress status means that the stage is currently in progress.")]
        InProgress,
        [Display(Name = "Completed")]
        [Description("Completed status means that the stage has been finished successfully.")]
        Completed,
        [Display(Name = "Canceled")]
        [Description("Canceled status means that the stage has been canceled.")]
        Canceled,
        [Display(Name = "Unknown")]
        [Description("Unknown status means that the stage status is not specified or cannot be determined.")]
        Unknown
    }
}
