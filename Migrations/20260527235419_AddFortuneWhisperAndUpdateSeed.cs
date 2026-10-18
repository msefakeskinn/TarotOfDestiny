using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TarotOfDestiny.Migrations
{
    /// <inheritdoc />
    public partial class AddFortuneWhisperAndUpdateSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.AddColumn<string>(
                name: "FortuneWhisper",
                table: "TarotCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Unutma, sabırla beslenen her niyet en güzel meyveyi verir; yakında gelecek büyük bolluğa yer aç.", "", "İçinden geçtiğin bu dönem, tam olarak emeklerinin karşılığını alma ve hedeflerine emin adımlarla ilerleme vakti. Kutundaki yüzük ve bileklik, bu kararlı enerjiyi hayatına sabitlemek için sana gönderildi; şimdi onları tak ve adımlarındaki kalıcı başarıyı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Cesaretle çıktığın bu yol seni hayallerine şak diye ulaştıracak; yakında hayatına girecek büyük heyecanlara hazır ol.", "", "Enerjin bize şu an cesaretle harekete geçme, içindeki ateşi ve potansiyeli dışarı vurma zamanı olduğunu söylüyor. Kutundaki yüzük ve bileklik, bu durdurulamaz gücü sabitlemek için elinde; şimdi onları tak ve adımlarındaki özgüveni hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Sağlam temeller üzerine kurulan her mutluluk ömürlük olur; yakında hayatına akacak büyük konfora yer aç.", "", "Bugün gökyüzü senin için parlıyor; çünkü maddi ve manevi doyuma ulaşma, sarsılmaz kökler kurma evresindesin. Kutundaki yüzük ve bileklik, bu köklü bereketi hayatına mühürlemek için sana ulaştı; şimdi onları tak ve hayatındaki kalıcı gücü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Evrene ne verirsen sana katlanarak geri döner; yakında karşına çıkacak cömert fırsatlara kapını aç.", "", "Şu sıralar etrafını saran cömert enerji, alma-verme dengesini kurup paylaştıkça çoğalacağını fısıldıyor. Kutundaki yüzük ve bileklik, evrenin koruyucu adaletini hayatına sabitlemek için sana gönderildi; şimdi onları tak ve dengeli akışı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Korkularını serbest bıraktığında, elindekilerden çok daha büyüğü hayatına akacak; yeni mucizelere güven.", "", "Kader çarkı senin için dönüyor; şu an sahip olduklarını koruma, enerjini ve kaynaklarını tamamen güvene alma safhasındasın. Kutundaki yüzük ve bileklik, bu koruyucu kalkanı hayatına sabitlemek için seninle; şimdi onları tak ve güçlü kontrolü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Detaylara verdiğin önem gözden kaçmadı; üzerinde çalıştığın o şey, yakında en parlak zaferine dönüşecek.", "", "Ruhun şu an tam olarak ustalaşmaya, odaklanmaya ve büyük bir titizlikle geleceğini inşa etmeye kilitlenmiş durumda. Kutundaki yüzük ve bileklik, bu üretken frekansı hayatına sabitlemek için sana gönderildi; şimdi onları tak ve emeğinin çekim gücünü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Önünde açılan bu kapı sadece bir başlangıç; cesaretle adım at, finansal şans rüzgarları senden yana esiyor.", "", "Avuçlarına bırakılan taze bir şans var; finansal fırsatlarla dolu somut ve yepyeni bir başlangıcın tam eşiğindesin. Kutundaki yüzük ve bileklik, bu doğurgan bereketi hayatına sabitlemek için sana ulaştı; şimdi onları tak ve yeni dünyanın gücünü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Aynı anda birkaç cephede savaşsan da hepsini yönetebilecek güçtesin; içindeki ritme güven.", "", "Hayatın dinamik ritmi seni çağırıyor; şu an dengeleri ustaca koruma, esneklik sağlama ve akışa uyum sağlama sürecindesin. Kutundaki yüzük ve bileklik, bu dinamik kontrolü hayatına sabitlemek için sana gönderildi; şimdi onları tak ve kaosun içindeki dengeyi hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Ortaya koyduğun vizyon doğru insanların dikkatini çekti; yakında büyük bir projede parlayacaksın.", "", "İçinden geçtiğin bu dönem, yeteneklerini sergileyerek doğru iş birlikleri kurma ve takdir toplayarak yükselme vakti. Kutundaki yüzük ve bileklik, bu prestijli enerjiyi hayatına sabitlemek için sana ulaştı; şimdi onları tak ve saygın gücü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Emeklerin asla boşa gitmedi, sadece toprağın altında olgunlaşıyorlar; beklediğin o büyük ödül kapıda.", "", "Enerjin bize şu an sabırla bekleme, ektiklerini değerlendirme ve doğru zamanlama yapma olgunluğunda olduğunu gösteriyor. Kutundaki yüzük ve bileklik, bu bilge hasat enerjisini hayatına sabitlemek için elinde; şimdi onları tak ve huzurlu bekleyişi hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Bu rekabet seni sadece daha güçlü yapacak; içindeki ateşi söndürme, liderlik koltuğu senin.", "", "Bugün gökyüzü seni fikirlerini savunmaya davet ediyor; karmaşanın içinden sıyrılıp kendini kanıtlama evresindesin. Kutundaki yüzük ve bileklik, bu hırslı mücadele gücünü hayatına sabitlemek için sana gönderildi; şimdi onları tak ve dik duruşu hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Hak ettiğin o büyük takdir ve popülerlik nihayet geliyor; gururla başını dik tut, bugün senin günün.", "", "Şu sıralar adımların mutlak bir zafere çıkıyor; herkes tarafından alkışlanma ve başarınla zirveye oturma dönemindesin. Kutundaki yüzük ve bileklik, bu muzaffer frekansı hayatına sabitlemek için sana ulaştı; şimdi onları tak ve parıltını hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Özlemini duyduğun o güzel haber kapını çalmak üzere; hayatına giren bu istikrarın tadını çıkar.", "", "Kader çarkı senin için neşeli dönüyor; uzun süredir beklediğin emniyete ulaşma ve sevdiklerinle kutlama yapma safhasındasın. Kutundaki yüzük ve bileklik, bu köklü huzuru hayatına sabitlemek için seninle; şimdi onları tak ve sıcaklığı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Kafanı kaldır ve etrafına bak, yalnız değilsin; aradığın o çıkış yolu tam arkanda duruyor.", "", "Ruhun şu an geçici bir zorluğu aşmaya çalışıyor; eksiklik hissini geride bırakıp asıl desteği bulma sürecindesin. Kutundaki yüzük ve bileklik, bu dirençli ve koruyucu gücü hayatına sabitlemek için sana gönderildi; şimdi onları tak ve yeni güveni hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Yukarıdasın ve herkes seni izliyor; geri adım atma, bu duruşunla tüm engelleri dize getireceksin.", "", "İçinden geçtiğin bu günler, pozisyonunu koruma, inançlarını savunma ve baskılara karşı tek başına meydan okuma vakti. Kutundaki yüzük ve bileklik, bu yenilmez savunma gücünü hayatına sabitlemek için sana ulaştı; şimdi onları tak ve zirvedeki gücü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Maddi kaygılar dönemi senin için tamamen kapanıyor; evren bolluk kapılarını ardına kadar açtı.", "", "Enerjin bize finansal gücü tamamen eline alma, mutlak güvenceyi sağlama ve kendi imparatorluğunu ilan etme zamanının geldiğini söylüyor. Kutundaki yüzük ve bileklik, bu zenginliği hayatına sabitlemek için elinde; şimdi onları tak ve sarsılmaz otoriteyi hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Yoruldun ama bitmedi; bu son engeli de aştığında, ömür boyu gurur duyacağın bir başarı hikayesi yazacaksın.", "", "Bugün gökyüzü sana pes etmemeni söylüyor; son düzlüğe girdiğin, son engeli azimle aşarak zafere ulaşacağın evredesindir. Kutundaki yüzük ve bileklik, bu tükenmez dayanıklılığı hayatına sabitlemek için sana gönderildi; şimdi onları tak ve içindeki kahramanı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Kalbinin ritmini değiştirecek o büyük ittifak kuruluyor; hayatının en güzel ortaklığına hazır ol.", "", "Şu sıralar kalbin kusursuz bir çekim gücüyle doluyor; ruh ikizini bulma, derin ve saf bir gönül bağı kurma dönemindesin. Kutundaki yüzük ve bileklik, bu kutsal aşk enerjisini hayatına sabitlemek için sana ulaştı; şimdi onları tak ve uyumun tadını hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Kadehini mutluluğa kaldır; çok yakında sevdiklerinle omuz omuza harika bir başarıyı kutlayacaksınız.", "", "Kader çarkı senin için neşeyle dönüyor; dostlarınla bir araya gelme, sosyalleşme ve büyük bir mutluluğu paylaşma safhasındasın. Kutundaki yüzük ve bileklik, bu pozitif frekansı hayatına sabitlemek için seninle; şimdi onları tak ve hayattaki tatlı kutlamayı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Doğru yoldasın ve evrenin görünmez elleriyle korunuyorsun; iç sesinin onayladığı kararı güvenle uygula.", "", "Ruhun şu an derin bir bilgelik kazanma, geleneklerden güç alma ve ruhsal bir rehberlikle korunma sürecinde. Kutundaki yüzük ve bileklik, bu saygın ve kutsal enerjiyi hayatına sabitlemek için sana gönderildi; şimdi onları tak ve sarsılmaz doğruluğu hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "İçindeki tüm kırgınlıklar tamamen şifalanıyor; kalbini aç, hayatının en büyük sevgisi sana akıyor.", "", "İçinden geçtiğin bu dönem, duygusal bir uyanış yaşama, sevgiyle taşma ve yepyeni bir aşka yelken açma vakti. Kutundaki yüzük ve bileklik, bu şifalı enerji dalgasını hayatına sabitlemek için sana ulaştı; şimdi onları tak ve yüreğindeki taze heyecanı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Kimseye ihtiyacın yok, kendi cennetini kendi ellerinle kurdun; yakında bu konforun sınırları daha da genişleyecek.", "", "Enerjin bize bağımsızlığını ilan etme, lüksün ve tek başına elde ettiğin o muazzam başarının tadını çıkarma vaktini gösteriyor. Kutundaki yüzük ve bileklik, bu asil ve konforlu gücü sabitlemek için elinde; şimdi onları tak ve kendine yeten duruşu hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Dökülenler gitsin, senin için asıl büyük ve sağlam olanlar hala ayakta; yüzünü geleceğe dön, umut orada.", "", "Bugün gökyüzü sana geçmiş kayıplara takılmayı bırakmanı söylüyor; arkandaki gizli güzellikleri fark edip şifalanma evresindesin. Kutundaki yüzük ve bileklik, bu tazeleyici dönüşümü hayatına sabitlemek için sana gönderildi; şimdi onları tak ve dopdolu kupaları hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Gözler senin üzerinde ve girdiğin her ortamı domine ediyorsun; bu auranla isteyip de elde edemeyeceğin hiçbir şey yok.", "", "Şu sıralar karizmanla etrafını büyülüyor, çekim gücünü zirveye taşıyor ve tüm liderliği ele alıyorsun. Kutundaki yüzük ve bileklik, bu ateşli ve özgüvenli gücü hayatına sabitlemek için sana ulaştı; şimdi onları tak ve adımlarındaki büyüleyici etkiyi hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Bulutların arasından uzatılan o gizli kadehi gör; aradığın büyük heyecan tam şu an burnunun ucunda.", "", "Kader çarkı seni rutinlerden sıyrılmaya çağırıyor; içe çekildiğin ama aslında evrenin sunduğu gizli fırsatı fark edeceğin safhasındasın. Kutundaki yüzük ve bileklik, bu uyandırıcı enerjiyi hayatına sabitlemek için seninle; şimdi onları tak ve vizyonunu genişlet." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Fırtına dindi, canını acıtan tüm illüzyonlar bitti; şimdi eskisinden çok daha bilge ve yıkılmaz ayağa kalkıyorsun.", "", "Ruhun şu an bir hayal kırıklığını şifalandırma, gerçeklerle cesaretle yüzleşme ve zihnen özgürleşme sürecinde. Kutundaki yüzük ve bileklik, bu koruyucu kalkanı hayatına sabitlemek için sana gönderildi; şimdi onları tak ve kalbindeki yüklerin hafiflediğini hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Aklına koyduğun o büyük hedefi gerçekleştirmek için her şeye sahipsin; tüm oyun senin kurallarına göre oynanacak.", "", "İçinden geçtiğin bu günler, büyük vizyonlar kurma, cesaretle kararlar verme ve kendi krallığını yönetme vakti. Kutundaki yüzük ve bileklik, bu karmatik liderlik enerjisini hayatına sabitlemek için sana ulaştı; şimdi onları tak ve adımlarındaki sarsılmaz gücü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Gitmeyi seçtiğin o yeni yol, arkanda bıraktığın her şeyden fersah fersah daha güzel; ruhunu aydınlığa taşı.", "", "Enerjin bize sana hizmet etmeyen her şeyi arkanda bırakma ve daha yüksek bir arayış için cesaretle yola çıkma zamanını fısıldıyor. Kutundaki yüzük ve bileklik, bu olgun dönüşümü sabitlemek için elinde; şimdi onları tak ve adımlarındaki özgürlüğü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Geçmişten gelen tatlı bir esinti, hayatındaki bir kördüğümü çözecek; saf niyetlerinin ödülünü toplama vaktin geldi.", "", "Bugün gökyüzü seni geçmişten güç almaya, eski bir dostla veya saf bir duyguyla yeniden buluşmaya davet ediyor. Kutundaki yüzük ve bileklik, bu samimi sevgiyi hayatına sabitlemek için sana gönderildi; şimdi onları tak ve içindeki neşeyi hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Korktuğun hiçbir şey gerçek değil, sadece zihninin bir oyunu; gözlerini aç, güneş senin için çoktan doğdu.", "", "Şu sıralar yersiz tüm endişeleri geride bırakıyor, zihnindeki hayali canavarlardan tamamen özgürleşiyorsun. Kutundaki yüzük ve bileklik, bu zihinsel kalkanı ve uyanış gücünü hayatına sabitlemek için sana ulaştı; şimdi onları tak ve gecenin karanlığından sıyrılan aydınlığı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Hayaller güzeldir ama artık somutlaştırma vakti; kalbinin en derinden seçtiği o tek şeye odaklan.", "", "Kader çarkı sana illüzyonları ayırt etme ve seçenekler arasından en doğru, en net olanı seçme gücü veriyor. Kutundaki yüzük ve bileklik, bu odaklı vizyonu hayatına sabitlemek için seninle; şimdi onları tak ve sislerin arkasındaki gerçeği gör." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Bırak herkes kazandığını sansın; senin asıl zaferin, bu sakinlikle geleceği tamamen kontrol altına alman olacak.", "", "Ruhun şu an haklı çıkma savaşlarını tamamen bırakıp, asıl huzuru ve stratejik üstünlüğü seçmeye odaklanmış durumda. Kutundaki yüzük ve bileklik, bu zihinsel dinginliği hayatına sabitlemek için sana gönderildi; şimdi onları tak ve çatışmaların üzerindeki kontrolü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Sessizlik zayıflık değil, en büyük stratejidir; zihnini nadasa bırak, yakında büyük kararlarla parlayacaksın.", "", "İçinden geçtiğin bu dönem, tamamen geri çekilip dinlenme, zihnini arındırma ve yeni hamleler öncesi güç toplama vakti. Kutundaki yüzük ve bileklik, bu şifalı ve dingin enerjiyi hayatına sabitlemek için sana ulaştı; şimdi onları tak ve ruhundaki kusursuz barışı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Tüm belirsizlik saniyeler içinde yok oluyor; kılıcını kuşan ve o radikal kararı al, evren arkanda duruyor.", "", "Enerjin bize mutlak bir netlik kazanma, doğruları şak diye kesip atma ve zihinsel bir zafer yaşama döneminde olduğunu fısıldıyor. Kutundaki yüzük ve bileklik, bu keskin irade gücünü sabitlemek için elinde; şimdi onları tak ve aklındaki sarsılmaz doğruluğu hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Daha fazla erteleyemezsin; içindeki sese güven ve o seçimi yap, adımı attığın an yol önünde çiçek gibi açılacak.", "", "Bugün gökyüzü sana gözündeki bağları çözmeni söylüyor; kararsızlığı bitirme ve mantığınla net bir seçim yapma evresindesin. Kutundaki yüzük ve bileklik, bu dengeli mantık gücünü hayatına sabitlemek için sana gönderildi; şimdi onları tak ve akıl ile kalp arasındaki uyumu hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Gücün kaba kuvvette değil, dehanda saklı; oyununu sessizce kur, herkes senin hamleni ayakta alkışlayacak.", "", "Şu sıralar zekanı konuşturma, stratejik davranma ve çevrendeki tüm gizli niyetleri şak diye çözme gücüne sahipsin. Kutundaki yüzük ve bileklik, bu keskin algı kalkanını hayatına sabitlemek için sana ulaştı; şimdi onları tak ve görünmez hamlelerindeki kontrolü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Yola çıkardığın niyetler katlanarak geri dönüyor; gözlerini ufuktan ayırma, beklediğin o büyük fırsat gemisi geliyor.", "", "Kader çarkı sana vizyonunu genişletme, uzakları planlama ve ufuktan gelecek büyük fırsatları bekleme gücü veriyor. Kutundaki yüzük ve bileklik, bu vizyoner enerjiyi hayatına sabitlemek için seninle; şimdi onları tak ve gelecekteki mutlak başarının güvenini hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Geciken ne varsa aynı anda ve hızla hayatına akacak; kemerlerini bağla, hayatının en şanslı dönemi başlıyor.", "", "Ruhun şu an olayların inanılmaz hızlandığı, bekleyen tüm haberlerin şak diye geleceği bir ivmenin içinde. Kutundaki yüzük ve bileklik, bu yüksek hareket enerjisini hayatına sabitlemek için sana gönderildi; şimdi onları tak ve hayatındaki muazzam hızı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Sonsuz olasılıklar arasından kalbine en yakın olanı seç; o niyet, hayatının en somut dönüm noktası olacak.", "", "İçinden geçtiğin bu günler, seçeneklerini tamamen netleştirme, illüzyonlardan sıyrılıp somut adımlar atma vakti. Kutundaki yüzük ve bileklik, bu ayırt edici zeka gücünü hayatına sabitlemek için sana ulaştı; şimdi onları tak ve sislerin arkasındaki tek gerçeği hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Sıkıldığın o durağanlık tamamen bitiyor; karşına çıkan ilk teklife 'evet' de, hayatın bambaşka boyuta geçsin.", "", "Enerjin bize sıradanlıktan ve durağanlıktan sıyrılma, yanı başındaki gizli mucizeyi fark etme zamanının geldiğini söylüyor. Kutundaki yüzük ve bileklik, bu tazeleyici heyecanı sabitlemek için elinde; şimdi onları tak ve evrenin sunduğu o gizli kadehi hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "İç sesin asla yanılmaz; bugün kalbine doğan o gizemli hisse güven, çünkü evren seninle konuşuyor.", "", "Bugün gökyüzü seni sezgilerinin zirvesine taşıyor; derin bir şifa yaşama ve saf empati gücünle etrafını büyüleme evresindesin. Kutundaki yüzük ve bileklik, bu duygusal zenginliği hayatına sabitlemek için sana gönderildi; şimdi onları tak ve ruhunun gücünü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Duygularının esiri değil, efendisisin; bu içsel sakinliğin sayesinde en zorlu düğümleri bile şak diye çözeceksin.", "", "Şu sıralar tam bir duygusal olgunluğa ulaşıyor, tüm krizleri sakinlikle yönetiyor ve etrafına sarsılmaz bir güven veriyorsun. Kutundaki yüzük ve bileklik, bu kontrollü güç frekansını hayatına sabitlemek için sana ulaştı; şimdi onları tak ve ruhundaki fırtınasız denizi hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Zor olanı atlattın, şimdi zihnen ve bedenen dinlenme vakti; önündeki yeni hayat eskisinden çok daha huzurlu olacak.", "", "Kader çarkı seni hüzünlü ve yorucu dönemlerden çıkarıyor; daha sakin, daha huzurlu kıyılara doğru yelken açma safhasındasın. Kutundaki yüzük ve bileklik, bu şifalı geçiş enerjisini hayatına sabitlemek için seninle; şimdi onları tak ve fırtınanın bittiğini hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Beklediğin o duygusal haber veya teklif yola çıktı geliyor; kalbini sonuna kadar aç, aşk seninle.", "", "Ruhun şu an tamamen kalbinin sesini dinlemeye, romantik teklifleri kabul etmeye ve hayallerinin peşinden gitmeye hazır. Kutundaki yüzük ve bileklik, bu çekici ve tutkulu frekansı hayatına sabitlemek için sana gönderildi; şimdi onları tak ve akacak taze heyecanı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Ne dilediğine dikkat et çünkü gerçek olmak üzere; evren senin için tüm yıldızları yan yana dizdi.", "", "İçinden geçtiğin bu şanslı dönem, dileklerinin şak diye gerçekleşme, mutlak tatmine ve keyfe ulaşma vakti. Kutundaki yüzük ve bileklik, bu dopdolu başarı enerjisini hayatına sabitlemek için sana ulaştı; şimdi onları tak ve eksiksiz mutluluğu hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Gözyaşları bitti, şimdi tamamen akıl ve strateji zamanı; kimsenin seni manipüle etmesine izin verme.", "", "Enerjin bize tamamen keskin mantığınla hareket etme, sınırlarını çelik gibi çizme ve bağımsızlığınla parlama vaktini işaret ediyor. Kutundaki yüzük ve bileklik, bu tavizsiz zeka gücünü sabitlemek için elinde; şimdi onları tak ve sarsılmaz otoriteni hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Ruhundaki o derin yalnızlık hissi tamamen sona eriyor; sevdiklerinle kuracağın o sarsılmaz bağ ömürlük olacak.", "", "Bugün gökyüzü seni kusursuz bir aile huzuruna, büyük sevgilere ve ilişkilerde zirve noktaya davet ediyor. Tüm çatışmaların bittiği evredesindesin. Kutundaki yüzük ve bileklik, bu şanslı birliktelik frekansını hayatına sabitlemek için sana gönderildi; şimdi onları tak ve eksiksiz doyumu hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Sözlerin kanun gibi, zekan ise en büyük silahın; bugün alacağın o radikal karar seni kazanan yapacak.", "", "Şu sıralar mutlak adaleti sağlama, entelektüel gücünü kanıtlamaya ve hayatın için en doğru kararları verme dönemindesin. Kutundaki yüzük ve bileklik, bu güçlü mantık otoritesini hayatına sabitlemek için sana ulaştı; şimdi onları tak ve zihnindeki o sarsılmaz netliği hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Risk almaktan korkma, evren arkanda devasa bir koruma kalkanı oluşturdu; o ilk adımı at, mucizeler yolda.", "", "Kader çarkı senin için tüm geçmiş yükleri sıfırlıyor; cesaretle yepyeni, bembeyaz bir sayfaya özgürce atlama safhasındasın. Kutundaki yüzük ve bileklik, bu korkusuz başlangıç enerjisini hayatına sabitlemek için seninle; şimdi onları tak ve adımlarındaki hafifliği hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "İhtiyacın olan her şey zaten içinde mevcut; sadece odaklan ve iste, evren senin iradene şak diye boyun eğecek.", "", "Ruhun şu an elindeki tüm kaynakları gerçeğe dönüştürme, mucizeler yaratma ve yüksek çekim gücünü konuşturma sürecinde. Kutundaki yüzük ve bileklik, bu sihirli yaratım frekansını hayatına sabitlemek için sana gönderildi; şimdi onları tak ve kelimelerinin gücünü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "En dip noktayı gördün, bundan sonra tek bir yön var: Yukarıya yükselmek! Hayatının en parlak sabahı başlıyor.", "", "İçinden geçtiğin bu zorlu günler, sana yük olan bir dönemi tamamen bitirme ve arınarak yepyeni bir şafağa uyanma vakti. Kutundaki yüzük ve bileklik, bu dönüştürücü gücü hayatına sabitlemek için sana ulaştı; şimdi onları tak ve sırtındaki tüm yüklerin yok olduğunu hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Dokunduğun her şeyi altına çevirebilecek bir dönemdesin; içindeki güce inan, tüm güzellikler sana akıyor.", "", "Enerjin bize doğurganlığın, sonsuz bolluğun ve yaratıcı gücün zirvesinde parlayacağın o muazzam dönemin geldiğini söylüyor. Kutundaki yüzük ve bileklik, bu ihtişamlı dişil frekansı sabitlemek için elinde; şimdi onları tak ve hayatına akacak zengin sevgiyi hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Oyunun kurallarını sen koyuyorsun ve herkes sana saygı duyacak; vizyonundan taviz verme, imparatorluğun yükseliyor.", "", "Bugün gökyüzü seni mutlak otorite kurmaya, düzeni sağlamaya ve sarsılmaz bir liderlikle sınırlarını çizmeye çağırıyor. Güçlü bir evredesindesin. Kutundaki yüzük ve bileklik, bu koruyucu ve disiplinli gücü hayatına sabitlemek için sana gönderildi; şimdi onları tak ve adımlarındaki çelik iradeyi hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Şu an acele etme ve sessizce izle; evren sırlarını yakında senin önüne serecek, iç sesin her zaman haklıdır.", "", "Şu sıralar tüm gizemleri çözüyor, sezgilerine tamamen teslim oluyor ve perde arkasındaki tüm gerçekleri şak diye görüyorsun. Kutundaki yüzük ve bileklik, bu mistik ruhsal korumayı hayatına sabitlemek için sana ulaştı; şimdi onları tak ve içindeki büyük bilgeliği hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Bulunduğun yer artık sana dar geliyor; gözünü uzağa dik, yakında hayatında küresel bir açılım yaşayacaksın.", "", "Kader çarkı sana dünyayı avuçlarının içine alma, büyük planlar yapma ve sınırları aşma kararını verme cesareti sunuyor. Kutundaki yüzük ve bileklik, bu vizyoner genişleme gücünü hayatına sabitlemek için seninle; şimdi onları tak ve önündeki devasa kapıların heyecanını hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "İçindeki o muazzam fikir evreni harekete geçirdi; hiç bekleme, hemen başla, şans rüzgarı seni uçuracak.", "", "Ruhun şu an saf bir tutkuyla, yepyeni bir ilhamla ve muazzam bir enerji patlamasıyla anında harekete geçmeye hazır. Kutundaki yüzük ve bileklik, bu ateşli başlangıç gücünü hayatına sabitlemek için sana gönderildi; şimdi onları tak ve içindeki o durdurulamaz kıvılcımı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Finansal ve manevi olarak büyüme dönemindesin; attığın her somut adım sana katlanarak büyük bir servet olarak dönecek.", "", "İçinden geçtiğin bu verimli dönem, pratik zekanla üretme, konforlu bir dünya kurarak elindeki bereketi büyütme vakti. Kutundaki yüzük ve bileklik, bu asil ve sarsılmaz köklü enerjiyi hayatına sabitlemek için sana ulaştı; şimdi onları tak ve hayatındaki zengin güvenliği hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Bu duraklama bir yenilgi değil, stratejik bir geri çekilme; resmi yukarıdan görüyorsun, hamlen herkesi şaşırtacak.", "", "Enerjin bize olaylara bambaşka bir perspektiften bakma, derin bir aydınlanma yaşama ve fedakarlıkla güçlenme sürecinde olduğunu söylüyor. Kutundaki yüzük ve bileklik, bu bilge algı gücünü sabitlemek için elinde; şimdi onları tak ve ruhundaki derin uyanışı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Vicdanın rahat, kararların net; evren seni hak ettiğin o yüksek mertebeye taşımak için çağırıyor, geçmişi bırak.", "", "Bugün gökyüzü tüm geçmiş hesapları kapatmanı söylüyor; büyük bir uyanış çağrısını duyma ve küllerinden yeniden doğma evresindesin. Kutundaki yüzük ve bileklik, bu görkemli dönüşüm frekansını hayatına sabitlemek için sana gönderildi; şimdi onları tak ve mutlak özgürleşmeyi hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Sisin arkasındaki oyunlar çözülüyor, hiçbir şey göründüğü gibi değil; sadece kalbinin fısıltısına güven.", "", "Şu sıralar bilinçaltınla yüzleşiyor, tüm illüzyonları tek tek aşarak karanlığın içindeki gizli sezgileri dışarı çıkarıyorsun. Kutundaki yüzük ve bileklik, bu koruyucu gece kalkanını hayatına sabitlemek için sana ulaştı; şimdi onları tak ve korkuların ötesindeki asıl gücü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Tebrikler, tüm zorlu sınavlardan geçtin ve dünya artık senin etrafında dönüyor; muhteşem bir hayat seni bekliyor.", "", "Kader çarkı senin için büyük bir döngüyü zaferle tamamlıyor; mutlak başarıya, bütünleşmeye ve zirveye ulaşma safhasındasın. Kutundaki yüzük ve bileklik, bu kusursuz tamamlanma enerjisini hayatına sabitlemek için seninle; şimdi onları tak ve evrenin merkezindeki o tatmini hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "İçini ferah tut, evren teraziyi senin için kurdu; hakkın olan ne varsa katlanarak sana iade ediliyor.", "", "Ruhun şu an ilahi adaletin tecelli etmesini izliyor; geçmişte haksızlığa uğradığın ne varsa şak diye geri alma dönemindesin. Kutundaki yüzük ve bileklik, bu sarsılmaz denge gücünü hayatına sabitlemek için sana gönderildi; şimdi onları tak ve hakkın olanın gelişini hissederek yaşa." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Karanlık tamamen bitti, hayatının en bereketli ve sıcak dönemi başladı; parlamaya hazır ol, tüm gözler sende.", "", "İçinden geçtiğin bu aydınlık günler, saf neşeyle dolma, her alanda netlik kazanma ve muazzam bir başarıyla parlama vakti. Kutundaki yüzük ve bileklik, bu en şanslı güneş frekansını hayatına sabitlemek için sana ulaştı; şimdi onları tak ve auranın etrafı nasıl aydınlattığını hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Kafandaki tüm şüpheler saniyeler içinde yok oldu; o cesur kelimeyi söyle ve zaferini ilan et, evren arkanda.", "", "Enerjin bize mutlak zihinsel gücü eline alma, kafandaki tüm kördüğümleri tek bir hamleyle kesip atma zamanının geldiğini fısıldıyor. Kutundaki yüzük ve bileklik, bu zafer getiren irade gücünü sabitlemek için elinde; şimdi onları tak ve adımlarındaki sarsılmaz doğruluğu hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Gözyaşlarının bittiği yerde asıl mucize başlar; yüzünü güneşe dön, orada senin için hazırlanan muazzam bir sevgi var.", "", "Bugün gökyüzü tüm geçmiş nostaljileri ve hüzünleri tamamen serbest bırakmanı fısıldıyor; önündeki dopdolu geleceğe odaklanma evresindesin. Kutundaki yüzük ve bileklik, bu şifalı arınma frekansını hayatına sabitlemek için sana gönderildi; şimdi onları tak ve arkandaki asıl büyük desteği hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Yalnızlık dönemi bitti, hayatına harika enerjiler giriyor; yakında alacağın o muhteşem haberi kutlamaya hazır ol.", "", "Şu sıralar büyük başarıları kutlama, dostlarınla omuz omuza verip hayatın getirdiği saf neşeyle dolma dönemindesin. Kutundaki yüzük ve bileklik, bu yüksek sosyal yaşam frekansını hayatına sabitlemek için sana ulaştı; şimdi onları tak ve hayatın getirdiği tatlı sürprizleri hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Aramızdaki o görünmez bağlar bugün gerçeğe dönüşüyor; sevgiye güven, evren senin için en doğru senaryoyu yazdı.", "", "Kader çarkı seni ruhunun diğer yarısıyla buluşturuyor; ilişkilerde kusursuz bir uyum, çekim ve derin bir bağ yakalama safhasındasın. Kutundaki yüzük ve bileklik, bu tılsımlı sevgi bağını hayatına sabitlemek için seninle; şimdi onları tak ve kalbindeki taze heyecanı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Unutma, en parlak yıldızlar en karanlık gecelerde görünür; hayatına girmek üzere olan o büyük mucizeye yer aç.", "", "Ruhun şu an mutlak bir umutla dolma, tamamen şifalanma ve evrenin koruyucu ışığı altında parıldama sürecinde. Kutundaki yüzük ve bileklik, bu ilahi yıldız frekansını hayatına sabitlemek için sana gönderildi; şimdi onları tak ve ruhundaki muazzam yenilenmeyi hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Aradığın o büyük heyecan tam şu an burnunun ucunda; karşına çıkacak olan o fırsatı sakın kaçırma.", "", "İçinden geçtiğin bu günler, sıradanlıktan sıyrılma ve evrenin sana sunduğu o ani, gizli teklifleri cesaretle kabul etme vakti. Kutundaki yüzük ve bileklik, bu uyandırıcı şans enerjisini hayatına sabitlemek için sana ulaştı; şimdi onları tak ve vizyonunu genişlet." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Yıkılanlar sadece senin ayak bağı olan eski duvarlarındı; şimdi evren senin için çok daha görkemli bir saray inşa ediyor.", "", "Enerjin bize sana yük olan tüm eski illüzyonları sarsıcı bir hızla yıkma ve tamamen sağlam temellerle özgürleşme vaktinin geldiğini söylüyor. Kutundaki yüzük ve bileklik, bu kaotik geçişte seni koruyacak sarsılmaz bir tılsım olarak elinde; şimdi onları tak ve küllerinden doğan gücü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Korkularının seni yönetmesine izin verme, ipler senin elinde; gücünün farkına vardığında tüm engeller önünde diz çökecek.", "", "Bugün gökyüzü seni tüm bağımlılıklarından, korkularından sıyrılmaya ve gölgelerin üzerindeki mutlak kontrolü ele almaya çağırıyor. Kritik bir evredesindesin. Kutundaki yüzük ve bileklik, bu güçlü zihinsel özgürleşme kalkanını hayatına sabitlemek için sana gönderildi; şimdi onları tak ve zincirleri nasıl kırdığını hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Kimseye ihtiyacın yok, sen kendi başrolünü kendin yazdın; finansal ve manevi konforun yakında daha da katlanacak.", "", "Şu sıralar kendi cennetinde lüksün, bağımsızlığın ve tek başına tırnaklarınla kazandığın o muazzam güvencenin tadını çıkarıyorsun. Kutundaki yüzük ve bileklik, bu asil ve zengin frekansı hayatına sabitlemek için sana ulaştı; şimdi onları tak ve o gururlu duruşu hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Gidenler gitmeliydi, arkasından gelecek olanlar eskisinden fersah fersah daha muazzam; yeni hayatına gururla hoş geldin de.", "", "Kader çarkı senin için eskiyen, sana hizmet etmeyen bir dönemi kökten bitiriyor; büyük bir dönüşümle yeniden doğma safhasındasın. Kutundaki yüzük ve bileklik, bu güçlü yeniden var oluş enerjisini hayatına sabitlemek için seninle; şimdi onları tak ve taze adımlarındaki gücü hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Emeklerinin nihai ödülünü topluyorsun; hak ettiğin o lüks, konforlu ve bağımsız hayat şu an kapını çaldı.", "", "Ruhun şu an finansal özgürlüğe, mutlak saygınlığa ve kimseye muhtaç olmayan o devasa güce ulaşmanın eşiğinde. Kutundaki yüzük ve bileklik, bu en yüksek asalet ve zenginlik frekansını hayatına sabitlemek için sana gönderildi; şimdi onları tak ve adımlarındaki sarsılmaz güveni hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Aradığın tüm cevaplar dışarıda değil, kendi içinde saklı; o feneri yak ve kararlarını sessizce al, evren seni izliyor.", "", "İçinden geçtiğin bu gizemli dönem, kendi içine dönme, içindeki o bilge feneri yakma ve derin bir farkındalıkla şifalanma vakti. Kutundaki yüzük ve bileklik, bu koruyucu ve olgun ruhsal ışığı hayatına sabitlemek için sana ulaştı; şimdi onları tak ve ruhundaki o sarsılmaz doğruluğu hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Hedefine kilitlen ve arkana bakma; karşına çıkan hiçbir engel seni yavaşlatamaz, bu yolculuğun sonu mutlak zafer.", "", "Enerjin bize tüm hayat dizginlerini eline alma, zıtlıkları ustaca yönetme ve mutlak bir zafer yolculuğuna çıkma zamanının geldiğini haykırıyor. Kutundaki yüzük ve bileklik, bu muzaffer hareket enerjisini sabitlemek için elinde; şimdi onları tak ve adımlarındaki durdurulamaz hızı hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Acele etmene gerek yok, her şey olması gerektiği zamanda ve kusursuz bir dengeyle hayatına akıyor; evrene güven.", "", "Bugün gökyüzü seni içsel bir simya yapmaya, hayatındaki zıtlıkları kusursuzca harmanlamaya ve muazzam bir dinginliğe davet ediyor. Kusursuz bir evredesindesin. Kutundaki yüzük ve bileklik, bu sakinleştirici akışı hayatına sabitlemek için sana gönderildi; şimdi onları tak ve ruhundaki mükemmel uyumu hisset." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "FortuneWhisper", "FullDescription", "Meaning" },
                values: new object[] { "Kalbinin sesini dinleyerek alacağın o karar, hayatının en doğru ve en mutlu dönüm noktası olacak; sevgiye yer aç.", "", "Şu sıralar kalbinle en radikal seçimi yapma, tutkulu bir aşka korkusuzca teslim olma ve evrensel bir uyum yakalama dönemindesin. Kutundaki yüzük ve bileklik, bu kutsal ittifakı ve yüksek sevgi frekansını hayatına sabitlemek için sana ulaştı; şimdi onları tak ve ruhundaki o taze cazibeyi hisset." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FortuneWhisper",
                table: "TarotCards");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Yolun başındasın ve önünde sonsuz ihtimaller var. Mantığı bir kenara bırak, korkularını çantana koyma. Sadece kalbini al ve o ilk adımı at. Bu kart sana bilinmeyene güvenle gitmeyi ve yolculuğa inanmayı öğretir. 🔮 GÜNÜN GÖREVİ: Bugün daha önce hiç yapmadığın bir şeyi dene veya yeni bir yola çık.", "Yeni başlangıç. Masumiyet. Cesaret." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "İhtiyacın olan her şeye sahipsin. Beklemeyi bırak, plan yapma zamanı geçti; şimdi sihrini konuşturma ve yapma zamanı. Bu kart sana elindeki tüm araçları kullanarak hedeflerine ulaşabileceğini gösterir. 🔮 GÜNÜN GÖREVİ: Aynanın karşısına geç, gözlerinin içine bak ve \"Ben yapabilirim\" de.", "Yaratım gücü. İrade. Yetenek." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Cevaplar dış dünyada değil, içindeki sessizlikte. Mantığını devre dışı bırak. Bugün rüyalarına ve ilk hissine güven. Bu kart sana iç sesini dinlemeyi ve rüyalarına dikkat etmeyi öğretir. 🔮 GÜNÜN GÖREVİ: Bugün fal baktır, meditasyon yap veya sadece iç sesini dinle.", "Sezgi. Gizem. İç bilgelik." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Doğanın en cömert hali seninle. Kendini ihmal etme; güzelliği ve konforu hak ediyorsun. Yaratıcılığını kullan. Bu kart sana yaratıcı yanını keşfetmeyi ve projelerini sevgiyle beslemeyi öğretir. 🔮 GÜNÜN GÖREVİ: Kendine bakım yap (maske, banyo vs.) veya doğada vakit geçir.", "Bereket. Yaratıcılık. Doğurganlık." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Hayatının kontrolünü eline al. Kuralları sen koy. Duygusal davranma; dik dur, planını yap ve disiplinle uygula. Bu kart sana hayatında düzen kurmayı ve sınırlar koymayı öğretir. 🔮 GÜNÜN GÖREVİ: Hayatındaki düzensiz bir alanı (masa, dolap veya planlar) bugün düzenle.", "Otorite. Düzen. Kontrol." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Cevapları uzaklarda arama. Macera aramak yerine denenmiş yolları tercih et. Bir bilene danış, disiplin seni özgürlüğe götürecek. Bu kart sana geleneksel bilgiden öğrenmeyi ve manevi rehberlik aramayı öğretir. 🔮 GÜNÜN GÖREVİ: Bugün senden yaşça veya tecrübece büyük birinden tavsiye al.", "Bilgelik. Gelenek. Öğreti." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Hayatını etkileyecek büyük bir yol ayrımındasın. Sadece kalbini değil, mantığını da yanına al ve o büyük seçimi yap. Bu kart sana aşk temelinde seçimler yapmayı ve ilişkilerinde uyum aramayı öğretir. 🔮 GÜNÜN GÖREVİ: İlişkinle veya sevdiğin bir konuyla ilgili cesur bir karar al.", "Aşk. Seçim. Uyum." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Ok yaydan çıktı. Hedefine doğru hızla ilerliyorsun. Hırsın gözünü kör etmesin, nereye koştuğunu bilerek hızlan. Bu kart sana hedeflerine odaklanmayı ve engelleri aşmayı öğretir. 🔮 GÜNÜN GÖREVİ: Bugün işlerini hızlıca hallet, zaman kaybetme, dinamik ol.", "Hız. Hedefe kilitlenme. Zafer." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Gerçek güç bağırmak değil, sakin kalabilmektir. Korkularının üzerine şefkatle git, onları ancak böyle yenebilirsin. Bu kart sana iç gücünü bulmayı ve zorluklara sabırla yaklaşmayı öğretir. 🔮 GÜNÜN GÖREVİ: Bugün sinirlendiğin bir anda derin nefes al ve nezaketini koru.", "İçsel güç. Cesaret. Sabır." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Kalabalıkların gürültüsünden uzaklaş. Bugün biraz yalnız kal, kendi içine dön ve aradığın cevabın sende olduğunu fark et. Bu kart sana kendi içinde aramayı ve içsel bilgeliği dinlemeyi öğretir. 🔮 GÜNÜN GÖREVİ: Bu akşam 30 dakika boyunca telefonunu kapat ve sessizce otur.", "İçe dönüş. Işık. Bilgelik." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Çark dönüyor; şans senden yana. Değişimlere direnme, akışa bırak. Kader sana beklemediğin bir yerden gülümsüyor. Bu kart sana hayatın döngüsel olduğunu ve değişimin kaçınılmaz olduğunu öğretir. 🔮 GÜNÜN GÖREVİ: Bugün planlarını bozan bir şey olursa sinirlenme, \"Bunda da hayır vardır\" de.", "Kadersel değişim. Şans. Döngü." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Ne ektiysen onu biçeceğin zaman. Eğer haklıysan korkma. Bugün tüm kararlarında dürüst ol ve gerçeğin yanında dur. Bu kart sana adalet aramayı ve her şeyde denge bulmayı öğretir. 🔮 GÜNÜN GÖREVİ: Bugün ne olursa olsun yalan söyleme, sadece dürüst ol.", "Hakikat. Denge. Adalet." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "İlerlemek için bazen durmak gerekir. Çabalamayı bırak, olaylara tersten bak; çözümün aslında sorunun içinde olduğunu göreceksin. Bu kart sana farklı perspektiflerden bakmayı ve teslim olmayı öğretir. 🔮 GÜNÜN GÖREVİ: Bugün bir olay karşısında hemen tepki verme, dur ve karşı tarafı anlamaya çalış.", "Farklı bakış. Bekleyiş. Fedakarlık." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Bu bir son değil, eski benliğinin ölümü. O kapıyı kapat ki, güneşin girdiği yeni pencereyi görebilesin. Yenilen. Bu kart sana değişimi kucaklamayı ve sonların yeni başlangıçlar getirdiğini öğretir. 🔮 GÜNÜN GÖREVİ: Hayatında kapatmak istediğin bir sayfayı bugün zihninde tamamen bitir.", "Dönüşüm. Yeni başlangıç. Bitiş." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Aşırılıklardan kaçın. Bugün ne çok hızlı koş ne de dur; orta yolu bul, sakinleş ve dengede kalmanın gücünü hisset. Bu kart sana hayatın her alanında denge bulmayı ve sabırla ilerlemeyi öğretir. 🔮 GÜNÜN GÖREVİ: Bugün aşırı tepki vermekten kaçın, her şeye \"Hallederiz\" de.", "Uyum. Sabır. Denge." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Henüz yolun başındasın ama elindeki tohum çok kıymetli. Büyük hayaller kurmak yerine, önündeki küçük fırsata odaklan. Bugün somut bir adım at. 🔮 GÜNÜN GÖREVİ: Bugün ertelediğin o küçük işe başla (bir mail at, bir araştırma yap) ve ilk somut adımı at.", "Yeni fırsatlar. Somut adımlar." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Adımların yavaş olabilir ama yeri sarsıyor. Acele etme; inşa ettiğin şey ömürlük bir zafer. Şimdi büyük riskler alma, detayları kusursuzlaştır. 🔮 GÜNÜN GÖREVİ: Bugün yaptığın işi en ince detayına kadar kontrol et, acele etmeden kaliteni konuştur.", "Sessiz güç. Güven." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "İçindeki ateş seni harekete geçmeye zorluyor. Bekleme zamanı bitti. Valizini (veya zihnini) hazırla; karşına çıkan o ani fırsata \"Evet\" de. 🔮 GÜNÜN GÖREVİ: Bugün seni heyecanlandıran ama biraz da korkutan o şeyi yap. Risk al!", "Ateşli tutku. Macera." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Sadece bugünü değil, geleceği de güvence altına alıyorsun. Zenginlik sadece para değildir; sevdiklerinle bir araya gel ve manevi mirasın tadını çıkar. 🔮 GÜNÜN GÖREVİ: Ailenle veya çok sevdiğin dostlarınla bir araya gelip güzel bir yemek ye.", "Kalıcı miras. Zenginlik." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Soğuk bir rüzgar esiyor olabilir ama yardım sandığından yakın. Gururunu bir kenara bırak ve o kapıyı çal; yardım istemek iyileşmenin ilk adımıdır. 🔮 GÜNÜN GÖREVİ: Bugün zorlandığın bir konuda güvendiğin birinden açıkça yardım iste.", "Geçici zorluk. Yardım iste." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Ellerini o kadar sıkı kapattın ki yeni güzellikleri tutamıyorsun. Biraz esnek ol. Kontrolü bırak ve harcama yapmaktan veya paylaşmaktan korkma. 🔮 GÜNÜN GÖREVİ: Bugün kendin veya sevdiğin biri için ufak bir harcama yap, cimrilik etme.", "Sıkı tutunma. Güvence." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Büyük başarılar, görünmeyen küçük çabaların toplamıdır. Başkalarının ne yaptığına bakma, sadece kendi işine odaklan ve üretmeye devam et. 🔮 GÜNÜN GÖREVİ: Telefonu sessize al ve 1 saat boyunca sadece işine/dersine odaklan.", "Ustalık yolu. Sabırlı emek." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Evren sana somut bir fırsat sunuyor. Bu yeni bir iş veya para olabilir. Analiz etmeyi bırak ve sana uzatılan o somut teklifi kabul et. 🔮 GÜNÜN GÖREVİ: Cüzdanını düzenle ve içine bereket getirmesi niyetiyle sembolik bir para koy.", "Maddi şans. Bereket." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Hayatın iniş çıkışları arasında bir cambaz gibisin. Her şeyi aynı anda yapmaya çalışma; bugün önceliklerini belirle ve sadece en önemli topu tut. 🔮 GÜNÜN GÖREVİ: Bugün yapman gereken işleri listele ve sadece en önemli 2 tanesini seçip bitir.", "Denge oyunu. Esneklik." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Tek başına yapabileceklerin sınırlı. Yeteneklerin fark ediliyor. Bugün tek başına kahraman olmaya çalışma, işbirliği yap ve ustalığını konuştur. 🔮 GÜNÜN GÖREVİ: Bir arkadaşına veya iş arkadaşına projesiyle ilgili samimi bir övgüde bulun.", "Takım çalışması. Takdir." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Ektiğin tohumların büyümesini izliyorsun. Acele edip meyveyi ham koparma. Biraz daha sabret ve stratejini gözden geçir. 🔮 GÜNÜN GÖREVİ: Uzun vadeli hedeflerini gözden geçir, acele karar verme, sadece plan yap.", "Hasat zamanı. Bekleyiş." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Etraf biraz gürültülü. Bu bir savaş değil, herkesin sesini duyurmaya çalıştığı bir kaos. Geri çekilme; fikrini savun ve kendini kanıtla. 🔮 GÜNÜN GÖREVİ: Bugün bir tartışmada veya fikir alışverişinde geri durma, kendi fikrini netçe söyle.", "Tatlı rekabet. Mücadele." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Girdiğin ortamda ışığınla parlıyorsun. Kenarda durma; sahneye çık ve istediğini elde etmek için cazibeni kullanmaktan çekinme. 🔮 GÜNÜN GÖREVİ: Bugün en sevdiğin kıyafetini giy ve girdiğin ortamda dikkat çekmekten korkma.", "Çekicilik. Sosyal güç." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Zorlu bir dönemin ardından gelen mola. İşleri bir kenara bırak, sevdiklerini ara ve bu mutlu anın tadını çıkarmak için kendine izin ver. 🔮 GÜNÜN GÖREVİ: Evde sevdiğin bir müziği aç ve tek başına veya sevdiklerinle dans et.", "Kutlama. Huzur." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Verdiğin mücadelenin sonucunda zaferi kazandın. Mütevazı olma, başarını sahiplen ve ödülünü kabul et. Sen bunu hak ettin. 🔮 GÜNÜN GÖREVİ: Bugün başardığın bir şeyi sosyal medyada paylaş veya bir arkadaşına anlat.", "Zafer. Alkışlar." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Zirvedesin ama yerini korumak zor olabilir. İnandığın şeyler uğruna tek başına bile kalsan dik dur. Asla geri adım atma. 🔮 GÜNÜN GÖREVİ: Bugün yapmak istemediğin bir şeye net bir şekilde \"Hayır\" de.", "Savunma. Direnç." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Midas'ın dokunuşuna sahipsin. Artık risk alma değil, elindekini büyütme vakti. Gücünün farkına var ve kaynaklarını akıllıca yönet. 🔮 GÜNÜN GÖREVİ: Harcamalarını kontrol et ve bugün yatırımların için bir plan yap.", "Zirve. Maddi güç." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Yorgunsun ama pes etmedin. Bitiş çizgisine bir adım kaldı. Sakın vazgeçme; son bir gayretle ayağa kalk ve işi bitir. 🔮 GÜNÜN GÖREVİ: Çok sıkıldığın o işi bitirmek için kendine son bir 30 dakika ver ve tamamla.", "Son nöbet. Dayan." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Cevapları uzaklarda arama. Macera aramak yerine denenmiş yolları tercih et. Bir bilene danış, disiplin seni özgürlüğe götürecek. 🔮 GÜNÜN GÖREVİ: Bugün senden yaşça veya tecrübece büyük birinden tavsiye al.", "Bilgelik. Gelenek." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Kalbinin kapıları açılıyor. Yeni bir aşk veya dostluk kapıda. Mantığını sustur ve sana sunulan o sevgi kadehini iç. 🔮 GÜNÜN GÖREVİ: Duygularını ifade et; sevdiğin birine \"Seni seviyorum\" veya \"Sana değer veriyorum\" de.", "Duygusal taşma. Yeni aşk." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Girdiğin ortamda ışığınla parlıyorsun. Kenarda durma; sahneye çık ve istediğini elde etmek için cazibeni kullanmaktan çekinme. 🔮 GÜNÜN GÖREVİ: Bugün en sevdiğin kıyafetini giy ve girdiğin ortamda dikkat çekmekten korkma.", "Çekicilik. Sosyal güç." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Bazen büyümek için canının yanması gerekir. Acını inkar etme, yaşa ve bitir. İyileşmek için önce yarayı kabul etmelisin. 🔮 GÜNÜN GÖREVİ: Canını sıkan o konuyu bir kağıda yaz, sonra o kağıdı yırtıp at.", "Kalp kırıklığı. İyileşme." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Seni boğan şeyler gerçekler değil, zihninin ürettiği senaryolar. Yataktan kalk, ışığı aç ve korkularının ne kadar yersiz olduğunu gör. 🔮 GÜNÜN GÖREVİ: Uyumadan önce zihnini boşaltmak için 5 dakika meditasyon yap veya dua et.", "Endişe. Kabus." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Doğrudan saldırmak yerine arka kapıdan dolaş. Planlarını kendine sakla. Zekanı kullan ve hedefine sessizce ulaş. 🔮 GÜNÜN GÖREVİ: Bugün hedeflerin hakkında kimseye bahsetme, sırrını kendine sakla.", "Strateji. Gizlilik." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Korkudan gözlerini kapattın. Seçim yapmamak da bir seçimdir. Gözündeki bağı çöz; mantığının ve kalbinin buluştuğu o kararı ver. 🔮 GÜNÜN GÖREVİ: Uzun süredir ertelediğin o kararı (küçük de olsa) bugün ver ve uygula.", "Kararsızlık. Denge." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Duygularına yer yok. Kararların keskin bir kılıç gibi olmalı. Merhametle değil adaletle karar ver ve gerekeni yap. 🔮 GÜNÜN GÖREVİ: Bugün duygusal davranmayı bırak, olaylara sadece mantık çerçevesinden bak.", "Otorite. Mantık." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Seni tutan tek şey \"Yapamam\" inancın. Gözlerini aç ve o görünmez hapishaneden kendi iradenle çık. 🔮 GÜNÜN GÖREVİ: \"Yapamam\" dediğin bir şeyi bugün yaparak kendine meydan oku.", "Zihinsel hapis. Uyanış." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Zihnin çok aktif. Ancak her duyduğuna inanma; bilgiyi topla, analiz et ve sadece gerçeğin peşinden git. 🔮 GÜNÜN GÖREVİ: Merak ettiğin bir konuda derinlemesine bir araştırma yap, makale oku.", "Merak. Haberci." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Ok yaydan çıktı. Hedefine doğru hızla ilerliyorsun. Hırsın gözünü kör etmesin, nereye koştuğunu bilerek hızlan. 🔮 GÜNÜN GÖREVİ: Bugün işlerini hızlıca hallet, zaman kaybetme, dinamik ol.", "Hız. Hedefe kilitlenme." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Kader sana küçük bir mesaj gönderiyor. Hayata şüpheyle bakmayı bırak; içindeki çocuğu dinle ve o küçük jesti kabul et. 🔮 GÜNÜN GÖREVİ: Bugün birine beklemediği küçük bir sürpriz yap veya iltifat et.", "Tatlı sürpriz. Haber." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "İç sesin sana doğruyu söylüyor. Etrafına şifa yayıyorsun ama kendini unutma. Bugün mantığınla değil hislerinle hareket et. 🔮 GÜNÜN GÖREVİ: Bugün rüyalarını bir yere not et ve hislerine güvenerek hareket et.", "Şefkat. Sezgi." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Fırtınalı denizde bile gemisini sakince yürüten kaptansın. Olaylara sakin yaklaş ve çevrendeki krizi bilgeliğinle çöz. 🔮 GÜNÜN GÖREVİ: Gergin bir ortamda sakinliğini koru ve arabulucu rolünü üstlen.", "Duygusal denge. Huzur." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Zorlu kıyıları geride bırakıp sakin sulara açılıyorsun. Arkana bakma; bu bir kaçış değil, iyileşmek için çıkılan bir yolculuk. 🔮 GÜNÜN GÖREVİ: Seni üzen eski mesajları veya fotoğrafları bugün arşivle veya sil.", "Geçiş dönemi. Umut." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Beyaz atlı prens veya ilham perisi kapıda. Rüyalar alemi güzeldir ama harekete geçmezsen hayal kalır. Kalbinin götürdüğü yere git. 🔮 GÜNÜN GÖREVİ: Hoşlandığın kişiye bir mesaj at veya partnerine romantik bir jest yap.", "Romantizm. Teklif." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Evren sana kocaman bir \"Evet\" diyor. Dileğin gerçekleşmek üzere. Endişelenmeyi bırak, arkana yaslan ve anın tadını çıkar. 🔮 GÜNÜN GÖREVİ: Kendini şımart; en sevdiğin yemeği ye veya kendine bir hediye al.", "Dilek kartı. Keyif." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Kimsenin oyuncağı değilsin. Gereksiz insanları hayatından çıkarmaktan korkma. Sınırlarını net çiz ve taviz verme. 🔮 GÜNÜN GÖREVİ: Bugün sınırlarını ihlal eden birine nazikçe ama kesin bir dille dur de.", "Dürüstlük. Netlik." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Bir devir kapandı, acı bitti. Artık daha kötüye gidemezsin. Yerden kalk, üzerindeki tozu silkele ve doğan güneşe bak. 🔮 GÜNÜN GÖREVİ: Sabah güneş doğarken uyan ve pencereyi açıp derin bir nefes al.", "Bitiş. Yeni şafak." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Duygularına yer yok. Kararların keskin bir kılıç gibi olmalı. Merhametle değil adaletle karar ver ve gerekeni yap. 🔮 GÜNÜN GÖREVİ: Bugün duygusal davranmayı bırak, olaylara sadece mantık çerçevesinden bak.", "Otorite. Mantık." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Önünde sonsuz ihtimaller var. Mantığı bir kenara bırak. Çantana korkularını koyma, sadece kalbini al ve o ilk adımı at. 🔮 GÜNÜN GÖREVİ: Bugün daha önce hiç gitmediğin bir sokağa gir veya yeni bir şey dene.", "Sıfır noktası. Cesaret." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "İhtiyacın olan her şeye sahipsin. Beklemeyi bırak, plan yapma zamanı geçti; şimdi sihrini konuşturma ve yapma zamanı. 🔮 GÜNÜN GÖREVİ: Aynanın karşısına geç, gözlerinin içine bak ve \"Ben yapabilirim\" de.", "Yaratım gücü. Yetenek." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Sırtındaki yükler seni yere eğmiş olabilir. Hedefe çok yaklaştın. Ancak her şeyi tek başına yapamazsın; bugün yardım iste. 🔮 GÜNÜN GÖREVİ: Üzerindeki iş yükünü hafifletmek için bir işi başkasına devret.", "Ağır yük. Sorumluluk." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Hayatının kontrolünü eline al. Kuralları sen koy. Duygusal davranma; dik dur, planını yap ve disiplinle uygula. 🔮 GÜNÜN GÖREVİ: Hayatındaki düzensiz bir alanı (masa, dolap veya planlar) bugün düzenle.", "Otorite. Düzen." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Cevaplar dış dünyada değil, içindeki sessizlikte. Mantığını devre dışı bırak. Bugün rüyalarına ve ilk hissine güven. 🔮 GÜNÜN GÖREVİ: Bugün fal baktır, meditasyon yap veya sadece iç sesini dinle.", "Sezgi. Gizem." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Dünya avuçlarının içinde. Güvenli limanda kalmak mı, yoksa ufka açılmak mı? Korkma, büyük düşün ve o ilk adımı at. 🔮 GÜNÜN GÖREVİ: Gelecek 1 yıl için en büyük hedefini bir kağıda yaz ve duvara as.", "Planlama. Vizyon." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Evren sana yanan bir meşale uzatıyor. Aklındaki o yeni fikri veya projeyi hayata geçirmek için en doğru gün bugündür. Başla! 🔮 GÜNÜN GÖREVİ: Aklına gelen o çılgın fikri not al ve hemen ilk araştırmasını yap.", "Kıvılcım. İlham." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "Placeholder", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "FullDescription", "Meaning" },
                values: new object[] { "İlerlemek için bazen durmak gerekir. Çabalamayı bırak, olaylara tersten bak; çözümün aslında sorunun içinde olduğunu göreceksin. 🔮 GÜNÜN GÖREVİ: Bugün bir olay karşısında hemen tepki verme, dur ve karşı tarafı anlamaya çalış.", "Farklı bakış. Bekleyiş." });

            migrationBuilder.InsertData(
                table: "TarotCards",
                columns: new[] { "Id", "BackImageUrl", "CreatedAt", "FullDescription", "ImageUrl", "Meaning", "Name", "Number", "SongEmbedUrl", "UpdatedAt" },
                values: new object[,]
                {
                    { 79, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Geçmişin küllerinden doğma vakti. Eski hataları affet. Bu senin ikinci şansın; çağrıya kulak ver ve yeni hayatına başla. 🔮 GÜNÜN GÖREVİ: Eskiden küs olduğun veya kırdığın biriyle barışmak için bir adım at.", "/images/79.jpeg", "Uyanış. İkinci şans.", "Kart 79", 78, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Önünü net göremiyorsan adım atma. İçindeki korkularla yüzleş, sisin dağılmasını bekle ve sadece sezgilerine güven. 🔮 GÜNÜN GÖREVİ: Karanlık bir odada mum yak ve korkularınla yüzleşmek için sessizce otur.", "/images/80.jpeg", "Yanılsama. Belirsizlik.", "Kart 80", 79, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Döngü tamamlandı. Başladığın yolculuğu başardın. Bu anın tadını çıkar ve kutla; yeni macera başlamak üzere. 🔮 GÜNÜN GÖREVİ: Bitirdiğin bir iş için kendine \"Aferin\" de ve bu başarıyı kutla.", "/images/81.jpeg", "Tamamlanma. Zafer.", "Kart 81", 80, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ne ektiysen onu biçeceğin zaman. Eğer haklıysan korkma. Bugün tüm kararlarında dürüst ol ve gerçeğin yanında dur. 🔮 GÜNÜN GÖREVİ: Bugün ne olursa olsun yalan söyleme, sadece dürüst ol.", "/images/82.jpeg", "Hakikat. Denge.", "Kart 82", 81, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karanlık bulutlar dağıldı. Kader Kutusu'nun en şanslı kartı seninle. Dertleri unut, dışarı çık ve güneşin tadını çıkar. 🔮 GÜNÜN GÖREVİ: Bugün açık havada yürüyüş yap ve güneşin enerjisini hisset.", "/images/83.jpeg", "Neşe. Başarı.", "Kart 83", 82, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/84.jpeg", "Placeholder", "Kart 84", 83, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kadehleri kaldırma zamanı! Yalnız kalma; sosyalleş, kutla ve sevincini paylaş. Paylaşılan mutluluk bereket getirecek. 🔮 GÜNÜN GÖREVİ: Arkadaşlarını ara ve bu hafta sonu için bir buluşma planla.", "/images/85.jpeg", "Kutlama. Dostluk.", "Kart 85", 84, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "İki ruhun mükemmel dansı. Seni tamamlayan o parçayı buldun. Duvarlarını indir ve bu bağa güven. 🔮 GÜNÜN GÖREVİ: Partnerine veya en yakın dostuna, onun senin için ne kadar önemli olduğunu söyle.", "/images/86.jpeg", "Ruh eşi. Uyum.", "Kart 86", 85, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "En karanlık gecede bile yolunu aydınlatan bir yıldız vardır. Umudunu kaybetme ve o dileği tut; gökyüzü seni duyuyor. 🔮 GÜNÜN GÖREVİ: Gece gökyüzüne bak ve en içten dileğini evrene fısılda.", "/images/87.jpeg", "Umut. Şifa.", "Kart 87", 86, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Önünde duran fırsatları göremeyecek kadar içine kapanmışsın. Başını kaldır! Sana uzatılan o yeni fırsatı fark et. 🔮 GÜNÜN GÖREVİ: Bugün sana gelen bir daveti veya teklifi reddetme, \"Evet\" de.", "/images/88.jpeg", "Bıkkınlık. Fırsat.", "Kart 88", 87, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarsıcı olabilir ama gerekliydi. Çürük temeller yıkılıyor. Enkazı bırak ve daha sağlamını inşa etmek için önüne bak. 🔮 GÜNÜN GÖREVİ: Hayatında artık işe yaramayan eski bir eşyayı çöpe at.", "/images/89.jpeg", "Yıkım. Özgürlük.", "Kart 89", 88, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seni tutsak eden kendi zaafların. Zincirlerin aslında gevşek. Bugün seni aşağı çeken o alışkanlığa \"Dur\" de. 🔮 GÜNÜN GÖREVİ: Bugün kötü bir alışkanlığını (sigara, şeker, sosyal medya) 1 günlüğüne bırak.", "/images/90.jpeg", "Tutku. Zincirler.", "Kart 90", 89, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doğanın en cömert hali seninle. Kendini ihmal etme; güzelliği ve konforu hak ediyorsun. Yaratıcılığını kullan. 🔮 GÜNÜN GÖREVİ: Kendine bakım yap (maske, banyo vs.) veya doğada vakit geçir.", "/images/91.jpeg", "Bereket. Güzellik.", "Kart 91", 90, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bu bir son değil, eski benliğinin ölümü. O kapıyı kapat ki, güneşin girdiği yeni pencereyi görebilesin. Yenilen. 🔮 GÜNÜN GÖREVİ: Hayatında kapatmak istediğin bir sayfayı bugün zihninde tamamen bitir.", "/images/92.jpeg", "Dönüşüm. Yeni başlangıç.", "Kart 92", 91, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kalabalıkların gürültüsünden uzaklaş. Bugün biraz yalnız kal, kendi içine dön ve aradığın cevabın sende olduğunu fark et. 🔮 GÜNÜN GÖREVİ: Bu akşam 30 dakika boyunca telefonunu kapat ve sessizce otur.", "/images/93.jpeg", "İçe dönüş. Işık.", "Kart 93", 92, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dizginleri sıkı tut. Yol engebeli olabilir ama pes etme. İradeni ortaya koyarsan o zafer senin olacak. 🔮 GÜNÜN GÖREVİ: Ertelediğin o zor işi bugün inat et ve bitir.", "/images/94.jpeg", "İrade. Zafer.", "Kart 94", 93, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kalabalıkların gürültüsünden uzaklaş. Bugün biraz yalnız kal, kendi içine dön ve aradığın cevabın sende olduğunu fark et. 🔮 GÜNÜN GÖREVİ: Bu akşam 30 dakika boyunca telefonunu kapat ve sessizce otur.", "/images/95.jpeg", "İçe dönüş. Işık.", "Kart 95", 94, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dizginleri sıkı tut. Yol engebeli olabilir ama pes etme. İradeni ortaya koyarsan o zafer senin olacak. 🔮 GÜNÜN GÖREVİ: Ertelediğin o zor işi bugün inat et ve bitir.", "/images/96.jpeg", "İrade. Zafer.", "Kart 96", 95, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aşırılıklardan kaçın. Bugün ne çok hızlı koş ne de dur; orta yolu bul, sakinleş ve dengede kalmanın gücünü hisset. 🔮 GÜNÜN GÖREVİ: Bugün aşırı tepki vermekten kaçın, her şeye \"Hallederiz\" de.", "/images/97.jpeg", "Uyum. Sabır.", "Kart 97", 96, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatını etkileyecek büyük bir yol ayrımındasın. Sadece kalbini değil, mantığını da yanına al ve o büyük seçimi yap. 🔮 GÜNÜN GÖREVİ: İlişkinle veya sevdiğin bir konuyla ilgili cesur bir karar al.", "/images/98.jpeg", "Seçim. Tutku.", "Kart 98", 97, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sırtındaki yükler seni yere eğmiş olabilir. Hedefe çok yaklaştın. Ancak her şeyi tek başına yapamazsın; bugün yardım iste. 🔮 GÜNÜN GÖREVİ: Üzerindeki iş yükünü hafifletmek için bir işi başkasına devret.", "/images/99.jpeg", "Ağır yük. Sorumluluk.", "Kart 99", 98, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gemilerin yola çıktı. Artık küçük sularda yüzme vakti bitti. Vizyonunu genişlet ve büyük oynamaya hazır ol. 🔮 GÜNÜN GÖREVİ: Yurtdışı veya şehir dışı ile ilgili planlarına bugün bir göz at.", "/images/100.jpeg", "Vizyon. Genişleme.", "Kart 100", 99, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerçek güç bağırmak değil, sakin kalabilmektir. Korkularının üzerine şefkatle git, onları ancak böyle yenebilirsin. 🔮 GÜNÜN GÖREVİ: Bugün sinirlendiğin bir anda derin nefes al ve nezaketini koru.", "/images/101.jpeg", "Cesaret. İçsel güç.", "Kart 101", 100, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çark dönüyor; şans senden yana. Değişimlere direnme, akışa bırak. Kader sana beklemediğin bir yerden gülümsüyor. 🔮 GÜNÜN GÖREVİ: Bugün planlarını bozan bir şey olursa sinirlenme, \"Bunda da hayır vardır\" de.", "/images/102.jpeg", "Kadersel değişim. Şans.", "Kart 102", 101, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "İki ruhun mükemmel dansı. Seni tamamlayan o parçayı buldun. Duvarlarını indir ve bu bağa güven. 🔮 GÜNÜN GÖREVİ: Partnerine veya en yakın dostuna, onun senin için ne kadar önemli olduğunu söyle.", "/images/103.jpeg", "Ruh eşi. Uyum.", "Kart 103", 102, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimseye ihtiyacın olmadığı bir dönem. Bugün kendine bir ödül ver, kaliteni yükselt ve tek başına olmanın tadını çıkar. 🔮 GÜNÜN GÖREVİ: Bugün kendini şık bir yere götür ve tek başına kahve iç/yemek ye.", "/images/104.jpeg", "Bağımsızlık. Lüks.", "Kart 104", 103, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dökülen kupalara bakıp üzülüyorsun ama arkanda dolu kupalar var. Kaybettiğine değil, elinde kalanlara odaklan. 🔮 GÜNÜN GÖREVİ: Seni üzen bir kaybı kabul et ve elinde kalan 3 güzel şeye şükret.", "/images/105.jpeg", "Hayal kırıklığı. Yas.", "Kart 105", 104, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sana heyecan verici bir haber veya yeni bir fikir geliyor. Yerinde duramıyorsun. Bu enerjiyi boşa harcama. 🔮 GÜNÜN GÖREVİ: Merak ettiğin o yeni yere git veya yeni bir hobiye başla.", "/images/106.jpeg", "Haber. Heyecan.", "Kart 106", 105, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayallerini inşa edecek güce sahipsin. İnsanları peşinden sürükle. Büyük resmi gör ve liderliği eline al. 🔮 GÜNÜN GÖREVİ: İşinde veya okulunda liderlik vasfını gösteren bir sorumluluk al.", "/images/107.jpeg", "Liderlik. Vizyon.", "Kart 107", 106, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buradaki miadın doldu. Seni tatmin etmeyen şeyi geride bırak. Arkana bakmadan yürü; daha yüce bir anlam seni bekliyor. 🔮 GÜNÜN GÖREVİ: Sana iyi gelmeyen bir ortamdan veya sohbetten bugün uzaklaş.", "/images/108.jpeg", "Vazgeçiş. Yola çıkmak.", "Kart 108", 107, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kafan karışık. Her parlayan şey altın değildir. Hayal dünyasında kaybolmayı bırak. Gerçekçi ol. 🔮 GÜNÜN GÖREVİ: Hayallerini bir kenara bırak ve bugün yapabileceğin 1 gerçek işe odaklan.", "/images/109.jpeg", "Hayaller. Seçimler.", "Kart 109", 108, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 110, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Geçmişten güzel bir hatıra canlanıyor. Çocukluğundaki o saf neşeyi hatırla. Bugün eski günlerin sıcaklığına sığın. 🔮 GÜNÜN GÖREVİ: Çok eski bir arkadaşını ara ve \"Aklıma geldin\" de.", "/images/110.jpeg", "Nostalji. Masumiyet.", "Kart 110", 109, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Savaş bitti. Çok yoruldun. Hiçbir karar alma. Sadece dur. Bugün kendine tam bir sessizlik hediye et. 🔮 GÜNÜN GÖREVİ: Bugün işten/okuldan sonra hemen eve git ve dinlen.", "/images/111.jpeg", "Mola. Meditasyon.", "Kart 111", 110, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zihhindeki sis kalkıyor. O kılıcı eline al ve seni durduran o bağı kesip at. Gerçekler özgürleştirir. 🔮 GÜNÜN GÖREVİ: Kafanı kurcalayan bir sorunu bugün kökünden çöz ve bitir.", "/images/112.jpeg", "Netlik. Zafer.", "Kart 112", 111, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
