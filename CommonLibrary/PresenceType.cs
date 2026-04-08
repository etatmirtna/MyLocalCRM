using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum PresenceType
    {
        [Display(Name = "Available")]
        [Description("Available presence type indicates that the user is currently available and can be contacted or engaged with. This presence status may indicate that the user is actively using the system, is responsive to communication, and can participate in activities or interactions within the system.")]
        Available,
        [Display(Name = "Busy")]
        [Description("Busy presence type indicates that the user is currently occupied and may not be available for immediate interaction. This presence status may indicate that the user is engaged in a task, meeting, or other activity that requires their attention and focus.")]
        Busy,
        [Display(Name = "Away")]
        [Description("Away presence type indicates that the user is currently away and may not be immediately available for interaction. This presence status may indicate that the user is temporarily unavailable, on a break, or not actively using the system.")]
        Away,
        [Display(Name = "Do Not Disturb")]
        [Description("Do Not Disturb presence type indicates that the user does not want to be disturbed and may not respond to communication or interaction requests. This presence status may indicate that the user is focusing on a task, in a meeting, or otherwise unavailable for interaction.")]    
        DoNotDisturb,
        [Display(Name = "Offline")]
        [Description("Offline presence type indicates that the user is not currently available or connected to the system. This presence status may indicate that the user is not actively using the system, is not responsive to communication, and cannot participate in activities or interactions within the system.")]
        Offline,
        [Display(Name = "Unknown")]
        [Description("Unknown presence type indicates that the user's presence status is not specified or recognized. This presence status may indicate that the user's availability is undefined or cannot be determined.")]
        Unknown
    }
