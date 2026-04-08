using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum ServiceLevelAgreementSatisfactionRatingFeedbackType
    {
        [Display(Name = "Positive")]
        [Description("Positive feedback indicates that the customer is satisfied with the service provided and has a favorable opinion of the experience. This type of feedback may include compliments, praise, or expressions of gratitude for the quality of service received.")]
        Positive,
        [Display(Name = "Neutral")]
        [Description("Neutral feedback indicates that the customer has a neutral opinion of the service provided. This type of feedback may include neither positive nor negative comments.")]
        Neutral,
        [Display(Name = "Negative")]
        [Description("Negative feedback indicates that the customer is dissatisfied with the service provided and has an unfavorable opinion of the experience. This type of feedback may include complaints, criticism, or expressions of dissatisfaction.")]
        Negative,
        [Display(Name = "Other")]
        [Description("Other feedback indicates that the feedback provided by the customer does not fall into the predefined categories.")]
        Other,
        [Display(Name = "Unknown")]
                [Description("Unknown feedback indicates that the feedback provided by the customer is not specified or cannot be determined.")]
        Unknown
    }
