using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum StateType
    {
        [Display(Name = "Active")]
        [Description("Active state indicates that the entity is currently active and operational.")]
        Active,
        [Display(Name = "Inactive")]
        [Description("Inactive state indicates that the entity is currently inactive and not operational.")]
        Inactive,
        [Display(Name = "Draft")]
        [Description("Draft state indicates that the entity is in a preliminary or draft stage and is not yet finalized.")]
        Draft,
        [Display(Name = "Submitted")]
        [Description("Submitted state indicates that the entity has been submitted for review or approval.")]
        Submitted,
        [Display(Name = "Approved")]
        [Description("Approved state indicates that the entity has been approved after review.")]
        Approved,
        [Display(Name = "Rejected")]
        [Description("Rejected state indicates that the entity has been rejected after review.")]
        Rejected,
        [Display(Name = "Completed")]
        [Description("Completed state indicates that the entity has been successfully completed and is no longer active.")]
        Completed,
        [Display(Name = "Canceled")]
        [Description("Canceled state indicates that the entity has been canceled and is no longer active.")]
        Canceled,
        [Display(Name = "Unknown")]
        [Description("Unknown state indicates that the entity's state is not specified or cannot be determined.")]
        Unknown
    }
