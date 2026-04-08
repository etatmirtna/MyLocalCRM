using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum StatusType
    {
        [Display(Name = "Active")]
        [Description("Active type indicates that the status of the record is currently active and in use. This status may indicate that the record is valid, operational, and can be interacted with or utilized within the system. Active records may be subject to regular updates, maintenance, and monitoring to ensure their continued functionality and relevance.")]
        Active,
        [Display(Name = "Inactive")]
                [Description("Inactive type indicates that the status of the record is currently inactive and not in use. This status may indicate that the record is no longer valid, operational, or relevant within the system. Inactive records may be archived, retained for historical purposes, or subject to limited access and interaction.")]
        Inactive,
        [Display(Name = "Pending")]
        [Description("Pending type indicates that the status of the record is currently pending and awaiting further action or approval. This status may indicate that the record is in a transitional state, requiring additional information, review, or processing before it can be finalized or moved to another status.")]
        Pending,
        [Display(Name = "Completed")]
        [Description("Completed type indicates that the status of the record has been finalized and all necessary actions have been taken. This status may indicate that the record is no longer active but has reached a conclusion or resolution.")]
        Completed,
        [Display(Name = "Canceled")]
        [Description("Canceled type indicates that the status of the record has been canceled and will not proceed further. This status may indicate that the record is no longer valid, operational, or relevant within the system.")] 
        Canceled,
        [Display(Name = "On Hold")]
        [Description("On Hold type indicates that the status of the record is temporarily paused or suspended. This status may indicate that the record requires further review, additional information, or pending actions before it can proceed.")]
        OnHold,
        [Display(Name = "Deleted")]
        [Description("Deleted type indicates that the status of the record has been removed or marked for deletion. This status may indicate that the record is no longer active, relevant, or accessible within the system.")]
        Deleted,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the status of the record is not known or has not been specified. This status may be used as a default or placeholder value when the actual status is unclear or unavailable.")]
        Unknown
    }
