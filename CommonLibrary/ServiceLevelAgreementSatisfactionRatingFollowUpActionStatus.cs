using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementSatisfactionRatingFollowUpActionStatus
    {
        [Display(Name = "Not Started")]
        [Description("Not Started status indicates that the follow-up action has not yet been initiated.")]
        NotStarted,
        [Display(Name = "In Progress")]
        [Description("In Progress status indicates that the follow-up action is currently being worked on.")]
        InProgress,
        [Display(Name = "Completed")]
        [Description("Completed status indicates that the follow-up action has been finished.")]
        Completed,
        [Display(Name = "Canceled")]
        [Description("Canceled status indicates that the follow-up action has been terminated before completion.")]
        Canceled,
        [Display(Name = "Deferred")]
        [Description("Deferred status indicates that the follow-up action has been postponed to a later time.")]
        Deferred,
        [Display(Name = "Waiting For Someone Else")]
        [Description("Waiting For Someone Else status indicates that the follow-up action is pending due to dependency on another person.")]
        WaitingForSomeoneElse,
        [Display(Name = "Waiting For Something")]
        [Description("Waiting For Something status indicates that the follow-up action is pending due to dependency on an external factor or event.")]
        WaitingForSomething,
        [Display(Name = "Unknown")]
        [Description("Unknown status indicates that the status of the follow-up action is not specified or cannot be determined.")]
        Unknown
    }
