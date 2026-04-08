using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum RelationshipType
    {
        [Display(Name = "Parent")]
        [Description("Parent relationship indicates that the entity is a parent in the relationship.")]
        Parent,
        [Display(Name = "Child")]
        [Description("Child relationship indicates that the entity is a child in the relationship.")]
        Child,
        [Display(Name = "Sibling")]
        [Description("Sibling relationship indicates that the entity is a sibling in the relationship.")]
        Sibling,
        [Display(Name = "Spouse")]
        [Description("Spouse relationship indicates that the entity is a spouse in the relationship.")]
        Spouse,
        [Display(Name = "Partner")]
        [Description("Partner relationship indicates that the entity is a partner in the relationship.")]
        Partner,
        [Display(Name = "Other")]
        [Description("Other relationship indicates that the entity's relationship does not fall into any of the predefined categories.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown relationship indicates that the entity's relationship is not specified or cannot be determined.")]
        Unknown
    }
