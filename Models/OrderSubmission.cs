using System.ComponentModel.DataAnnotations;

namespace TarotOfDestiny.Models
{
    public class OrderSubmission
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Question { get; set; } = string.Empty;

        public DateTime SubmissionDate { get; set; }
    }
}
