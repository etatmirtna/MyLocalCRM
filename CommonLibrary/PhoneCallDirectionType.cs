using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum PhoneCallDirectionType
    {
        [Display(Name = "Incoming")]
        [Description("Incoming direction indicates that the phone call is received by the recipient from an external source. It may involve communication initiated by customers, clients, or other external parties reaching out to the recipient for various purposes, such as inquiries, support requests, or business opportunities.")]
        Incoming,
        [Display(Name = "Outgoing")]
        [Description("Outgoing direction indicates that the phone call is initiated by the recipient and directed towards an external party. It may involve communication for various purposes, such as making inquiries, providing information, or conducting business activities.")]
        Outgoing,
        [Display(Name = "Missed")]
        [Description("Missed direction indicates that the phone call was not answered by the recipient.")]
        Missed,
        [Display(Name = "Voicemail")]
        [Description("Voicemail direction indicates that the phone call was directed to voicemail.")]
        Voicemail,
        [Display(Name = "Callback")]
        [Description("Callback direction indicates that the phone call is a return call to a previously missed or unanswered call.")]
        Callback,
        [Display(Name = "Forwarded")]
        [Description("Forwarded direction indicates that the phone call was redirected to another recipient.")]
        Forwarded,
        [Display(Name = "Conference")]
        [Description("Conference direction indicates that the phone call is part of a conference call involving multiple participants.")]
        Conference,
        [Display(Name = "Internal")]
        [Description("Internal direction indicates that the phone call is within the organization.")]
        Internal,
        [Display(Name = "External")]
        [Description("External direction indicates that the phone call is directed towards an external party.")]
        External,
        [Display(Name = "Unknown")]
        [Description("Unknown direction indicates that the phone call direction is not specified or cannot be determined.")]
        Unknown
    }
