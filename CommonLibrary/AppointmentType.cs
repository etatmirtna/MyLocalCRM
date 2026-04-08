using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum AppointmentType
    {
        [Display(Name = "Scheduled")]
        [Description("Scheduled type indicates that the appointment is planned and set for a specific date and time. This appointment may involve a meeting, event, or other scheduled activity that requires coordination and preparation to ensure its successful execution. Scheduled appointments may require confirmation, reminders, and follow-up to ensure attendance and participation.")]
        Scheduled,
        [Display(Name = "Completed")]
        [Description("Completed type indicates that the appointment has been successfully conducted and concluded. This appointment may have involved a meeting, event, or other scheduled activity that was executed as planned, and all necessary actions or discussions have been completed.")]
        Completed,
        [Display(Name = "Canceled")]
        [Description("Canceled type indicates that the appointment has been canceled and will not take place as originally planned. This appointment may have been canceled due to various reasons, such as scheduling conflicts, changes in priorities, or other unforeseen circumstances.")]
        Canceled,
        [Display(Name = "Unscheduled")]
        [Description("Unscheduled type indicates that the appointment has not been scheduled or planned. This appointment may require further action to determine a suitable date and time, and may involve coordination with participants to finalize the details.")]
        Unscheduled,
        [Display(Name = "Rescheduled")]
        [Description("Rescheduled type indicates that the appointment has been moved to a different date and/or time. This appointment may have been rescheduled due to conflicts, changes in priorities, or other reasons, and requires participants to adjust their schedules accordingly.")] 
        Rescheduled,
        [Display(Name = "Recurring")]
        [Description("Recurring type indicates that the appointment occurs repeatedly at regular intervals. This appointment may be part of a series of meetings, events, or other scheduled activities that follow a consistent pattern, allowing participants to plan and manage their time effectively.")]
        Recurring
    }
