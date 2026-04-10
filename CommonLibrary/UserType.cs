using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum UserType
    {
        [Display(Name = "Administrator")]
        [Description("Administrator type indicates that the user has full access to all system features and settings. This user can manage other users, configure system settings, and perform high-level administrative tasks.")]
        Admin,
        [Display(Name = "Standard User")]
        [Description("Standard User type indicates that the user has access to the system's standard features and functionalities. This user can perform regular tasks and operations but may have limited administrative privileges.")]
        Standard,
        [Display(Name = "Guest")]
        [Description("Guest type indicates that the user has limited access to the system's features and functionalities. This user may have restricted permissions and primarily access specific resources or information.")]
        Guest,
        [Display(Name = "External")]
        [Description("External type indicates that the user is an external entity with limited access to the system's features and functionalities. This user may have restricted permissions and primarily access specific resources or information.")]
        External,
        [Display(Name = "Internal")]
        [Description("Internal type indicates that the user is an internal entity with access to the system's features and functionalities. This user may have standard permissions and primarily access resources or information relevant to their role within the organization.")]
        Internal,
        [Display(Name = "Power User")]
        [Description("Power User type indicates that the user has elevated access to the system's features and functionalities. This user can perform advanced tasks and operations, often with additional privileges compared to standard users.")]
        PowerUser,
        [Display(Name = "Read Only")]
        [Description("Read Only type indicates that the user has limited access to the system's features and functionalities. This user can view information but cannot make changes or perform administrative tasks.")]
        ReadOnly,
        [Display(Name = "System")]
        [Description("System type indicates that the user is a system account with special privileges and access to system-level functionalities. This user is typically used for automated processes, integrations, or system maintenance tasks.")]
        System,
        [Display(Name = "Service Account")]
        [Description("Service Account type indicates that the user is a service account with specific privileges and access to system functionalities. This user is typically used for automated processes, integrations, or system maintenance tasks.")]
        ServiceAccount,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the user's type is not specified or recognized. This user may have undefined or limited access to the system's features and functionalities.")]
        Unknown
    }
}