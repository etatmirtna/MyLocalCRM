using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum BusinessProcessFlowStageCategory
    {
        [Display(Name = "Qualify")]
        [Description("Qualify stage category means that the stage is focused on qualifying the opportunity or lead.")]
        Qualify,
        [Display(Name = "Develop")]
        [Description("Develop stage category means that the stage is focused on developing the opportunity or lead.")]
        Develop,
        [Display(Name = "Propose")]
        [Description("Propose stage category means that the stage is focused on proposing solutions or offers to the opportunity or lead.")]
        Propose,
        [Display(Name = "Close")]
        [Description("Close stage category means that the stage is focused on closing the opportunity or lead.")]
        Close,
        [Display(Name = "Other")]
        [Description("Other stage category means that the stage does not fall into any of the predefined categories and provides an alternative explanation.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown stage category means that the stage category is not specified or cannot be determined.")]
        Unknown
    }
