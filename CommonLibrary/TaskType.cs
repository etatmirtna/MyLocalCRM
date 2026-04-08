using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum TaskType
    {
        [Display(Name = "To Do")]
        [Description("A task that needs to be done.")]
        ToDo,
        [Display(Name = "In Progress")]
        [Description("A task that is currently in progress.")]
        InProgress,
        [Display(Name = "Completed")]
        [Description("A task that has been completed.")]
        Completed,
        [Display(Name = "Canceled")]
        [Description("A task that has been canceled.")]
        Canceled,
        [Display(Name = "Deferred")]
        [Description("A task that has been deferred.")]
        Deferred,
        [Display(Name = "Waiting For Someone Else")]
        [Description("A task that is waiting for someone else.")]
        WaitingForSomeoneElse,
        [Display(Name = "Waiting For Something")]
        [Description("A task that is waiting for something.")]
        WaitingForSomething,
        [Display(Name = "Not Started")]
        [Description("A task that has not been started.")]
        NotStarted,
        [Display(Name = "Unknown")]
        [Description("A task with an unknown status.")]
        Unknown
    }
