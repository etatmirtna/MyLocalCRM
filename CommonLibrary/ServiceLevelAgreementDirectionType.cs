using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementDirectionType
    {
        [Display(Name = "Inbound")]
        [Description("Inbound service level agreement indicates that the agreement is directed towards incoming requests.")]
        Inbound,
        [Display(Name = "Outbound")]
        [Description("Outbound service level agreement indicates that the agreement is directed towards outgoing requests.")]
        Outbound,
        [Display(Name = "Internal")]
        [Description("Internal service level agreement indicates that the agreement is directed towards internal requests.")]
        Internal,
        [Display(Name = "External")]
        [Description("External service level agreement indicates that the agreement is directed towards external requests.")]
        External,
        [Display(Name = "Unknown")]
        [Description("Unknown service level agreement indicates that the direction of the agreement is not specified or cannot be determined.")]
        Unknown
    }
}