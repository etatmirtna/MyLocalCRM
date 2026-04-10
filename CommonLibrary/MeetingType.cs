using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum MeetingType
    {
        [Display(Name = "General Meeting")]
        [Description("General Meeting type indicates that the meeting is intended for general discussion, collaboration, or information sharing among participants. It may cover a wide range of topics and may not have a specific focus or agenda, allowing for open communication and exchange of ideas among attendees.")]
        Meeting,
        [Display(Name = "Phone Call")]
        [Description("Phone Call type indicates that the meeting is conducted over the phone, allowing participants to communicate and collaborate remotely. It may be used for various purposes, such as discussing project updates, addressing customer inquiries, or conducting sales calls, providing a convenient and efficient way for participants to connect and engage in meaningful discussions without the need for physical presence.")]
        Call,
        [Display(Name = "Email")]
        [Description("Email type indicates that the meeting is conducted through email communication, allowing participants to exchange information, updates, or discussions asynchronously. It may be used for various purposes, such as sharing project updates, addressing customer inquiries, or conducting sales communication, providing a flexible and efficient way for participants to communicate and collaborate without the need for real-time interaction.")]
        Email,
        [Display(Name = "Sales Meeting")]
        [Description("Sales Meeting type indicates that the meeting is focused on sales-related activities, such as discussing sales strategies, reviewing sales performance, or addressing sales opportunities. It may involve sales teams, managers, or other stakeholders involved in the sales process, providing a platform for collaboration and alignment on sales goals and initiatives to drive revenue growth.")]
        Sales,
        [Display(Name = "Support Meeting")]
        [Description("Support Meeting type indicates that the meeting is focused on customer support-related activities, such as addressing customer inquiries, resolving issues, or providing assistance. It may involve support teams, managers, or other stakeholders involved in customer support, providing a platform for collaboration and alignment on support goals and initiatives to ensure customer satisfaction and maintain positive relationships with customers.")]
        Support,
        [Display(Name = "Training")]
        [Description("Training type indicates that the meeting is focused on training-related activities, such as providing training materials, conducting training sessions, or following up on training-related inquiries. It may involve trainers, trainees, or other stakeholders involved in training and development initiatives, providing a platform for collaboration and alignment on training goals and initiatives to facilitate effective learning and development within the organization.")]
        Training,
        [Display(Name = "Networking")]
        [Description("Networking type indicates that the meeting is focused on networking-related activities, such as connecting with industry peers, building professional relationships, or engaging in networking events. It may involve professionals from various industries, backgrounds, or roles, providing a platform for collaboration and relationship-building opportunities within the industry or professional community to foster connections and facilitate knowledge sharing.")]
        Networking,
        [Display(Name = "Personal")]
        [Description("")]
        Personal,
        [Display(Name = "Vendor")]
        [Description("Vendor type indicates that the meeting is focused on communication and collaboration with vendors, such as discussing vendor relationships, negotiating contracts, or addressing vendor-related inquiries. It may involve vendor representatives, procurement teams, or other stakeholders involved in vendor management, providing a platform for effective communication and relationship management with vendors to ensure successful procurement and supply chain operations.")]
        Vendor,
        [Display(Name = "Customer")]
        [Description("Customer type indicates that the meeting is focused on communication and collaboration with customers, such as addressing customer inquiries, providing support, or discussing customer-related topics. It may involve customer representatives, support teams, or other stakeholders involved in customer relationship management, providing a platform for effective communication and relationship management with customers to ensure customer satisfaction and loyalty.")]
        Customer,
        [Display(Name = "Partner")]
        [Description("Partner type indicates that the meeting is focused on communication and collaboration with partners, such as discussing partnership opportunities, addressing partner-related inquiries, or engaging in joint initiatives. It may involve partner representatives, business development teams, or other stakeholders involved in partner relationship management, providing a platform for effective communication and relationship management with partners to ensure successful collaboration and mutual benefit in business partnerships.")]
        Partner,
        [Description("Team type indicates that the meeting is focused on communication and collaboration within a team, such as project updates, team announcements, or other communication relevant to team collaboration. It may involve team members, project managers, or other stakeholders involved in team activities, providing a platform for effective communication and collaboration within the team to ensure alignment and successful completion of team objectives.")]
        [Display(Name = "Team")]
        Team,
        [Display(Name = "Management")]
        [Description("Management type indicates that the meeting is focused on communication and collaboration with management, such as updates, reports, or other communication relevant to management-level activities. It may involve managers, executives, or other stakeholders involved in management responsibilities, providing a platform for effective communication and relationship management with management to ensure alignment with organizational goals and successful execution of management responsibilities.")]
        Management,
        [Display(Name = "Human Resources")]
        [Description("Human Resources type indicates that the meeting is focused on communication and collaboration with or about human resources, such as employee inquiries, HR policies, or other communication relevant to HR activities. It may involve HR representatives, employees, or other stakeholders involved in HR-related matters, providing a platform for effective communication and relationship management with HR to ensure successful resolution of HR-related issues and effective support for employees within the organization.")]
        HR,
        [Display(Name = "Finance")]
        [Description("Finance type indicates that the meeting is focused on communication and collaboration with or about finance, such as financial inquiries, budgeting, or other communication relevant to financial activities. It may involve finance representatives, financial analysts, or other stakeholders involved in financial management, providing a platform for effective communication and relationship management with finance to ensure sound financial management practices and support for the financial needs of the organization.")]
        Finance,
        [Display(Name = "Complaint")]
        [Description("Complaint type indicates that the meeting is focused on addressing complaints, such as customer complaints, employee grievances, or other types of complaints. It may involve relevant stakeholders, such as customer service representatives, HR personnel, or other parties involved in complaint resolution, providing a platform for effective communication and resolution of complaints to ensure customer satisfaction, employee well-being, and overall organizational success.")]
        Complaint,
        [Display(Name = "Conference")]
        [Description("")]
        Conference,
        [Display(Name = "Other")]
        [Description("Other type indicates that the meeting does not fit into any of the predefined categories and may be related to a variety of topics or purposes. It may require further assessment or information to determine the appropriate handling and response for the meeting communication and collaboration.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the meeting's purpose or topic is not known or has not been specified. It may require further clarification or information to determine the appropriate handling and response for the meeting communication and collaboration.")]
        Unknown
    }
}