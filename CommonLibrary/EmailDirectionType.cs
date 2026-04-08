using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum EmailDirectionType
    {
        [Display(Name = "Incoming")]
        [Description("Incoming indicates that the email was received by the recipient from an external source. It represents communication initiated by someone outside of the organization and may require attention or response from the recipient.")]
        Incoming,
        [Display(Name = "Outgoing")]
        [Description("Outgoing indicates that the email was sent by the sender to an external recipient. It represents communication initiated by someone within the organization and may require follow-up or tracking to ensure successful delivery and response.")]
        Outgoing,
        [Display(Name = "Internal")]
        [Description("Internal indicates that the email was sent and received within the same organization. It represents communication between individuals or teams within the organization and may require coordination or collaboration to achieve shared goals.")]
        Internal,
        [Display(Name = "External")]
        [Description("External indicates that the email was sent or received from an external source outside of the organization. It represents communication that may involve customers, partners, vendors, or other stakeholders and may require careful management to maintain relationships and ensure effective communication.")]
        External,
        [Display(Name = "Unknown")]
        [Description("Unknown indicates that the direction of the email has not been determined or is not applicable. It may require further assessment or information to determine the appropriate classification for the email communication.")]
        Unknown
    }
