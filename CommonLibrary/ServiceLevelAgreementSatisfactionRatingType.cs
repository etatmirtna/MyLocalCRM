using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementSatisfactionRatingType
    {
        [Display(Name = "Very Satisfied")]
        [Description("Very Satisfied indicates that the customer is extremely satisfied with the service provided.")]
        VerySatisfied,
        [Display(Name = "Satisfied")]
        [Description("Satisfied indicates that the customer is pleased with the service provided.")]
        Satisfied,
        [Display(Name = "Neutral")]
        [Description("Neutral indicates that the customer has a neutral opinion of the service provided.")]
        Neutral,
        [Display(Name = "Dissatisfied")]
        [Description("Dissatisfied indicates that the customer is not satisfied with the service provided.")]
        Dissatisfied,
        [Display(Name = "Very Dissatisfied")]
        [Description("Very Dissatisfied indicates that the customer is extremely dissatisfied with the service provided.")]
        VeryDissatisfied,
        [Display(Name = "Unknown")]
        [Description("Unknown indicates that the customer's satisfaction rating is not specified or cannot be determined.")]
        Unknown
    }
}