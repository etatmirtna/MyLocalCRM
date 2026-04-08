using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum PhoneNumberType
    {
        [Display(Name = "Mobile")]
        [Description("Mobile type indicates that the phone number is a mobile or cellular number. This type may be used for personal or business communication and may support text messaging, voice calls, and other mobile services.")]
        Mobile,
        [Display(Name = "Work")]
                [Description("Work type indicates that the phone number is a work or business number. This type may be used for professional communication and may be associated with the individual's place of employment or business.")]
        Work,
        [Display(Name = "Home")]
        [Description("Home type indicates that the phone number is a personal or residential number. This type may be used for personal communication and may be associated with the individual's home or private residence.")]
        Home,
        [Display(Name = "Fax")]
        [Description("Fax type indicates that the phone number is a fax number. This type may be used for sending and receiving fax communications.")]
        Fax,
        [Display(Name = "Other")]
        [Description("Other type indicates that the phone number does not fall into the predefined categories. This type may be used for miscellaneous or unconventional phone numbers.")] 
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the phone number is not known or has not been specified. This type may be used as a default or placeholder value when the actual phone number is unclear or unavailable.")]
        Unknown
    }
