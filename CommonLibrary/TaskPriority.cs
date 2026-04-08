using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum TaskPriority
    {
        [Display(Name = "Low")]
        [Description("A task with low priority.")]
        Low,
        [Display(Name = "Normal")]
        [Description("A task with normal priority.")]
        Normal,
        [Display(Name = "High")]
        [Description("A task with high priority.")]
        High,
        [Display(Name = "Urgent")]
        [Description("A task that requires immediate attention.")]
        Urgent,
        [Display(Name = "Critical")]
        [Description("A task that is critical.")]
        Critical,
        [Display(Name = "Routine")]
        [Description("A task that is routine.")]
        Routine,
        [Display(Name = "Important")]
        [Description("A task that is important.")]
        Important,
        [Display(Name = "Time Sensitive")]
        [Description("A task that is time sensitive.")]
        TimeSensitive,
        [Display(Name = "Non Urgent")]
        [Description("A task that is not urgent.")]
        NonUrgent,
        [Display(Name = "Unknown")]
        [Description("A task with an unknown priority.")]
        Unknown
    }
