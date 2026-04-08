using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum EmailType
    {
        [Display(Name = "Information")]
        [Description("Information type indicates that the email is intended to convey general information or updates to the recipient. It may include news, announcements, or other non-urgent communication that does not require immediate action from the recipient.")]
        Info,
        [Display(Name = "Sales")]
        [Description("Sales type indicates that the email is related to sales activities, such as promoting products or services, providing pricing information, or following up on sales leads. It may require attention or response from the recipient to facilitate the sales process and drive revenue growth.")]
        Sales,
        [Display(Name = "Support")]
        [Description("Support type indicates that the email is related to customer support activities, such as addressing customer inquiries, resolving issues, or providing assistance. It may require attention or response from the recipient to ensure customer satisfaction and maintain positive relationships with customers.")]
        Support,
        [Display(Name = "Other")]
        [Description("Other type indicates that the email does not fit into any of the predefined categories and may be related to a variety of topics or purposes. It may require further assessment or information to determine the appropriate handling and response for the email communication.")]
        Other,
        [Display(Name = "Competitor")]
        [Description("Competitor type indicates that the email is related to competitive intelligence or activities, such as monitoring competitor offerings, analyzing market trends, or gathering information about competitors. It may require attention or response from the recipient to inform strategic decision-making and maintain a competitive edge in the market.")]
        Competitor,
        [Display(Name = "Follow Up")]
        [Description("Follow Up type indicates that the email is intended to follow up on a previous communication or interaction, such as a meeting, phone call, or previous email. It may require attention or response from the recipient to ensure continuity of communication and effective follow-up on any outstanding issues or requests.")]
        FollowUp,
        [Display(Name = "Prospecting")]
        [Description("Prospecting type indicates that the email is related to prospecting activities, such as reaching out to potential customers, generating leads, or initiating contact with new business opportunities. It may require attention or response from the recipient to facilitate the prospecting process and drive business growth.")]
        Prospecting,
        [Display(Name = "Qualifying")]
        [Description("Qualifying type indicates that the email is related to qualifying activities, such as assessing the suitability of a lead or opportunity, gathering information to determine fit, or evaluating potential business opportunities. It may require attention or response from the recipient to facilitate the qualifying process and ensure effective prioritization of leads and opportunities.")]
        Qualifying,
        [Display(Name = "Closing")]
        [Description("Closing type indicates that the email is related to closing activities, such as finalizing a sale, negotiating terms, or confirming agreements. It may require attention or response from the recipient to facilitate the closing process and ensure successful completion of sales transactions or business agreements.")]
        Closing,
        [Display(Name = "Post Sale")]
        [Description("Post Sale type indicates that the email is related to post-sale activities, such as providing customer support, addressing post-sale inquiries, or following up on customer satisfaction. It may require attention or response from the recipient to ensure ongoing customer satisfaction and maintain positive relationships with customers after a sale has been completed.")]
        PostSale,
        [Display(Name = "Internal")]
        [Description("Internal type indicates that the email is intended for internal communication within the organization, such as communication between employees, departments, or teams. It may include updates, announcements, or other communication that is relevant to internal operations and may require attention or response from the recipient to facilitate effective internal communication and collaboration.")]
        Internal,
        [Display(Name = "External")]
        [Description("External type indicates that the email is intended for communication with external parties, such as customers, partners, vendors, or other stakeholders outside of the organization. It may include communication related to sales, support, marketing, or other external-facing activities and may require attention or response from the recipient to facilitate effective communication and relationship management with external stakeholders.")]
        External,   
        [Display(Name = "Training")]
        [Description("Training type indicates that the email is related to training activities, such as providing training materials, scheduling training sessions, or following up on training-related inquiries. It may require attention or response from the recipient to facilitate effective training and development initiatives within the organization.")]
        Training,
        [Display(Name = "Conference")]
        [Description("Conference type indicates that the email is related to conference activities, such as promoting conference events, providing conference information, or following up on conference-related inquiries. It may require attention or response from the recipient to facilitate effective communication and engagement with conference attendees and stakeholders.")]
        Conference,
        [Display(Name = "Networking")]
        [Description("Networking type indicates that the email is related to networking activities, such as connecting with industry peers, building professional relationships, or engaging in networking events. It may require attention or response from the recipient to facilitate effective networking and relationship-building opportunities within the industry or professional community.")]
        Networking,
        [Display(Name = "Personal")]
        [Description("Personal type indicates that the email is related to personal communication, such as communication between friends, family members, or other personal contacts. It may include non-business-related communication and may require attention or response from the recipient based on the nature of the personal relationship and communication context.")]
        Personal,
        [Display(Name = "Emergency")]
        [Description("Emergency type indicates that the email is related to urgent or critical situations that require immediate attention and response from the recipient. It may include communication related to emergencies, crises, or other time-sensitive situations that necessitate prompt action to mitigate risks, ensure safety, or address critical issues effectively.")]
        Emergency,
        [Display(Name ="Vendor")]
        [Description("Vendor type indicates that the email is related to communication with vendors, such as inquiries, negotiations, or other communication related to vendor relationships. It may require attention or response from the recipient to facilitate effective communication and relationship management with vendors, ensuring successful procurement and supply chain operations.")]
        Vendor,
        [Display(Name = "Customer")]
        [Description("Customer type indicates that the email is related to communication with customers, such as inquiries, support requests, or other communication related to customer relationships. It may require attention or response from the recipient to facilitate effective communication and relationship management with customers, ensuring customer satisfaction and loyalty.")]
        Customer,
        [Display(Name = "Partner")]
        [Description("Partner type indicates that the email is related to communication with partners, such as collaboration, joint ventures, or other communication related to partner relationships. It may require attention or response from the recipient to facilitate effective communication and relationship management with partners, ensuring successful collaboration and mutual benefit in business partnerships.")]
        Partner,
        [Display(Name = "Team")]
        [Description("Team type indicates that the email is related to communication within a team, such as project updates, team announcements, or other communication relevant to team collaboration. It may require attention or response from the recipient to facilitate effective communication and collaboration within the team, ensuring alignment and successful completion of team objectives.")]
        Team,
        [Display(Name = "Management")]
        [Description("Management type indicates that the email is related to communication with management, such as updates, reports, or other communication relevant to management-level activities. It may require attention or response from the recipient to facilitate effective communication and relationship management with management, ensuring alignment with organizational goals and successful execution of management responsibilities.")]
        Management,
        [Display(Name = "Human Resources")]
        [Description("Human Resources type indicates that the email is related to communication with or about human resources, such as employee inquiries, HR policies, or other communication relevant to HR activities. It may require attention or response from the recipient to facilitate effective communication and relationship management with HR, ensuring successful resolution of HR-related issues and effective support for employees within the organization.")]
        HR,
        [Display(Name = "Finance")]
        [Description("Finance type indicates that the email is related to communication with or about finance, such as financial inquiries, budgeting, or other communication relevant to financial activities. It may require attention or response from the recipient to facilitate effective communication and relationship management with finance, ensuring successful resolution of financial-related issues and effective support for financial operations within the organization.")]
        Finance,
        [Display(Name = "Complaint")]
        [Description("Complaint type indicates that the email is related to a complaint or issue raised by a customer, partner, or other stakeholder. It may require attention or response from the recipient to facilitate effective resolution of the complaint, ensuring customer satisfaction and maintaining positive relationships with stakeholders.")]
        Complaint,
        [Display(Name = "Feedback")]
        [Description("Feedback type indicates that the email is related to feedback provided by a customer, partner, or other stakeholder. It may include suggestions, comments, or other feedback that can be valuable for improving products, services, or overall customer experience. It may require attention or response from the recipient to acknowledge and address the feedback effectively, demonstrating responsiveness and commitment to continuous improvement.")]
        Feedback,
        [Display(Name = "Survey")]
        [Description("Survey type indicates that the email is related to a survey or questionnaire sent to customers, partners, or other stakeholders. It may include requests for feedback, opinions, or other information that can be valuable for market research, customer satisfaction assessment, or other purposes. It may require attention or response from the recipient to encourage participation in the survey and ensure effective collection of valuable insights from stakeholders.")]
        Survey,
        [Display(Name = "Appointment")]
        [Description("Appointment type indicates that the email is related to scheduling or confirming an appointment, such as a meeting, phone call, or other scheduled event. It may require attention or response from the recipient to confirm attendance, reschedule if necessary, or provide any additional information related to the appointment to ensure successful coordination and execution of the scheduled event.")]
        Appointment,
        [Display(Name = "Reminder")]
        [Description("Reminder type indicates that the email is intended to serve as a reminder for an upcoming event, deadline, or other important date. It may require attention or response from the recipient to acknowledge the reminder, take necessary actions, or provide any additional information related to the reminder to ensure successful preparation and execution of the upcoming event or deadline.")]
        Reminder,
        [Display(Name = "Check In")]
        [Description("Check In type indicates that the email is intended to check in with the recipient, such as following up on a previous communication, providing updates, or simply checking in to maintain communication and relationship with the recipient. It may require attention or response from the recipient to acknowledge the check-in, provide any necessary updates or information, or simply maintain ongoing communication and engagement with the sender.")]
        CheckIn,
        [Display(Name = "Check Out")]
        [Description("Check Out type indicates that the email is intended to check out with the recipient, such as following up after a meeting, providing final updates, or simply checking out to conclude communication and relationship with the recipient. It may require attention or response from the recipient to acknowledge the check-out, provide any necessary final updates or information, or simply conclude ongoing communication and engagement with the sender in a professional and courteous manner.")]
        CheckOut,
        [Display(Name = "Introduction")]
        [Description("Introduction type indicates that the email is intended to introduce the sender to the recipient, such as a self-introduction, introduction of a colleague or contact, or other communication related to introductions. It may require attention or response from the recipient to acknowledge the introduction, provide any necessary information or context, or simply establish a connection and relationship with the sender for future communication and collaboration opportunities.")]
        Introduction,
        [Display(Name = "Negotiation")]
        [Description("Negotiation type indicates that the email is related to negotiation activities, such as discussing terms, pricing, or other aspects of a potential agreement or deal. It may require attention or response from the recipient to engage in the negotiation process, provide necessary information or concessions, or work towards reaching a mutually beneficial agreement with the sender.")]
        Negotiation,
        [Display(Name = "Contract Discussion")]
        [Description("Contract Discussion type indicates that the email is related to discussions about a contract, such as reviewing contract terms, negotiating contract details, or addressing any issues or concerns related to a contract. It may require attention or response from the recipient to engage in the contract discussion process, provide necessary information or feedback, or work towards reaching a successful resolution of any contract-related matters with the sender.")]
        ContractDiscussion,
        [Display(Name = "Product Demonstration")]
        [Description("Product Demonstration type indicates that the email is related to a product demonstration, such as scheduling a demo, providing information about a demo, or following up on a demo-related inquiry. It may require attention or response from the recipient to confirm attendance, provide any necessary information or materials for the demo, or simply engage in communication related to the product demonstration to facilitate successful execution and potential sales opportunities.")]
        ProductDemo,
        [Display(Name = "Technical Support")]
        [Description("Technical Support type indicates that the email is related to technical support activities, such as addressing technical issues, providing troubleshooting assistance, or following up on technical support inquiries. It may require attention or response from the recipient to facilitate effective resolution of technical issues, ensuring customer satisfaction and maintaining positive relationships with customers who require technical support.")]
        TechnicalSupport,
        [Display(Name = "Billing Inquiry")]
        [Description("Billing Inquiry type indicates that the email is related to billing inquiries, such as questions about invoices, payment issues, or other billing-related communication. It may require attention or response from the recipient to address the billing inquiry effectively, ensuring customer satisfaction and maintaining positive relationships with customers who have billing-related concerns or questions.")]
        BillingInquiry,
        [Display(Name = "Collection")]
        [Description("Collection type indicates that the email is related to collection activities, such as following up on overdue payments, addressing collection-related inquiries, or communicating with customers about outstanding balances. It may require attention or response from the recipient to facilitate effective collection efforts, ensuring timely resolution of outstanding payments and maintaining positive relationships with customers while addressing collection-related matters.")]
        Collection,
        [Display(Name = "Recruitment")]
        [Description("Recruitment type indicates that the email is related to recruitment activities, such as job postings, candidate inquiries, or communication with potential candidates. It may require attention or response from the recipient to facilitate effective recruitment efforts, ensuring successful identification and engagement of qualified candidates for job opportunities within the organization.")]
        Recruitment,
        [Display(Name = "Interview")]
        [Description("Interview type indicates that the email is related to interview activities, such as scheduling interviews, providing interview information, or following up on interview-related inquiries. It may require attention or response from the recipient to confirm interview details, provide any necessary information or materials for the interview, or simply engage in communication related to the interview process to facilitate successful execution and potential hiring opportunities.")]
        Interview,
        [Display(Name = "Performance Review")]
        [Description("Performance Review type indicates that the email is related to performance review activities, such as scheduling performance reviews, providing performance review information, or following up on performance review-related inquiries. It may require attention or response from the recipient to confirm performance review details, provide any necessary information or materials for the performance review, or simply engage in communication related to the performance review process to facilitate successful execution and potential employee development opportunities.")]
        PerformanceReview,
        [Display(Name = "Coaching")]
        [Description("Coaching type indicates that the email is related to coaching activities, such as providing coaching materials, scheduling coaching sessions, or following up on coaching-related inquiries. It may require attention or response from the recipient to facilitate effective coaching and development initiatives within the organization, ensuring successful support for employee growth and performance improvement through coaching efforts.")]
        Coaching,
        [Display(Name = "Mentoring")]
        [Description("Mentoring type indicates that the email is related to mentoring activities, such as providing mentoring materials, scheduling mentoring sessions, or following up on mentoring-related inquiries. It may require attention or response from the recipient to facilitate effective mentoring relationships and development initiatives within the organization, ensuring successful support for employee growth and career development through mentoring efforts.")]
        Mentoring,
        [Display(Name = "Project Update")]
        [Description("Project Update type indicates that the email is related to providing updates on a project, such as progress reports, milestone achievements, or other communication relevant to project status. It may require attention or response from the recipient to acknowledge the project update, provide any necessary feedback or information, or simply stay informed about the progress and status of the project to facilitate effective project management and successful completion of project objectives.")]
        ProjectUpdate,
        [Display(Name = "Status Update")]
        [Description("Status Update type indicates that the email is related to providing updates on the status of a task, issue, or other matter, such as progress reports, resolution updates, or other communication relevant to status. It may require attention or response from the recipient to acknowledge the status update, provide any necessary feedback or information, or simply stay informed about the status of the matter to facilitate effective communication and successful resolution of any outstanding issues or tasks.")]
        StatusUpdate,
        [Display(Name = "Brainstorming")]
        [Description("Brainstorming type indicates that the email is related to brainstorming activities, such as generating ideas, discussing potential solutions, or engaging in creative thinking. It may require attention or response from the recipient to actively participate in the brainstorming process, provide input and ideas, or simply engage in communication related to brainstorming efforts to facilitate effective idea generation and problem-solving within the organization.")]
        Brainstorming,
        [Display(Name = "Problem Solving")]
        [Description("Problem Solving type indicates that the email is related to problem-solving activities, such as addressing challenges, finding solutions, or engaging in critical thinking. It may require attention or response from the recipient to actively participate in the problem-solving process, provide insights and suggestions, or simply engage in communication related to problem-solving efforts to facilitate effective resolution of issues and challenges within the organization.")]
        ProblemSolving,
        [Display(Name = "Decision Making")]
        [Description("Decision Making type indicates that the email is related to decision-making activities, such as discussing options, evaluating alternatives, or engaging in discussions to reach a decision. It may require attention or response from the recipient to actively participate in the decision-making process, provide input and perspectives, or simply engage in communication related to decision-making efforts to facilitate effective decision-making and successful outcomes for the organization.")]
        DecisionMaking,
        [Display(Name = "Strategy Planning")]
        [Description("Strategy Planning type indicates that the email is related to strategy planning activities, such as discussing strategic goals, developing plans, or engaging in discussions to shape the strategic direction of the organization. It may require attention or response from the recipient to actively participate in the strategy planning process, provide insights and perspectives, or simply engage in communication related to strategy planning efforts to facilitate effective strategic planning and successful execution of organizational strategies.")]   
        StrategyPlanning,
        [Display(Name = "Crisis Management")]
        [Description("Crisis Management type indicates that the email is related to managing a crisis or critical situation, such as addressing urgent issues, coordinating response efforts, or communicating with stakeholders during a crisis. It may require immediate attention and response from the recipient to facilitate effective crisis management, ensuring timely resolution of the crisis and minimizing negative impacts on the organization and its stakeholders.")]
        CrisisManagement,
        [Display(Name = "Innovation")]
        [Description("Innovation type indicates that the email is related to innovation activities, such as discussing new ideas, sharing innovative solutions, or engaging in communication related to fostering innovation within the organization. It may require attention or response from the recipient to actively participate in innovation efforts, provide insights and suggestions, or simply engage in communication related to innovation to facilitate a culture of creativity and continuous improvement within the organization.")]
        Innovation,
        [Display(Name = "Collaboration")]
        [Description("Collaboration type indicates that the email is related to collaboration activities, such as working together on a project, sharing information, or engaging in communication to facilitate teamwork and cooperation. It may require attention or response from the recipient to actively participate in collaborative efforts, provide input and support, or simply engage in communication related to collaboration to facilitate effective teamwork and successful outcomes for the organization.")]
        Collaboration,
        [Display(Name = "Team Building")]
        [Description("Team Building type indicates that the email is related to team-building activities, such as organizing team events, providing team-building resources, or engaging in communication to foster team cohesion and camaraderie. It may require attention or response from the recipient to actively participate in team-building efforts, provide input and support, or simply engage in communication related to team building to facilitate a positive and collaborative team environment within the organization.")]
        TeamBuilding,
        [Display(Name = "Social")]
        [Description("Social type indicates that the email is related to social activities, such as organizing social events, sharing social updates, or engaging in communication to foster social connections and relationships. It may require attention or response from the recipient to actively participate in social efforts, provide input and support, or simply engage in communication related to social activities to facilitate a positive and engaging social environment within the organization.")]    
        Social,
        [Display(Name = "Casual")]
        [Description("Casual type indicates that the email is related to casual communication, such as informal updates, friendly check-ins, or other communication that is not necessarily business-related. It may require attention or response from the recipient based on the nature of the relationship and communication context, but it generally represents a more relaxed and informal style of communication compared to other email types.")]
        Casual,
        [Display(Name = "Other Internal")]
        [Description("Other Internal type indicates that the email is related to internal communication within the organization that does not fit into any of the predefined categories. It may include communication on a variety of topics or purposes that are relevant to internal operations and may require attention or response from the recipient to facilitate effective internal communication and collaboration.")]
        OtherInternal,
        [Display(Name = "Other External")]
        [Description("Other External type indicates that the email is related to communication with external parties that does not fit into any of the predefined categories. It may include communication on a variety of topics or purposes that are relevant to external-facing activities and may require attention or response from the recipient to facilitate effective communication and relationship management with external stakeholders.")]
        OtherExternal,
        [Display(Name = "Unknown")]
        [Description("")]
        Unknown
    }
