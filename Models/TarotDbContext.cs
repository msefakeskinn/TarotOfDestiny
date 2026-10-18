using Microsoft.EntityFrameworkCore;

namespace TarotOfDestiny.Models
{
    public class TarotDbContext : DbContext
    {
        public TarotDbContext(DbContextOptions<TarotDbContext> options) : base(options)
        {
        }

        public DbSet<TarotCard> TarotCards { get; set; }
        public DbSet<HomePageContent> HomePageContents { get; set; }
        public DbSet<OrderSubmission> OrderSubmissions { get; set; }
        public DbSet<OrderPageContent> OrderPageContents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TarotCard>().HasData(TarotCardSeedData.GetAll());

            modelBuilder.Entity<HomePageContent>().HasData(
                new HomePageContent 
                { 
                    Id = 1, 
                    PageTitle = "Kader Kutusu - Ana Sayfa", 
                    MainHeading = "Evrenin sana göndereceği mesajı keşfet.",
                    SubHeading = "Kutunun kedisi bugün senin kartını seçti.",
                    CreatedAt = new DateTime(2025, 10, 25),
                    UpdatedAt = new DateTime(2025, 10, 25)
                }
            );

            modelBuilder.Entity<OrderPageContent>().HasData(
                new OrderPageContent 
                { 
                    Id = 1, 
                    Title = "✨ Get Your Personalized Tarot Reading",
                    Subtitle = "Unlock the mysteries of your destiny with a custom tarot reading",
                    NameLabel = "Your Name",
                    EmailLabel = "Email Address",
                    QuestionLabel = "Your Question",
                    SubmitButtonText = "Submit Reading Request 🔮",
                    SuccessMessageFormat = "Thank you, {0}! Your personalized tarot reading will be prepared within 24 hours. We'll send your mystical insights to your email address.",
                    ErrorMessageFormat = "Please fill in all fields.",
                    CreatedAt = new DateTime(2025, 10, 25),
                    UpdatedAt = new DateTime(2025, 10, 25)
                }
            );
        }
    }
}
