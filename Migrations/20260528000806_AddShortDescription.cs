using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TarotOfDestiny.Migrations
{
    /// <inheritdoc />
    public partial class AddShortDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "TarotCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShortDescription",
                value: "Toprağın Sarsılmaz Sabrı.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShortDescription",
                value: "Ateşin Durdurulamaz Hareketi.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShortDescription",
                value: "Maddi ve Manevi Zirve.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 4,
                column: "ShortDescription",
                value: "Alma-Verme Dengesi.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 5,
                column: "ShortDescription",
                value: "Güvenli Sınırlar ve Kontrol.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "ShortDescription",
                value: "Ustalık ve Gelecek İnşası.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "ShortDescription",
                value: "Taze Somut Başlangıç.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "ShortDescription",
                value: "Zamanın Dinamik Ritmi.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 9,
                column: "ShortDescription",
                value: "Yetenek ve Prestijli Ortaklık.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 10,
                column: "ShortDescription",
                value: "Olgun Hasat Bekleyişi.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "ShortDescription",
                value: "Fikirlerin Cesur Mücadelesi.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "ShortDescription",
                value: "Zirvedeki Mutlak Zafer.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 13,
                column: "ShortDescription",
                value: "Köklü Huzur ve Kutlama.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 14,
                column: "ShortDescription",
                value: "Geçici Zorluk ve Çıkış Yolu.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 15,
                column: "ShortDescription",
                value: "Zirvede Yenilmez Savunma.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "ShortDescription",
                value: "Sarsılmaz Finansal Otorite.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 17,
                column: "ShortDescription",
                value: "Son Düzlükteki Azim.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 18,
                column: "ShortDescription",
                value: "Kutsal İttifak ve Ruh İkizi.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 19,
                column: "ShortDescription",
                value: "Neşeli Dostluk Kutlaması.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 20,
                column: "ShortDescription",
                value: "Derin Ruhsal Bilgelik.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 21,
                column: "ShortDescription",
                value: "Saf Duygusal Uyanış.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 22,
                column: "ShortDescription",
                value: "Bağımsızlık ve Görkemli Lüks.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 23,
                column: "ShortDescription",
                value: "Geleceğe Dönüşen Şifa.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 24,
                column: "ShortDescription",
                value: "Karizma ve Çekim Gücü.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 25,
                column: "ShortDescription",
                value: "Bulutların Arkasındaki Fırsat.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 26,
                column: "ShortDescription",
                value: "Gerçeklerle Özgürleşme.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 27,
                column: "ShortDescription",
                value: "Büyük Vizyoner Liderlik.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 28,
                column: "ShortDescription",
                value: "Aydınlığa Doğru Yolculuk.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 29,
                column: "ShortDescription",
                value: "Saf Niyetlerin Ödülü.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 30,
                column: "ShortDescription",
                value: "Zihinsel Kalkan ve Uyanış.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 31,
                column: "ShortDescription",
                value: "Olasılıklar ve Somut Seçim.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 32,
                column: "ShortDescription",
                value: "Stratejik İçsel Sakinlik.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 33,
                column: "ShortDescription",
                value: "Zihni Nadasa Bırakma.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 34,
                column: "ShortDescription",
                value: "Keskin İrade Zaferi.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 35,
                column: "ShortDescription",
                value: "Gözbağlarını Çözen Akıl.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 36,
                column: "ShortDescription",
                value: "Deha ve Gizli Strateji.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 37,
                column: "ShortDescription",
                value: "Geniş Ufuklar ve Gelecek.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 38,
                column: "ShortDescription",
                value: "Yüksek İvme ve Hızlı Haber.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 39,
                column: "ShortDescription",
                value: "Sislerin Arkasındaki Gerçek.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 40,
                column: "ShortDescription",
                value: "Durağanlığı Kıran Teklif.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 41,
                column: "ShortDescription",
                value: "Büyüleyici Duygusal Sezgiler.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 42,
                column: "ShortDescription",
                value: "Fırtınasız Deniz Sakinliği.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 43,
                column: "ShortDescription",
                value: "Huzurlu Kıyılara Geçiş.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 44,
                column: "ShortDescription",
                value: "Tutkulu Duygusal Teklif.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 45,
                column: "ShortDescription",
                value: "Dileklerin Mutlak Gerçekleşmesi.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 46,
                column: "ShortDescription",
                value: "Tavizsiz Zeka Gücü.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 47,
                column: "ShortDescription",
                value: "Eksiksiz Aile Doyumu.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 48,
                column: "ShortDescription",
                value: "Adalet ve Radikal Karar.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 49,
                column: "ShortDescription",
                value: "Korkusuz Beyaz Sayfa.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 50,
                column: "ShortDescription",
                value: "Sihirli Yaratım Gücü.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 51,
                column: "ShortDescription",
                value: "Yüklerden Arınan Şafak.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 52,
                column: "ShortDescription",
                value: "Sonsuz Bolluk ve İhtişam.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 53,
                column: "ShortDescription",
                value: "Çelik İrade ve Otorite.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 54,
                column: "ShortDescription",
                value: "Perde Arkasındaki Sırlar.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 55,
                column: "ShortDescription",
                value: "Küresel Açılım Kararı.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 56,
                column: "ShortDescription",
                value: "Ateşli ve İlhamlı Başlangıç.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 57,
                column: "ShortDescription",
                value: "Verimli Bereket ve Güven.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 58,
                column: "ShortDescription",
                value: "Derin Ruhsal Uyanış.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 59,
                column: "ShortDescription",
                value: "Hesaplaşma ve Yeniden Doğuş.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 60,
                column: "ShortDescription",
                value: "Korkuların Ötesindeki Sezgiler.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 61,
                column: "ShortDescription",
                value: "Bütünleşme ve Büyük Zafer.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 62,
                column: "ShortDescription",
                value: "İlahi Terazi ve Hak Ediş.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 63,
                column: "ShortDescription",
                value: "En Parlak Bereket Dönemi.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 64,
                column: "ShortDescription",
                value: "Kördüğümleri Kıran İrade.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 65,
                column: "ShortDescription",
                value: "Güneşe Dönen Arınma.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 66,
                column: "ShortDescription",
                value: "Harika Enerjiler ve Sürpriz.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 67,
                column: "ShortDescription",
                value: "Görünmez Bağların Gerçeği.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 68,
                column: "ShortDescription",
                value: "Karanlığı Aydınlatan Yıldız.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 69,
                column: "ShortDescription",
                value: "Ani ve Şanslı Teklif.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 70,
                column: "ShortDescription",
                value: "Yıkılan Duvarlar ve Özgürlük.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 71,
                column: "ShortDescription",
                value: "Zincirleri Kıran İrade.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 72,
                column: "ShortDescription",
                value: "Finansal ve Manevi Konfor.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 73,
                column: "ShortDescription",
                value: "Dönüşüm ve Yeniden Başlangıç.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 74,
                column: "ShortDescription",
                value: "Lüks ve Bağımsız Hayat.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 75,
                column: "ShortDescription",
                value: "İçsel Bilge Feneri.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 76,
                column: "ShortDescription",
                value: "Durdurulamaz Zafer Yolculuğu.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 77,
                column: "ShortDescription",
                value: "Mükemmel İçsel Uyum.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 78,
                column: "ShortDescription",
                value: "Kutsal Seçim ve Aşk.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "TarotCards");
        }
    }
}
