using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum StateReasonType
    {
        [Display(Name = "None")]
        [Description("Indicates that there is no specific reason for the current state.")]
        [Category("General")]
        None,
        [Display(Name = "Canceled")]
        [Description("Indicates that the record was canceled, either by the user or by the system.")]
        [Category("General")]
        Canceled,
        [Display(Name = "Failed")]
        [Description("Indicates that the record failed to complete its intended process, either due to an error or because of a business rule violation.")]
        [Category("General")]
        Failed,
        [Display(Name = "Success")]
        [Description("Indicates that the record successfully completed its intended process.")]
        [Category("General")]
        Success,
        [Display(Name = "Other")]
        [Description("Indicates that there is a reason for the current state that does not fit into the other categories.")]
        [Category("Other")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Indicates that the reason for the current state is unknown or unspecified.")]
        [Category("Other")]
        Unknown
    }
