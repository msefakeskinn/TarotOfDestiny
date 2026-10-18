using System.ComponentModel.DataAnnotations;

namespace TarotOfDestiny.Models
{
    public class TarotCard
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        public string? BackImageUrl { get; set; }

        [Required]
        public string Meaning { get; set; } = string.Empty;

        [Required]
        public string FullDescription { get; set; } = string.Empty;

        public string FortuneWhisper { get; set; } = string.Empty;

        public string ShortDescription { get; set; } = string.Empty;

        public string? SongEmbedUrl { get; set; } // Şarkı linki buraya gelecek

        public int Number { get; set; }

        // --- D�ZELT�LM�� KISIM BURASI ---
        // Art�k "= DateTime.Now" yok.
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
