using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum EmailPriorityType
    {
        [Display(Name = "Low")]
        [Description("Low priority indicates that the email can be addressed after higher priority emails have been resolved. It may not require immediate attention and can be scheduled for response at a later time.")]
        Low,
        [Display(Name = "Normal")]
        [Description("Normal priority indicates that the email should be addressed in a timely manner, but it does not require immediate attention. It represents standard communication that may require a response within a reasonable timeframe.")]
        Normal,
        [Display(Name = "High")]
        [Description("High priority indicates that the email requires prompt attention and should be addressed as soon as possible. It represents communication that may have a significant impact on business operations, customer satisfaction, or other critical factors and may require immediate action to resolve.")]
        High,
        [Display(Name = "Urgent")]
        [Description("Urgent priority indicates that the email requires immediate attention and should be addressed without delay. It represents communication that may have a critical impact on business operations, customer satisfaction, or other time-sensitive factors and may require urgent action to resolve.")]
        Urgent,
        [Display(Name = "Critical")]
        [Description("Critical priority indicates that the email requires immediate attention and should be addressed as a top priority. It represents communication that may have a severe impact on business operations, customer satisfaction, or other critical factors and may require immediate and decisive action to resolve.")]
        Critical,
        [Display(Name = "Routine")]
        [Description("Routine priority indicates that the email can be addressed in the normal course of business and does not require immediate attention. It represents standard communication that may not have a significant impact on business operations or customer satisfaction and can be scheduled for response at a later time.")]
        Routine,
        [Display(Name = "Important")]
        [Description("Important priority indicates that the email requires attention and should be addressed in a timely manner. It represents communication that may have a significant impact on business operations, customer satisfaction, or other important factors and may require prompt action to resolve.")]
        Important,
        [Display(Name = "Time Sensitive")]
        [Description("Time Sensitive priority indicates that the email requires attention within a specific timeframe and should be addressed as soon as possible. It represents communication that may have a significant impact on business operations, customer satisfaction, or other time-sensitive factors and may require timely action to resolve.")]
        TimeSensitive,
        [Display(Name = "NonUrgent")]
        [Description("Non Urgent priority indicates that the email does not require immediate attention and can be addressed after higher priority emails have been resolved. It represents communication that may not have a significant impact on business operations or customer satisfaction and can be scheduled for response at a later time.")]
        NonUrgent,
        [Display(Name = "Unknown")]
        [Description("Unknown priority indicates that the priority of the email has not been determined or is not applicable. It may require further assessment or information to determine the appropriate level of urgency for addressing the email communication.")]
        Unknown
    }
