using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum  CalendarEventType
    {
        [Display(Name = "Virtual Meeting")]
        [Description("An event that takes place online, such as a video conference or webinar.")]
        VirtualMeeting,
        [Display(Name = "In-Person Meeting")]
        [Description("An event that takes place in a physical location, such as a conference room or office.")]
        InPersonMeeting,
        [Display(Name = "Phone Call")]
        [Description("A scheduled phone conversation between participants.")]
        PhoneCall,
        [Display(Name = "Email")]
        [Description("An electronic message sent between participants.")]
        Email,
        [Display(Name = "Chat")]
        [Description("A real-time text-based conversation between participants.")]
        Chat,
        [Display(Name = "Fax")]
        [Description("A document sent via facsimile.")]
        Fax,
        [Display(Name = "General Appointment")]
        [Description("A general appointment that does not fall into other specific categories.")]
        GeneralAppointment,
        [Display(Name = "Holiday")]
        [Description("A public or private holiday.")]
        Holiday,
        [Display(Name = "Internal Event")]
        [Description("An event that is internal to the organization.")]
        InternalEvent,
        [Display(Name = "External Event")]
        [Description("An event that is external to the organization.")] 
        ExternalEvent,
        [Display(Name = "Follow Up")]
        [Description("A follow-up event to a previous meeting or interaction.")]
        FollowUp,
        [Display(Name = "Training")]
        [Description("An event focused on skill development or knowledge enhancement.")]
        Training,
        [Display(Name = "Conference")]
        [Description("A formal meeting for discussion, typically involving multiple participants.")]
        Conference,
        [Display(Name = "Development")]
        [Description("An event focused on personal or professional development.")]
        Development,
        [Display(Name = "Personal")]
        [Description("An event focused on personal matters or activities.")]
        Personal,
        [Display(Name = "Vendor Meeting")]
        [Description("A meeting with a vendor or supplier.")]
        VendorMeeting,  
        [Display(Name = "Team Building")]
        [Description("An event focused on team building activities.")]
        TeamBuilding,
        [Display(Name = "Mentoring")]
        [Description("An event focused on mentoring activities.")]
        Mentoring,
        [Display(Name = "Networking")]
        [Description("An event focused on networking activities.")]
        Networking,
        [Display(Name = "Zoom Meeting")]
        [Description("A meeting conducted via Zoom.")]
        ZoomMeeting,
        [Display(Name = "Webinar")]
        [Description("A seminar conducted over the internet.")]
        Webinar,
        [Display(Name = "Workshop")]
        [Description("A hands-on training session or interactive event.")]
        Workshop,
        [Display(Name = "Sales Call")]
        [Description("A scheduled call focused on sales activities.")]
        SalesCall,
        [Display(Name = "Support Call")]
        [Description("A scheduled call focused on support activities.")]
        SupportCall,
        [Display(Name = "Project Meeting")]
        [Description("A meeting focused on project-related discussions.")]
        ProjectMeeting,
        [Display(Name = "Performance Review")]
        [Description("A review meeting focused on evaluating performance.")]
        PerformanceReview,
        [Display(Name = "One-on-One")]
        [Description("A meeting between two individuals for discussion or feedback.")]
        OneOnOne,
        [Display(Name = "Company Event")]
        [Description("An event organized by the company for employees or stakeholders.")]
        CompanyEvent,
        [Display(Name = "Social Event")]
        [Description("An event focused on social activities.")]
        SocialEvent,
        [Display(Name = "YouTube Event")]
        [Description("An event focused on YouTube-related activities.")]
        YoutubeEvent,
        [Display(Name = "Affiliate Event")]
        [Description("An event focused on affiliate-related activities.")]
        AffiliateEvent,
        [Display(Name = "Agency Event")]
        [Description("An event focused on agency-related activities.")]
        AgencyEvent,
        [Display(Name = "All Day Event")]
        [Description("An event that lasts for the entire day.")]
        AllDayEvent,
        [Display(Name = "Anniversary")]
        [Description("An event celebrating an anniversary.")]
        Anniversary,
        [Display(Name = "Award Ceremony")]
        [Description("An event recognizing achievements or presenting awards.")]
        AwardCeremony,
        [Display(Name = "Auction")]
        [Description("An event where items are sold to the highest bidder.")]
        Auction,
        [Display(Name = "Art Exhibition")]
        [Description("An event showcasing artistic works.")]
        ArtExhibition,
        [Display(Name = "Birthday")]
        [Description("An event celebrating a birthday.")]
        Birthday,
        [Display(Name = "Other")]
        [Description("An event that does not fit into any other category.")]
        Other,
        [Display(Name = "Unknown Event")]
        [Description("An event with an unknown type.")]
        UnknownEvent
    }
}