using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum CasePriorityType
    {
        [Display(Name = "Low")]
        [Description("Low priority indicates that the case is not urgent and can be addressed at a later time without significant impact on the customer or business. This priority level is typically assigned to cases that do not require immediate attention and can be resolved within a reasonable timeframe.")]
        Low,
        [Display(Name = "Normal")]
        [Description("Normal priority indicates that the case should be addressed in a timely manner, but it is not critical. This priority level is typically assigned to cases that require attention within a standard response time.")]
        Normal,
        [Display(Name = "High")]
        [Description("High priority indicates that the case is important and should be addressed as soon as possible. This priority level is typically assigned to cases that have a significant impact on the customer or business and require prompt attention.")]
        High,
        [Display(Name = "Urgent")]
        [Description("Urgent priority indicates that the case requires immediate attention and action. This priority level is typically assigned to cases that have a critical impact on the customer or business and must be resolved as quickly as possible.")]
        Urgent,
        [Display(Name = "Critical")]
        [Description("Critical priority indicates that the case is of the highest importance and requires immediate action. This priority level is typically assigned to cases that have a severe impact on the customer or business and must be resolved without delay.")]
        Critical,
        [Display(Name = "Routine")]
        [Description("Routine priority indicates that the case is of standard importance and can be addressed in the normal course of business.")]
        Routine,
        [Display(Name = "Important")]
        [Description("Important priority indicates that the case is of significant importance and should be addressed promptly.")]
        Important,
        [Display(Name = "Time Sensitive")]
        [Description("Time Sensitive priority indicates that the case requires attention within a specific timeframe to prevent negative impact.")]
        TimeSensitive,
        [Display(Name = "Non Urgent")]
        [Description("Non Urgent priority indicates that the case does not require immediate attention and can be addressed at a later time without significant impact.")]
        NonUrgent,
        [Display(Name = "Unknown")]
        [Description("Unknown priority indicates that the priority of the case is not specified or cannot be determined.")]
        Unknown
    }
}