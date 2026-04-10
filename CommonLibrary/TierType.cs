using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum TierType
    {
        [Display(Name = "Platinum Tier")]
        Platinum,
        [Display(Name = "Gold Tier")]
        Gold,
        [Display(Name = "Silver Tier")]
        Silver,
        [Display(Name = "Bronze Tier")]
        Bronze,
        [Display(Name = "Unknown")]
        Unknown
    }
}