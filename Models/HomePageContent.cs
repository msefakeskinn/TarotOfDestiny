using System.ComponentModel.DataAnnotations;

namespace TarotOfDestiny.Models
{
    public class HomePageContent
    {
        public int Id { get; set; }

        // Optional: For browser tab title
        [StringLength(200)]
        public string? PageTitle { get; set; }

        // For "Evrenin sana göndereceği mesajı keşfet."
        public string? MainHeading { get; set; }

        // For "Kutunun kedisi bugün senin kartını seçti."
        public string? SubHeading { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
