using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum EmailAttachmentType
    {
        [Display(Name = "Document")]
        [Description("Document type indicates that the email attachment is a file that contains text, data, or information in a structured format. It may include word processing documents, PDFs, or other types of files that are primarily used for storing and sharing information.")]
        Document,
        [Display(Name = "Spreadsheet")]
        [Description("Spreadsheet type indicates that the email attachment is a file that contains data organized in rows and columns, typically used for calculations, data analysis, and reporting.")]
        Spreadsheet,
        [Display(Name = "Presentation")]
        [Description("Presentation type indicates that the email attachment is a file that contains slides or visual content, typically used for delivering information in a structured and visually appealing format.")]
        Presentation,
        [Display(Name = "Image")]
        [Description("Image type indicates that the email attachment is a file that contains visual content, such as photographs, graphics, or illustrations.")]
        Image,
        [Display(Name = "PDF")]
        [Description("PDF type indicates that the email attachment is a file in Portable Document Format, typically used for sharing documents that preserve formatting across different devices and platforms.")]
        PDF,
        [Display(Name = "Other")]
        [Description("Other type indicates that the email attachment is a file that does not fall into the predefined categories.")]
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown type indicates that the email attachment type is not specified or cannot be determined.")]
        Unknown

    }
}