using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TarotOfDestiny.Migrations
{
    /// <inheritdoc />
    public partial class IlkMSSQL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomePageContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MainHeading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubHeading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderPageContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NameLabel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmailLabel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuestionLabel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubmitButtonText = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SuccessMessageFormat = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ErrorMessageFormat = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPageContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderSubmissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSubmissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TarotCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meaning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SongEmbedUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarotCards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HomePageContents",
                columns: new[] { "Id", "CreatedAt", "MainHeading", "PageTitle", "SubHeading", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evrenin sana göndereceği mesajı keşfet.", "Kader Kutusu - Ana Sayfa", "Kutunun kedisi bugün senin kartını seçti.", new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "OrderPageContents",
                columns: new[] { "Id", "CreatedAt", "EmailLabel", "ErrorMessageFormat", "NameLabel", "QuestionLabel", "SubmitButtonText", "Subtitle", "SuccessMessageFormat", "Title", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Email Address", "Please fill in all fields.", "Your Name", "Your Question", "Submit Reading Request 🔮", "Unlock the mysteries of your destiny with a custom tarot reading", "Thank you, {0}! Your personalized tarot reading will be prepared within 24 hours. We'll send your mystical insights to your email address.", "✨ Get Your Personalized Tarot Reading", new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TarotCards",
                columns: new[] { "Id", "BackImageUrl", "CreatedAt", "FullDescription", "ImageUrl", "Meaning", "Name", "Number", "SongEmbedUrl", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Fool represents new beginnings, innocence, spontaneity, and a leap of faith. This card encourages you to embrace the unknown with optimism and trust in the journey ahead. It symbolizes the pure potential of new experiences and the courage to step into uncharted territory.", "/images/fool.svg", "New beginnings, innocence, spontaneity, and a leap of faith.", "The Fool", 0, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Magician represents manifestation, willpower, skill, and the power to create your reality. This card shows that you have all the tools and resources needed to achieve your goals. It encourages you to take action and use your talents to manifest your desires.", "/images/magician.svg", "Manifestation, willpower, skill, and the power to create your reality.", "The Magician", 1, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The High Priestess represents intuition, subconscious knowledge, mystery, and spiritual insight. This card encourages you to trust your inner voice and pay attention to your dreams and intuition. It symbolizes the hidden knowledge that comes from within.", "/images/high-priestess.svg", "Intuition, subconscious knowledge, mystery, and spiritual insight.", "The High Priestess", 2, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Empress represents fertility, abundance, creativity, and nurturing energy. This card symbolizes the divine feminine and the power of creation. It encourages you to embrace your creative side and nurture your projects and relationships with love and care.", "/images/empress.svg", "Fertility, abundance, creativity, and nurturing energy.", "The Empress", 3, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Emperor represents authority, structure, leadership, and establishing order. This card encourages you to take charge of your life and create stability through discipline and organization. It symbolizes the power of structure and the importance of setting boundaries.", "/images/emperor.svg", "Authority, structure, leadership, and establishing order.", "The Emperor", 4, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hierophant represents tradition, spiritual guidance, learning, and conventional wisdom. This card encourages you to seek knowledge from established sources and follow traditional paths of learning. It symbolizes the importance of spiritual guidance and structured learning.", "/images/hierophant.svg", "Tradition, spiritual guidance, learning, and conventional wisdom.", "The Hierophant", 5, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lovers represents love, relationships, choices, and harmony between opposites. This card encourages you to make choices based on love and to seek harmony in your relationships. It symbolizes the power of love to unite different aspects of life.", "/images/lovers.svg", "Love, relationships, choices, and harmony between opposites.", "The Lovers", 6, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Chariot represents determination, willpower, victory, and overcoming obstacles. This card encourages you to stay focused on your goals and use your willpower to overcome challenges. It symbolizes the power of determination to achieve success.", "/images/chariot.svg", "Determination, willpower, victory, and overcoming obstacles.", "The Chariot", 7, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Strength represents inner strength, courage, patience, and compassion. This card encourages you to find strength within yourself and to approach challenges with patience and compassion. It symbolizes the power of inner strength over physical force.", "/images/strength.svg", "Inner strength, courage, patience, and compassion.", "Strength", 8, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hermit represents soul-searching, introspection, inner guidance, and wisdom. This card encourages you to take time for self-reflection and to seek answers within yourself. It symbolizes the importance of inner wisdom and spiritual guidance.", "/images/hermit.svg", "Soul-searching, introspection, inner guidance, and wisdom.", "The Hermit", 9, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wheel of Fortune represents change, cycles, destiny, and the turning of fate. This card reminds you that life is cyclical and that change is inevitable. It encourages you to embrace the ups and downs of life and trust in the natural flow of destiny.", "/images/wheel-of-fortune.svg", "Change, cycles, destiny, and the turning of fate.", "Wheel of Fortune", 10, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justice represents fairness, truth, balance, and karmic justice. This card encourages you to seek truth and fairness in all your dealings. It symbolizes the importance of balance and the concept that what goes around comes around.", "/images/justice.svg", "Fairness, truth, balance, and karmic justice.", "Justice", 11, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hanged Man represents sacrifice, letting go, new perspectives, and spiritual growth. This card encourages you to let go of what no longer serves you and to see things from a different perspective. It symbolizes the power of surrender and spiritual enlightenment.", "/images/hanged-man.svg", "Sacrifice, letting go, new perspectives, and spiritual growth.", "The Hanged Man", 12, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death represents transformation, endings, change, and rebirth. This card encourages you to embrace change and let go of what needs to end. It symbolizes the natural cycle of death and rebirth that leads to transformation and new beginnings.", "/images/death.svg", "Transformation, endings, change, and rebirth.", "Death", 13, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temperance represents balance, moderation, patience, and finding middle ground. This card encourages you to find balance in all aspects of your life and to practice patience and moderation. It symbolizes the importance of harmony and the art of finding the right balance.", "/images/temperance.svg", "Balance, moderation, patience, and finding middle ground.", "Temperance", 14, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomePageContents");

            migrationBuilder.DropTable(
                name: "OrderPageContents");

            migrationBuilder.DropTable(
                name: "OrderSubmissions");

            migrationBuilder.DropTable(
                name: "TarotCards");
        }
    }
}
