using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace CommonLibrary
{
    public enum StatusType
    {
        [Display(Name = "Active")]
        [Description("Active status means that the reference is Active and is not inactive, canceled or completed. An active reference is one that is currently in use or valid within the system. It indicates that the reference is currently being utilized or is available for use in the context of the application or system.")]
        Active,
        [Display(Name = "Inactive")]
        [Description("Inactive status means that the reference is not currently active or in use. It indicates that the reference is temporarily or permanently unavailable for use within the system.")]
        Inactive,
        [Display(Name = "Pending")]
        [Description("Pending status means that the reference is awaiting action or approval. It indicates that the reference is in a temporary state and requires further processing or decision-making before it can be considered active or completed.")]
        Pending,
        [Display(Name = "Completed")]
        [Description("Completed status means that the reference has been successfully completed and is no longer active.")]
        Completed,
        [Display(Name = "Canceled")]
        [Description("Canceled status means that the reference has been canceled and is no longer active.")]
        Canceled,
        [Display(Name = "Unknown")]
        [Description("Unknown status means that the reference status is not specified or cannot be determined.")]
        Unknown
    }
}