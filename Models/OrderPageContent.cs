using System.ComponentModel.DataAnnotations;

namespace TarotOfDestiny.Models
{
    public class OrderPageContent
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Subtitle { get; set; }

        [Required]
        [StringLength(100)]
        public string NameLabel { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string EmailLabel { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string QuestionLabel { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string SubmitButtonText { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string SuccessMessageFormat { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string ErrorMessageFormat { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}


