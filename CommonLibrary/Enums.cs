using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace CommonLibrary
{

    public enum ServiceLevelAgreementType
    {
        [Display(Name = "Standard")]
        Standard,
        [Display(Name = "Premium")]
        Premium,
        [Display(Name = "Enterprise")]
        Enterprise,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementStatusType
    {
        [Display(Name = "Active")]
        Active,
        [Display(Name = "Expired")]
        Expired,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementDirectionType
    {
        [Display(Name = "Inbound")]
        Inbound,
        [Display(Name = "Outbound")]
        Outbound,
        [Display(Name = "Internal")]
        Internal,
        [Display(Name = "External")]
        External,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementTypeOfServiceType
    {
        [Display(Name = "Support")]
        Support,
        [Display(Name = "Maintenance")]
        Maintenance,
        [Display(Name = "Consulting")]
        Consulting,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementResponseTimeType
    {
        [Display(Name = "1 Hour")]
        OneHour,
        [Display(Name = "4 Hours")]
        FourHours,
        [Display(Name = "8 Hours")]
        EightHours,
        [Display(Name = "24 Hours")]
        TwentyFourHours,
        [Display(Name = "48 Hours")]
        FortyEightHours,
        [Display(Name = "72 Hours")]
        SeventyTwoHours,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementResolutionTimeType
    {
        [Display(Name = "4 Hours")]
        FourHours,
        [Display(Name = "8 Hours")]
        EightHours,
        [Display(Name = "24 Hours")]
        TwentyFourHours,
        [Display(Name = "48 Hours")]
        FortyEightHours,
        [Display(Name = "72 Hours")]
        SeventyTwoHours,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingType
    {
        [Display(Name = "Very Satisfied")]
        VerySatisfied,
        [Display(Name = "Satisfied")]
        Satisfied,
        [Display(Name = "Neutral")]
        Neutral,
        [Display(Name = "Dissatisfied")]
        Dissatisfied,
        [Display(Name = "Very Dissatisfied")]
        VeryDissatisfied,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingReasonType
    {
        [Display(Name = "Quality Of Service")]
        QualityOfService,
        [Display(Name = "Timeliness")]
        Timeliness,
        [Display(Name = "Professionalism")]
        Professionalism,
        [Display(Name = "Communication")]
        Communication,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingFeedbackType
    {
        [Display(Name = "Positive")]
        Positive,
        [Display(Name = "Neutral")]
        Neutral,
        [Display(Name = "Negative")]
        Negative,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingFollowUpActionType
    {
        [Display(Name = "Contact Customer")]
        ContactCustomer,
        [Display(Name = "Offer Refund")]
        OfferRefund,
        [Display(Name = "Provide Discount")]
        ProvideDiscount,
        [Display(Name = "Escalate To Management")]
        EscalateToManagement,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingFollowUpActionStatus
    {
        [Display(Name = "Not Started")]
        NotStarted,
        [Display(Name = "In Progress")]
        InProgress,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Deferred")]
        Deferred,
        [Display(Name = "Waiting For Someone Else")]
        WaitingForSomeoneElse,
        [Display(Name = "Waiting For Something")]
        WaitingForSomething,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingFollowUpActionPriority
    {
        [Display(Name = "Low")]
        Low,
        [Display(Name = "Normal")]
        Normal,
        [Display(Name = "High")]
        High,
        [Display(Name = "Urgent")]
        Urgent,
        [Display(Name = "Critical")]
        Critical,
        [Display(Name = "Routine")]
        Routine,
        [Display(Name = "Important")]
        Important,
        [Display(Name = "Time Sensitive")]
        TimeSensitive,
        [Display(Name = "Non Urgent")]
        NonUrgent,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ServiceLevelAgreementSatisfactionRatingFollowUpActionType
    {
        [Display(Name = "Phone Call")]
        PhoneCall,
        [Display(Name = "Email")]
        Email,
        [Display(Name = "Meeting")]
        Meeting,
        [Display(Name = "Task")]
        Task,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum RoleType
    {
        [Display(Name = "System Administrator")]
        SystemAdministrator,
        [Display(Name = "Salesperson")]
        Salesperson,
        [Display(Name = "Customer Service Representative")]
        CustomerServiceRep,
        [Display(Name = "Marketing Specialist")]
        MarketingSpecialist,
        [Display(Name = "Project Manager")]
        ProjectManager,
        [Display(Name = "Developer")]
        Developer,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum SalesRoleType
    {
        [Display(Name = "Account Manager")]
        AccountManager,
        [Display(Name = "Sales Executive")]
        SalesExecutive,
        [Display(Name = "Sales Manager")]
        SalesManager,
        [Display(Name = "Sales Representative")]
        SalesRepresentative,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum SupportRoleType
    {
        [Display(Name = "Support Engineer")]
        SupportEngineer,
        [Display(Name = "Support Manager")]
        SupportManager,
        [Display(Name = "Customer Service Representative")]
        CustomerServiceRep,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum MarketingRoleType
    {
        [Display(Name = "Marketing Manager")]
        MarketingManager,
        [Display(Name = "Marketing Specialist")]
        MarketingSpecialist,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum ProjectRoleType
    {
        [Display(Name = "Project Manager")]
        ProjectManager,
        [Display(Name = "Developer")]
        Developer,
        [Display(Name = "Tester")]
        Tester,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum OtherRoleType
    {
        [Display(Name = "Consultant")]
        Consultant,
        [Display(Name = "Contractor")]
        Contractor,
        [Display(Name = "Vendor")]
        Vendor,
        [Display(Name = "Partner")]
        Partner,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum TeamRoleType
    {
        [Display(Name = "Team Lead")]
        TeamLead,
        [Display(Name = "Team Member")]
        TeamMember,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum BusinessProcessFlowStageStatus
    {
        [Display(Name = "Not Started")]
        NotStarted,
        [Display(Name = "In Progress")]
        InProgress,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum BusinessProcessFlowStageCategory
    {
        [Display(Name = "Qualify")]
        Qualify,
        [Display(Name = "Develop")]
        Develop,
        [Display(Name = "Propose")]
        Propose,
        [Display(Name = "Close")]
        Close,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum BusinessProcessFlowStageStatusReason
    {
        [Display(Name = "None")]
        None,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Failed")]
        Failed,
        [Display(Name = "Success")]
        Success,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum StatusType
    {
        [Display(Name = "Active")]
        Active,
        [Display(Name = "Inactive")]
        Inactive,
        [Display(Name = "Pending")]
        Pending,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum StatusReasonType
    {
        [Display(Name = "None")]
        None,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Failed")]
        Failed,
        [Display(Name = "Success")]
        Success,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum StateType
    {
        [Display(Name = "Active")]
        Active,
        [Display(Name = "Inactive")]
        Inactive,
        [Display(Name = "Draft")]
        Draft,
        [Display(Name = "Submitted")]
        Submitted,
        [Display(Name = "Approved")]
        Approved,
        [Display(Name = "Rejected")]
        Rejected,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Unknown")]
        Unknown
    }

    public enum RelationshipType
    {
        [Display(Name = "Parent")]
        Parent,
        [Display(Name = "Child")]
        Child,
        [Display(Name = "Sibling")]
        Sibling,
        [Display(Name = "Spouse")]
        Spouse,
        [Display(Name = "Partner")]
        Partner,
        [Display(Name = "Other")]
        Other,
        [Display(Name = "Unknown")]
        Unknown
    }



    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum value)
        {
            var member = value.GetType().GetMember(value.ToString());
            var attribute = member[0].GetCustomAttribute<DisplayAttribute>();

            return attribute?.Name ?? value.ToString();
        }

    }