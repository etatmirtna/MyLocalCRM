using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum PhoneCallStatusType
    {
        [Display(Name = "Scheduled")]
        [Description("Scheduled status indicates that the phone call is planned or arranged for a specific date and time. It may involve communication that is intended to occur in the future, such as appointments, meetings, or follow-ups that have been scheduled in advance.")]
        Scheduled,
        [Display(Name = "Completed")]
        [Description("Completed status indicates that the phone call has been successfully conducted and concluded.")]
        Completed,
        [Display(Name = "Canceled")]
        [Description("Canceled status indicates that the phone call has been canceled and will not take place as scheduled.")]
        Canceled,
        [Display(Name = "No Show")]
        [Description("No Show status indicates that the phone call was not attended by the recipient.")]
        NoShow,
        [Display(Name = "Rescheduled")]
        [Description("Rescheduled status indicates that the phone call has been rescheduled to a different date or time.")]
        Rescheduled,
        [Display(Name = "In Progress")]
        [Description("In Progress status indicates that the phone call is currently ongoing.")]
        InProgress,
        [Display(Name = "Postponed")]
        [Description("Postponed status indicates that the phone call has been temporarily delayed and will be conducted at a later time.")]
        Postponed,
        [Display(Name = "Deferred")]
        [Description("Deferred status indicates that the phone call has been postponed to a later time or date.")]
        Deferred,
        [Display(Name = "Waiting For Callback")]
        [Description("Waiting For Callback status indicates that the phone call is pending a return call from the recipient.")]
        WaitingForCallback,
        [Display(Name = "Left Voicemai")]
        [Description("Left Voicemail status indicates that the phone call was not answered and a voicemail message was left for the recipient.")]
        LeftVoicemail,
        [Display(Name = "Not Answered")]
        [Description("Not Answered status indicates that the phone call was not answered by the recipient.")]
        NotAnswered,
        [Display(Name = "Answered Elsewhere")]
        [Description("Answered Elsewhere status indicates that the phone call was answered by the recipient, but not at the expected location or device. It may involve communication that was received on a different phone, extension, or location than originally intended.")]
        AnsweredElsewhere,
        [Display(Name = "Unknown")]
        [Description("Unknown status indicates that the phone call status is not specified or cannot be determined.")]
        Unknown
    }
}