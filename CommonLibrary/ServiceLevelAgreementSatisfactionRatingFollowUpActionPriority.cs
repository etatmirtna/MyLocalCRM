using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementSatisfactionRatingFollowUpActionPriority
    {
        [Display(Name = "Low")]
        [Description("Low priority indicates that the follow-up action is of lesser importance and can be addressed after higher priority actions have been completed. It may not require immediate attention and can be scheduled for a later time.")]
        Low,
        [Display(Name = "Normal")]
        [Description("Normal priority indicates that the follow-up action is of standard importance and should be addressed in a timely manner.")]
        Normal,
        [Display(Name = "High")]
        [Description("High priority indicates that the follow-up action is of significant importance and should be addressed as soon as possible.")]
        High,
        [Display(Name = "Urgent")]
        [Description("Urgent priority indicates that the follow-up action requires immediate attention and should be addressed without delay.")]
        Urgent,
        [Display(Name = "Critical")]
        [Description("Critical priority indicates that the follow-up action is of utmost importance and requires immediate attention to prevent severe consequences.")]
        Critical,
        [Display(Name = "Routine")]
        [Description("Routine priority indicates that the follow-up action is of standard importance and can be addressed in the normal course of business.")]
        Routine,
        [Display(Name = "Important")]
        [Description("Important priority indicates that the follow-up action is of significant importance and should be addressed promptly.")]
        Important,
        [Display(Name = "Time Sensitive")]
        [Description("Time Sensitive priority indicates that the follow-up action requires attention within a specific timeframe and should be addressed accordingly.")]
        TimeSensitive,
        [Display(Name = "Non Urgent")]
        [Description("Non Urgent priority indicates that the follow-up action does not require immediate attention and can be addressed at a later time.")]
        NonUrgent,
        [Display(Name = "Unknown")]
        [Description("Unknown priority indicates that the priority of the follow-up action is not specified or cannot be determined.")]
        Unknown
    }
