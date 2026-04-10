using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum PhoneCallPriorityType
    {
        [Display(Name = "Low")]
        [Description("Low priority indicates that the phone call is of lesser importance or urgency compared to other calls. It may involve communication that can be addressed at a later time without significant consequences or impact on business operations.")]
        Low,
        [Display(Name = "Normal")]
        [Description("Normal priority indicates that the phone call has a standard level of importance or urgency. It may involve communication that should be addressed in a timely manner but does not require immediate attention.")]
        Normal,
        [Display(Name = "High")]
        [Description("High priority indicates that the phone call is of significant importance or urgency. It may involve communication that requires prompt attention and action to address critical matters or time-sensitive issues.")]
        High,
        [Display(Name = "Urgent")]
        [Description("Urgent priority indicates that the phone call requires immediate attention and action. It may involve critical matters or time-sensitive issues that need to be addressed without delay.")]
        Urgent,
        [Display(Name = "Critical")]
        [Description("Critical priority indicates that the phone call is of utmost importance and requires immediate and decisive action. It may involve situations that have significant consequences or impact on business operations if not addressed promptly.")]
        Critical,
        [Display(Name = "Routine")]
        [Description("Routine priority indicates that the phone call is of standard importance and can be addressed in the normal course of business. It may involve communication that does not require immediate attention or action.")]
        Routine,
        [Display(Name = "Important")]
        [Description("Important priority indicates that the phone call is of significant importance and should be addressed promptly. It may involve communication that requires attention to ensure critical matters are handled effectively.")]
        Important,
        [Display(Name = "Time Sensitive")]
        [Description("Time Sensitive priority indicates that the phone call is of high importance and requires timely attention. It may involve communication that has specific deadlines or time constraints that need to be met to ensure successful outcomes.")]
        TimeSensitive,
        [Display(Name = "Non Urgent")]
        [Description("Non Urgent priority indicates that the phone call is of low importance and does not require immediate attention. It may involve communication that can be addressed at a later time without significant consequences or impact on business operations.")]
        NonUrgent,
        [Display(Name = "Unknown")]
        [Description("Unknown priority indicates that the priority of the phone call is not specified or cannot be determined. It may involve communication that requires further assessment to determine the appropriate level of urgency or importance.")]
        Unknown
    }
}