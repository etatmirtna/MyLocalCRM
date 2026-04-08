using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementPriority
    {
        [Display(Name = "Low")]
        [Description("Low priority indicates that the issue can be addressed after higher priority issues have been resolved. It may not require immediate attention and can be scheduled for resolution at a later time.")]
        Low,
        [Display(Name = "Normal")]
        [Description("Normal priority indicates that the issue should be addressed in a timely manner, but it is not critical. It may require attention within a reasonable timeframe, but it does not require immediate action.")]
        Normal,
        [Display(Name = "High")]
        [Description("High priority indicates that the issue is important and should be addressed as soon as possible. It may have a significant impact on the business or customer experience, and it requires immediate attention to prevent further issues or damage.")]
        High,
        [Display(Name = "Urgent")]
        [Description("Urgent priority indicates that the issue is critical and requires immediate attention. It may have a severe impact on the business or customer experience, and it requires immediate action to prevent further issues or damage.")]
        Urgent,
        [Display(Name = "Critical")]
        [Description("Critical priority indicates that the issue is of utmost importance and requires immediate attention. It may have a catastrophic impact on the business or customer experience, and it requires immediate action to prevent further issues or damage.")]
        Critical,
        [Display(Name = "Routine")]
        [Description("Routine priority indicates that the issue is of low importance and can be addressed at a later time. It may not have a significant impact on the business or customer experience, and it does not require immediate attention.")]
        Routine,
        [Display(Name = "Important")]
        [Description("Important priority indicates that the issue is significant and should be addressed in a timely manner. It may have a moderate impact on the business or customer experience, and it requires attention within a reasonable timeframe to prevent further issues or damage.")]
        Important,
        [Display(Name = "Time Sensitive")]
        [Description("Time Sensitive priority indicates that the issue is important and requires attention within a specific timeframe. It may have a significant impact on the business or customer experience if not addressed within the specified timeframe, and it requires timely action to prevent further issues or damage.")]
        TimeSensitive,
        [Display(Name = "Non Urgent")]
        [Description("Non Urgent priority indicates that the issue is of low importance and does not require immediate attention. It may have a minimal impact on the business or customer experience, and it can be addressed at a later time without significant consequences.")] 
        NonUrgent,
        [Display(Name = "Unknown")]
        [Description("Unknown priority indicates that the priority level of the issue has not been determined or is not applicable. It may require further assessment or information to determine the appropriate priority level for resolution.")]
        Unknown
    }
