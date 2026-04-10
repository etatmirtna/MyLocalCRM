using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum PhoneCallType
    {
        [Display(Name = "Information")]
        [Description("Information type indicates that the phone call is intended to convey general information or updates to the recipient. It may include news, announcements, or other non-urgent communication that does not require immediate action from the recipient.")]
        Info,
        [Display(Name = "Sales")]
        [Description("Sales type indicates that the phone call is related to sales activities, such as discussing products or services, negotiating deals, or closing sales.")]
        Sales,
        [Display(Name = "Support")]
        [Description("Support type indicates that the phone call is related to providing assistance or resolving issues for customers or clients. It may involve troubleshooting, answering questions, or offering guidance.")]
        Support,
        [Display(Name = "Other")]
        [Description("Other type indicates that the phone call does not fall into any specific category. It may involve miscellaneous or undefined communication.")]
        Other,
        [Display(Name = "Competitor")]
        [Description("Competitor type indicates that the phone call is related to competitor activities, such as gathering intelligence or discussing competitive strategies.")]
        Competitor,
        [Display(Name = "Follow Up")]
        [Description("Follow Up type indicates that the phone call is intended to follow up on previous interactions, meetings, or communications.")]
        FollowUp,
        [Display(Name = "Prospecting")]
        [Description("Prospecting type indicates that the phone call is intended to identify and qualify potential customers or clients.")]
        Prospecting,
        [Display(Name = "Qualifying")]
        [Description("Qualifying type indicates that the phone call is intended to assess the suitability or readiness of a potential customer or client.")]
        Qualifying,
        [Display(Name = "Closing")]
        [Description("Closing type indicates that the phone call is intended to finalize a deal or agreement with a customer or client.")]
        Closing,
        [Display(Name = "Post Sale")]
        [Description("Post Sale type indicates that the phone call is related to activities that occur after a sale has been completed, such as follow-up, support, or customer satisfaction inquiries.")]
        PostSale,
        [Display(Name = "Internal")]
        [Description("Internal type indicates that the phone call is related to internal company matters, such as team meetings, internal updates, or other internal communications.")]
        Internal,
        [Display(Name = "External")]
        [Description("External type indicates that the phone call is related to external matters, such as communication with clients, partners, or other external stakeholders.")]
        External,
        [Display(Name = "Training")]
        [Description("Training type indicates that the phone call is related to training activities, such as conducting or attending training sessions, workshops, or educational programs.")]
        Training,
        [Display(Name = "Conference")]
        [Description("Conference type indicates that the phone call is related to conferences, such as attending or organizing conferences, seminars, or industry events.")]
        Conference,
        [Display(Name = "Networking")]
        [Description("Networking type indicates that the phone call is related to networking activities, such as building professional relationships, attending networking events, or connecting with industry peers.")]
        Networking,
        [Display(Name = "Personal")]
        [Description("Personal type indicates that the phone call is related to personal matters, such as family, friends, or personal errands.")]
        Personal,
        [Display(Name = "Emergency")]
        [Description("Emergency type indicates that the phone call is related to urgent or critical situations that require immediate attention.")]
        Emergency,
        [Display(Name = "Vendor")]
        [Description("Vendor type indicates that the phone call is related to interactions with vendors, suppliers, or external service providers.")]
        Vendor,
        [Display(Name = "Customer")]
        [Description("Customer type indicates that the phone call is related to interactions with customers, clients, or potential clients.")]
        Customer,
        [Display(Name = "Partner")]
        [Description("Partner type indicates that the phone call is related to interactions with business partners, collaborators, or strategic allies.")]
        Partner,
        [Display(Name = "Team")]
        [Description("Team type indicates that the phone call is related to interactions with team members, such as team meetings, collaboration, or internal communications.")]
        Team,
        [Display(Name = "Management")]
        [Description("Management type indicates that the phone call is related to interactions with management, such as meetings, updates, or strategic discussions.")]
        Management,
        [Display(Name = "Human Resources")]
        [Description("Human Resources type indicates that the phone call is related to interactions with the HR department, such as recruitment, employee relations, or policy discussions.")]
        HR,
        [Display(Name = "Finance")]
        [Description("Finance type indicates that the phone call is related to interactions with the finance department, such as budgeting, accounting, or financial planning.")]
        Finance,
        [Display(Name = "Complaint")]
        [Description("Complaint type indicates that the phone call is related to complaints, issues, or grievances raised by customers, clients, or stakeholders.")]
        Complaint,
        [Display(Name = "Feedback")]
        [Description("Feedback type indicates that the phone call is related to providing or receiving feedback, suggestions, or evaluations.")]
        Feedback,
        [Display(Name = "Survey")]
        [Description("Survey type indicates that the phone call is related to conducting or participating in surveys, questionnaires, or research studies.")]
        Survey,
        [Display(Name = "Appointment")]
        [Description("Appointment type indicates that the phone call is related to scheduling or attending appointments, meetings, or events.")]
        Appointment,
        [Display(Name = "Reminder")]
        [Description("Reminder type indicates that the phone call is related to reminders for tasks, events, or follow-ups.")]
        Reminder,
        [Display(Name = "Check In")]
        [Description("Check In type indicates that the phone call is related to checking in with someone, such as a status update or progress report.")]
        CheckIn,
        [Display(Name = "Check Out")]
        [Description("Check Out type indicates that the phone call is related to checking out with someone, such as concluding a meeting or providing final updates.")]
        CheckOut,
        [Display(Name = "Introduction")]
        [Description("Introduction type indicates that the phone call is related to introducing oneself or others, such as initial meetings or networking.")]
        Introduction,
        [Display(Name = "Negotiation")]
        [Description("Negotiation type indicates that the phone call is related to negotiating terms, agreements, or deals.")]
        Negotiation,
        [Display(Name = "Contract Discussion")]
        [Description("Contract Discussion type indicates that the phone call is related to discussing contract terms, conditions, or agreements.")]
        ContractDiscussion,
        [Display(Name = "Product Demonstration")]
        [Description("Product Demonstration type indicates that the phone call is related to demonstrating a product, its features, or its benefits.")]
        ProductDemo,
        [Display(Name = "Technical Support")]
        [Description("Technical Support type indicates that the phone call is related to providing technical assistance, troubleshooting, or resolving technical issues.")]
        TechnicalSupport,
        [Display(Name = "Billing Inquiry")]
        [Description("Billing Inquiry type indicates that the phone call is related to inquiries about billing, invoices, or payment issues.")]
        BillingInquiry,
        [Display(Name = "Collection")]
        [Description("Collection type indicates that the phone call is related to debt collection, payment reminders, or financial follow-ups.")]
        Collection,
        [Display(Name = "Recruitment")]
        [Description("Recruitment type indicates that the phone call is related to recruiting new employees, candidates, or talent acquisition.")]
        Recruitment,
        [Display(Name = "Interview")]
        [Description("Interview type indicates that the phone call is related to conducting or participating in interviews for job candidates.")]
        Interview,
        [Display(Name = "Performance Review")]
        [Description("Performance Review type indicates that the phone call is related to evaluating an employee's performance, providing feedback, or discussing career development.")]
        PerformanceReview,
        [Display(Name = "Coaching")]
        [Description("Coaching type indicates that the phone call is related to providing guidance, support, or training to improve skills or performance.")]
        Coaching,
        [Display(Name = "Mentoring")]
        [Description("Mentoring type indicates that the phone call is related to providing guidance, advice, or support to help someone develop their skills or career.")]
        Mentoring,
        [Display(Name = "Project Update")]
        [Description("Project Update type indicates that the phone call is related to providing updates on the progress, status, or milestones of a project.")]
        ProjectUpdate,
        [Display(Name = "Status Update")]
        [Description("Status Update type indicates that the phone call is related to providing updates on the current status or progress of a task, project, or activity.")]
        StatusUpdate,
        [Display(Name = "Brainstorming")]
        [Description("Brainstorming type indicates that the phone call is related to generating ideas, discussing concepts, or exploring solutions collaboratively.")]
        Brainstorming,
        [Display(Name = "Problem Solving")]
        [Description("Problem Solving type indicates that the phone call is related to identifying issues, analyzing problems, and finding solutions.")]
        ProblemSolving,
        [Display(Name = "Decision Making")]
        [Description("Decision Making type indicates that the phone call is related to making choices, evaluating options, and determining the best course of action.")]
        DecisionMaking,
        [Display(Name = "Strategy Planning")]
        [Description("Strategy Planning type indicates that the phone call is related to developing plans, setting goals, and outlining strategies for achieving objectives.")]
        StrategyPlanning,
        [Display(Name = "Crisis Management")]
        [Description("Crisis Management type indicates that the phone call is related to handling urgent or critical situations, mitigating risks, and managing emergencies.")]
        CrisisManagement,
        [Display(Name = "Innovation")]
        [Description("Innovation type indicates that the phone call is related to generating new ideas, creative thinking, and implementing innovative solutions.")]
        Innovation,
        [Display(Name = "Collaboration")]
        [Description("Collaboration type indicates that the phone call is related to working together with others, sharing information, and achieving common goals.")]
        Collaboration,
        [Display(Name = "Team Building")]
        [Description("Team Building type indicates that the phone call is related to activities or discussions aimed at improving team cohesion, communication, and collaboration.")]
        TeamBuilding,
        [Display(Name = "Social")]
        [Description("Social type indicates that the phone call is related to informal or casual interactions, networking, or relationship-building activities.")]
        Social,
        [Display(Name = "Casual")]
        [Description("Casual type indicates that the phone call is related to informal or non-work-related interactions.")]
        Casual,
        [Display(Name = "Other Internal")]
        [Description("Other Internal type indicates that the phone call is related to internal matters that do not fall into the predefined categories.")]
        OtherInternal,
        [Display(Name = "Other External")]
        [Description("Other External type indicates that the phone call is related to external matters that do not fall into the predefined categories.")]
        OtherExternal,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the phone call type is not specified or cannot be determined.")]
        Unknown
    }
}