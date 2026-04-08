using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum TaskStatus
    {
        [Display(Name = "Not Started")]
        [Description("Task has not been started yet.")]
        NotStarted,
        [Display(Name = "In Progress")]
        [Description("Task is currently in progress.")]
        InProgress,
        [Display(Name = "Completed")]
        [Description("Task has been completed.")]
        Completed,
        [Display(Name = "Canceled")]
        [Description("Task has been canceled.")]
        Canceled,  
        [Display(Name = "Deferred")]
        [Description("Task has been deferred.")]    
        Deferred,
        [Display(Name = "Waiting For Someone Else")]
        [Description("Task is waiting for someone else.")]
        WaitingForSomeoneElse,
        [Display(Name = "Waiting For Something")]
        [Description("Task is waiting for something.")]
        WaitingForSomething,
        [Display(Name = "Unknown")]
        [Description("Task has an unknown status.")]
        Unknown
    }
