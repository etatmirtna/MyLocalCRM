using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum EmailStatusType
    {
        [Display(Name = "Draft")]
        [Description("Draft status indicates that the email is still being composed and has not yet been sent. It represents a work in progress that may require further editing, review, or approval before it can be sent to the intended recipients.")]
        Draft,
        [Display(Name = "Sent")]
        [Description("Sent status indicates that the email has been successfully sent to the intended recipients. It represents a completed communication that may require follow-up or tracking to ensure successful delivery and response.")]
        Sent,
        [Display(Name = "Received")]
        [Description("Received status indicates that the email has been successfully received by the recipient's email server. It represents a completed communication that may require attention or response from the recipient, but it does not necessarily indicate that the email has been read or acknowledged by the recipient.")]
        Received,
        [Display(Name = "Read")]
        [Description("Read status indicates that the email has been opened and viewed by the recipient. It represents a completed communication that has been acknowledged by the recipient, but it does not necessarily indicate that the recipient has taken any specific action in response to the email.")]
        Read,
        [Display(Name = "Unread")]
        [Description("Unread status indicates that the email has been received by the recipient but has not yet been opened or viewed. It represents a completed communication that may require attention or response from the recipient, but it has not yet been acknowledged or acted upon by the recipient.")]
        Unread,
        [Display(Name = "Replied")]
        [Description("Replied status indicates that the recipient has responded to the email by sending a reply message. It represents a completed communication that has been acknowledged and acted upon by the recipient, and it may require further follow-up or tracking to ensure successful resolution of any issues or requests raised in the original email.")]
        Replied,
        [Display(Name = "Replied All")]
        [Description("Replied All status indicates that the recipient has responded to the email by sending a reply message to all recipients of the original email. It represents a completed communication that has been acknowledged and acted upon by the recipient, and it may require further follow-up or tracking to ensure successful resolution of any issues or requests raised in the original email, as well as effective communication with all parties involved.")]
        Forwarded,
        [Display(Name = "Scheduled")]
        [Description("Scheduled status indicates that the email has been composed and is scheduled to be sent at a future date and time. It represents a planned communication that may require further editing, review, or approval before it can be sent to the intended recipients, and it may require tracking to ensure successful delivery and response when the scheduled time arrives.")]
        Scheduled,
        [Display(Name = "Canceled")]
        [Description("Canceled status indicates that the email was scheduled to be sent but has been canceled before it was sent. It represents a communication that will not be delivered to the intended recipients, and it may require follow-up or tracking to ensure that any necessary adjustments are made to the communication plan or schedule.")]
        Canceled,
        [Display(Name = "Failed")]
        [Description("Failed status indicates that an attempt was made to send the email, but it was not successfully delivered to the intended recipients. It represents a communication that may require troubleshooting or follow-up to identify and resolve any issues that prevented successful delivery, and it may require rescheduling or alternative communication methods to ensure that the intended message is effectively conveyed to the recipients.")]
        Failed,
        [Display(Name = "Deferred")]
        [Description("Deferred status indicates that the email has been temporarily delayed in the sending process, often due to issues with the recipient's email server or network connectivity. It represents a communication that may require monitoring and follow-up to ensure successful delivery once the underlying issues are resolved, and it may require rescheduling or alternative communication methods if the delay persists.")]
        Deferred,
        [Display(Name = "Waiting For Reply")]
        [Description("Waiting For Reply status indicates that the email has been sent and is awaiting a response from the recipient. It represents a communication that has been acknowledged by the recipient but has not yet received a reply, and it may require follow-up or tracking to ensure timely response and resolution of any issues or requests raised in the original email.")]
        WaitingForReply,
        [Display(Name = "Not Delivered")]
        [Description("Not Delivered status indicates that the email was not successfully delivered to the intended recipients, often due to issues with the recipient's email server, invalid email addresses, or other technical problems. It represents a communication that may require troubleshooting or follow-up to identify and resolve any issues that prevented successful delivery, and it may require rescheduling or alternative communication methods to ensure that the intended message is effectively conveyed to the recipients.")]
        NotDelivered,
        [Display(Name = "Delivered Elsewhere")]
        [Description("Delivered Elsewhere status indicates that the email was successfully delivered, but not to the intended recipient's primary email address. This may occur if the recipient has multiple email addresses or if there are forwarding rules in place. It represents a communication that has been acknowledged by the recipient but may require follow-up or tracking to ensure that the intended message is effectively conveyed to the correct email address and that any necessary adjustments are made to the communication plan or schedule.")]
        DeliveredElsewhere,
        [Display(Name = "Unknown")]
        [Description("Unknown status indicates that the current status of the email cannot be determined or is not applicable. It may require further investigation or information to determine the appropriate status for the email communication, and it may require monitoring or follow-up to ensure that any necessary actions are taken to resolve any issues or requests raised in the original email.")]
        Unknown
    }
}