using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum StatusReasonType
    {
        [Display(Name = "None")]
        [Description("None status reason means that there is no specific reason associated with the current status. It indicates that the status is not accompanied by any additional information or explanation.")]
        None,
        [Display(Name = "Canceled")]
        [Description("Canceled status reason means that the status was canceled and provides the reason for the cancellation.")]
        Canceled,
        [Display(Name = "Failed")]
        [Description("Failed status reason means that the status indicates a failure and provides the reason for the failure.")]
        Failed,
        [Display(Name = "Success")]
        [Description("Success status reason means that the status indicates a successful outcome and provides the reason for the success.")]
        Success,
        [Display(Name = "Other")]
        [Description("Other status reason means that the status reason does not fall into any of the predefined categories and provides an alternative explanation.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown status reason means that the status reason is not specified or cannot be determined.")]
        Unknown
    }
}