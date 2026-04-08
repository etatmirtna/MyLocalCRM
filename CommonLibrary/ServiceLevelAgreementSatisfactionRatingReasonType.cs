using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementSatisfactionRatingReasonType
    {
        [Display(Name = "Quality Of Service")]
        [Description("Quality Of Service reason indicates that the customer is satisfied or dissatisfied with the quality of the service provided.")]
        QualityOfService,
        [Display(Name = "Timeliness")]
        [Description("Timeliness reason indicates that the customer is satisfied or dissatisfied with the timeliness of the service provided.")]
        Timeliness,
        [Display(Name = "Professionalism")]
        [Description("Professionalism reason indicates that the customer is satisfied or dissatisfied with the professionalism of the service provided.")]
        Professionalism,
        [Display(Name = "Communication")]
        [Description("Communication reason indicates that the customer is satisfied or dissatisfied with the communication of the service provided.")]
        Communication,
        [Display(Name = "Other")]
        [Description("Other reason indicates that the reason for the customer's satisfaction or dissatisfaction does not fall into the predefined categories.")]
        Other,
        [Display(Name = "Unknown")] 
        [Description("Unknown reason indicates that the reason for the customer's satisfaction or dissatisfaction is not specified or cannot be determined.")]
        Unknown
    }
