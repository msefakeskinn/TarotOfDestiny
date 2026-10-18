using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TarotOfDestiny.Migrations
{
    /// <inheritdoc />
    public partial class RestoreTurkishTextsAndImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Yolun başındasın ve önünde sonsuz ihtimaller var. Mantığı bir kenara bırak, korkularını çantana koyma. Sadece kalbini al ve o ilk adımı at. Bu kart sana bilinmeyene güvenle gitmeyi ve yolculuğa inanmayı öğretir. 🔮 GÜNÜN GÖREVİ: Bugün daha önce hiç yapmadığın bir şeyi dene veya yeni bir yola çık.", "/images/1.jpeg", "Yeni başlangıç. Masumiyet. Cesaret." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "İhtiyacın olan her şeye sahipsin. Beklemeyi bırak, plan yapma zamanı geçti; şimdi sihrini konuşturma ve yapma zamanı. Bu kart sana elindeki tüm araçları kullanarak hedeflerine ulaşabileceğini gösterir. 🔮 GÜNÜN GÖREVİ: Aynanın karşısına geç, gözlerinin içine bak ve \"Ben yapabilirim\" de.", "/images/2.jpeg", "Yaratım gücü. İrade. Yetenek." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Cevaplar dış dünyada değil, içindeki sessizlikte. Mantığını devre dışı bırak. Bugün rüyalarına ve ilk hissine güven. Bu kart sana iç sesini dinlemeyi ve rüyalarına dikkat etmeyi öğretir. 🔮 GÜNÜN GÖREVİ: Bugün fal baktır, meditasyon yap veya sadece iç sesini dinle.", "/images/3.jpeg", "Sezgi. Gizem. İç bilgelik." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Doğanın en cömert hali seninle. Kendini ihmal etme; güzelliği ve konforu hak ediyorsun. Yaratıcılığını kullan. Bu kart sana yaratıcı yanını keşfetmeyi ve projelerini sevgiyle beslemeyi öğretir. 🔮 GÜNÜN GÖREVİ: Kendine bakım yap (maske, banyo vs.) veya doğada vakit geçir.", "/images/4.jpeg", "Bereket. Yaratıcılık. Doğurganlık." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Hayatının kontrolünü eline al. Kuralları sen koy. Duygusal davranma; dik dur, planını yap ve disiplinle uygula. Bu kart sana hayatında düzen kurmayı ve sınırlar koymayı öğretir. 🔮 GÜNÜN GÖREVİ: Hayatındaki düzensiz bir alanı (masa, dolap veya planlar) bugün düzenle.", "/images/5.jpeg", "Otorite. Düzen. Kontrol." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Cevapları uzaklarda arama. Macera aramak yerine denenmiş yolları tercih et. Bir bilene danış, disiplin seni özgürlüğe götürecek. Bu kart sana geleneksel bilgiden öğrenmeyi ve manevi rehberlik aramayı öğretir. 🔮 GÜNÜN GÖREVİ: Bugün senden yaşça veya tecrübece büyük birinden tavsiye al.", "/images/6.jpeg", "Bilgelik. Gelenek. Öğreti." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Hayatını etkileyecek büyük bir yol ayrımındasın. Sadece kalbini değil, mantığını da yanına al ve o büyük seçimi yap. Bu kart sana aşk temelinde seçimler yapmayı ve ilişkilerinde uyum aramayı öğretir. 🔮 GÜNÜN GÖREVİ: İlişkinle veya sevdiğin bir konuyla ilgili cesur bir karar al.", "/images/7.jpeg", "Aşk. Seçim. Uyum." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Ok yaydan çıktı. Hedefine doğru hızla ilerliyorsun. Hırsın gözünü kör etmesin, nereye koştuğunu bilerek hızlan. Bu kart sana hedeflerine odaklanmayı ve engelleri aşmayı öğretir. 🔮 GÜNÜN GÖREVİ: Bugün işlerini hızlıca hallet, zaman kaybetme, dinamik ol.", "/images/8.jpeg", "Hız. Hedefe kilitlenme. Zafer." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Gerçek güç bağırmak değil, sakin kalabilmektir. Korkularının üzerine şefkatle git, onları ancak böyle yenebilirsin. Bu kart sana iç gücünü bulmayı ve zorluklara sabırla yaklaşmayı öğretir. 🔮 GÜNÜN GÖREVİ: Bugün sinirlendiğin bir anda derin nefes al ve nezaketini koru.", "/images/9.jpeg", "İçsel güç. Cesaret. Sabır." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Kalabalıkların gürültüsünden uzaklaş. Bugün biraz yalnız kal, kendi içine dön ve aradığın cevabın sende olduğunu fark et. Bu kart sana kendi içinde aramayı ve içsel bilgeliği dinlemeyi öğretir. 🔮 GÜNÜN GÖREVİ: Bu akşam 30 dakika boyunca telefonunu kapat ve sessizce otur.", "/images/10.jpeg", "İçe dönüş. Işık. Bilgelik." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Çark dönüyor; şans senden yana. Değişimlere direnme, akışa bırak. Kader sana beklemediğin bir yerden gülümsüyor. Bu kart sana hayatın döngüsel olduğunu ve değişimin kaçınılmaz olduğunu öğretir. 🔮 GÜNÜN GÖREVİ: Bugün planlarını bozan bir şey olursa sinirlenme, \"Bunda da hayır vardır\" de.", "/images/11.jpeg", "Kadersel değişim. Şans. Döngü." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Ne ektiysen onu biçeceğin zaman. Eğer haklıysan korkma. Bugün tüm kararlarında dürüst ol ve gerçeğin yanında dur. Bu kart sana adalet aramayı ve her şeyde denge bulmayı öğretir. 🔮 GÜNÜN GÖREVİ: Bugün ne olursa olsun yalan söyleme, sadece dürüst ol.", "/images/12.jpeg", "Hakikat. Denge. Adalet." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "İlerlemek için bazen durmak gerekir. Çabalamayı bırak, olaylara tersten bak; çözümün aslında sorunun içinde olduğunu göreceksin. Bu kart sana farklı perspektiflerden bakmayı ve teslim olmayı öğretir. 🔮 GÜNÜN GÖREVİ: Bugün bir olay karşısında hemen tepki verme, dur ve karşı tarafı anlamaya çalış.", "/images/13.jpeg", "Farklı bakış. Bekleyiş. Fedakarlık." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Bu bir son değil, eski benliğinin ölümü. O kapıyı kapat ki, güneşin girdiği yeni pencereyi görebilesin. Yenilen. Bu kart sana değişimi kucaklamayı ve sonların yeni başlangıçlar getirdiğini öğretir. 🔮 GÜNÜN GÖREVİ: Hayatında kapatmak istediğin bir sayfayı bugün zihninde tamamen bitir.", "/images/14.jpeg", "Dönüşüm. Yeni başlangıç. Bitiş." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Aşırılıklardan kaçın. Bugün ne çok hızlı koş ne de dur; orta yolu bul, sakinleş ve dengede kalmanın gücünü hisset. Bu kart sana hayatın her alanında denge bulmayı ve sabırla ilerlemeyi öğretir. 🔮 GÜNÜN GÖREVİ: Bugün aşırı tepki vermekten kaçın, her şeye \"Hallederiz\" de.", "/images/15.jpeg", "Uyum. Sabır. Denge." });

            migrationBuilder.InsertData(
                table: "TarotCards",
                columns: new[] { "Id", "BackImageUrl", "CreatedAt", "FullDescription", "ImageUrl", "Meaning", "Name", "Number", "SongEmbedUrl", "UpdatedAt" },
                values: new object[,]
                {
                    { 16, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/16.jpeg", "Placeholder", "Kart 16", 15, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/17.jpeg", "Placeholder", "Kart 17", 16, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/18.jpeg", "Placeholder", "Kart 18", 17, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/19.jpeg", "Placeholder", "Kart 19", 18, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henüz yolun başındasın ama elindeki tohum çok kıymetli. Büyük hayaller kurmak yerine, önündeki küçük fırsata odaklan. Bugün somut bir adım at. 🔮 GÜNÜN GÖREVİ: Bugün ertelediğin o küçük işe başla (bir mail at, bir araştırma yap) ve ilk somut adımı at.", "/images/20.jpeg", "Yeni fırsatlar. Somut adımlar.", "Kart 20", 19, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adımların yavaş olabilir ama yeri sarsıyor. Acele etme; inşa ettiğin şey ömürlük bir zafer. Şimdi büyük riskler alma, detayları kusursuzlaştır. 🔮 GÜNÜN GÖREVİ: Bugün yaptığın işi en ince detayına kadar kontrol et, acele etmeden kaliteni konuştur.", "/images/21.jpeg", "Sessiz güç. Güven.", "Kart 21", 20, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "İçindeki ateş seni harekete geçmeye zorluyor. Bekleme zamanı bitti. Valizini (veya zihnini) hazırla; karşına çıkan o ani fırsata \"Evet\" de. 🔮 GÜNÜN GÖREVİ: Bugün seni heyecanlandıran ama biraz da korkutan o şeyi yap. Risk al!", "/images/22.jpeg", "Ateşli tutku. Macera.", "Kart 22", 21, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sadece bugünü değil, geleceği de güvence altına alıyorsun. Zenginlik sadece para değildir; sevdiklerinle bir araya gel ve manevi mirasın tadını çıkar. 🔮 GÜNÜN GÖREVİ: Ailenle veya çok sevdiğin dostlarınla bir araya gelip güzel bir yemek ye.", "/images/23.jpeg", "Kalıcı miras. Zenginlik.", "Kart 23", 22, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soğuk bir rüzgar esiyor olabilir ama yardım sandığından yakın. Gururunu bir kenara bırak ve o kapıyı çal; yardım istemek iyileşmenin ilk adımıdır. 🔮 GÜNÜN GÖREVİ: Bugün zorlandığın bir konuda güvendiğin birinden açıkça yardım iste.", "/images/24.jpeg", "Geçici zorluk. Yardım iste.", "Kart 24", 23, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ellerini o kadar sıkı kapattın ki yeni güzellikleri tutamıyorsun. Biraz esnek ol. Kontrolü bırak ve harcama yapmaktan veya paylaşmaktan korkma. 🔮 GÜNÜN GÖREVİ: Bugün kendin veya sevdiğin biri için ufak bir harcama yap, cimrilik etme.", "/images/25.jpeg", "Sıkı tutunma. Güvence.", "Kart 25", 24, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Büyük başarılar, görünmeyen küçük çabaların toplamıdır. Başkalarının ne yaptığına bakma, sadece kendi işine odaklan ve üretmeye devam et. 🔮 GÜNÜN GÖREVİ: Telefonu sessize al ve 1 saat boyunca sadece işine/dersine odaklan.", "/images/26.jpeg", "Ustalık yolu. Sabırlı emek.", "Kart 26", 25, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evren sana somut bir fırsat sunuyor. Bu yeni bir iş veya para olabilir. Analiz etmeyi bırak ve sana uzatılan o somut teklifi kabul et. 🔮 GÜNÜN GÖREVİ: Cüzdanını düzenle ve içine bereket getirmesi niyetiyle sembolik bir para koy.", "/images/27.jpeg", "Maddi şans. Bereket.", "Kart 27", 26, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın iniş çıkışları arasında bir cambaz gibisin. Her şeyi aynı anda yapmaya çalışma; bugün önceliklerini belirle ve sadece en önemli topu tut. 🔮 GÜNÜN GÖREVİ: Bugün yapman gereken işleri listele ve sadece en önemli 2 tanesini seçip bitir.", "/images/28.jpeg", "Denge oyunu. Esneklik.", "Kart 28", 27, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tek başına yapabileceklerin sınırlı. Yeteneklerin fark ediliyor. Bugün tek başına kahraman olmaya çalışma, işbirliği yap ve ustalığını konuştur. 🔮 GÜNÜN GÖREVİ: Bir arkadaşına veya iş arkadaşına projesiyle ilgili samimi bir övgüde bulun.", "/images/29.jpeg", "Takım çalışması. Takdir.", "Kart 29", 28, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ektiğin tohumların büyümesini izliyorsun. Acele edip meyveyi ham koparma. Biraz daha sabret ve stratejini gözden geçir. 🔮 GÜNÜN GÖREVİ: Uzun vadeli hedeflerini gözden geçir, acele karar verme, sadece plan yap.", "/images/30.jpeg", "Hasat zamanı. Bekleyiş.", "Kart 30", 29, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Etraf biraz gürültülü. Bu bir savaş değil, herkesin sesini duyurmaya çalıştığı bir kaos. Geri çekilme; fikrini savun ve kendini kanıtla. 🔮 GÜNÜN GÖREVİ: Bugün bir tartışmada veya fikir alışverişinde geri durma, kendi fikrini netçe söyle.", "/images/31.jpeg", "Tatlı rekabet. Mücadele.", "Kart 31", 30, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Girdiğin ortamda ışığınla parlıyorsun. Kenarda durma; sahneye çık ve istediğini elde etmek için cazibeni kullanmaktan çekinme. 🔮 GÜNÜN GÖREVİ: Bugün en sevdiğin kıyafetini giy ve girdiğin ortamda dikkat çekmekten korkma.", "/images/32.jpeg", "Çekicilik. Sosyal güç.", "Kart 32", 31, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zorlu bir dönemin ardından gelen mola. İşleri bir kenara bırak, sevdiklerini ara ve bu mutlu anın tadını çıkarmak için kendine izin ver. 🔮 GÜNÜN GÖREVİ: Evde sevdiğin bir müziği aç ve tek başına veya sevdiklerinle dans et.", "/images/33.jpeg", "Kutlama. Huzur.", "Kart 33", 32, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Verdiğin mücadelenin sonucunda zaferi kazandın. Mütevazı olma, başarını sahiplen ve ödülünü kabul et. Sen bunu hak ettin. 🔮 GÜNÜN GÖREVİ: Bugün başardığın bir şeyi sosyal medyada paylaş veya bir arkadaşına anlat.", "/images/34.jpeg", "Zafer. Alkışlar.", "Kart 34", 33, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zirvedesin ama yerini korumak zor olabilir. İnandığın şeyler uğruna tek başına bile kalsan dik dur. Asla geri adım atma. 🔮 GÜNÜN GÖREVİ: Bugün yapmak istemediğin bir şeye net bir şekilde \"Hayır\" de.", "/images/35.jpeg", "Savunma. Direnç.", "Kart 35", 34, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Midas'ın dokunuşuna sahipsin. Artık risk alma değil, elindekini büyütme vakti. Gücünün farkına var ve kaynaklarını akıllıca yönet. 🔮 GÜNÜN GÖREVİ: Harcamalarını kontrol et ve bugün yatırımların için bir plan yap.", "/images/36.jpeg", "Zirve. Maddi güç.", "Kart 36", 35, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yorgunsun ama pes etmedin. Bitiş çizgisine bir adım kaldı. Sakın vazgeçme; son bir gayretle ayağa kalk ve işi bitir. 🔮 GÜNÜN GÖREVİ: Çok sıkıldığın o işi bitirmek için kendine son bir 30 dakika ver ve tamamla.", "/images/37.jpeg", "Son nöbet. Dayan.", "Kart 37", 36, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/38.jpeg", "Placeholder", "Kart 38", 37, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/39.jpeg", "Placeholder", "Kart 39", 38, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cevapları uzaklarda arama. Macera aramak yerine denenmiş yolları tercih et. Bir bilene danış, disiplin seni özgürlüğe götürecek. 🔮 GÜNÜN GÖREVİ: Bugün senden yaşça veya tecrübece büyük birinden tavsiye al.", "/images/40.jpeg", "Bilgelik. Gelenek.", "Kart 40", 39, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kalbinin kapıları açılıyor. Yeni bir aşk veya dostluk kapıda. Mantığını sustur ve sana sunulan o sevgi kadehini iç. 🔮 GÜNÜN GÖREVİ: Duygularını ifade et; sevdiğin birine \"Seni seviyorum\" veya \"Sana değer veriyorum\" de.", "/images/41.jpeg", "Duygusal taşma. Yeni aşk.", "Kart 41", 40, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/42.jpeg", "Placeholder", "Kart 42", 41, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/43.jpeg", "Placeholder", "Kart 43", 42, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Girdiğin ortamda ışığınla parlıyorsun. Kenarda durma; sahneye çık ve istediğini elde etmek için cazibeni kullanmaktan çekinme. 🔮 GÜNÜN GÖREVİ: Bugün en sevdiğin kıyafetini giy ve girdiğin ortamda dikkat çekmekten korkma.", "/images/44.jpeg", "Çekicilik. Sosyal güç.", "Kart 44", 43, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/45.jpeg", "Placeholder", "Kart 45", 44, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bazen büyümek için canının yanması gerekir. Acını inkar etme, yaşa ve bitir. İyileşmek için önce yarayı kabul etmelisin. 🔮 GÜNÜN GÖREVİ: Canını sıkan o konuyu bir kağıda yaz, sonra o kağıdı yırtıp at.", "/images/46.jpeg", "Kalp kırıklığı. İyileşme.", "Kart 46", 45, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/47.jpeg", "Placeholder", "Kart 47", 46, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/48.jpeg", "Placeholder", "Kart 48", 47, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/49.jpeg", "Placeholder", "Kart 49", 48, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seni boğan şeyler gerçekler değil, zihninin ürettiği senaryolar. Yataktan kalk, ışığı aç ve korkularının ne kadar yersiz olduğunu gör. 🔮 GÜNÜN GÖREVİ: Uyumadan önce zihnini boşaltmak için 5 dakika meditasyon yap veya dua et.", "/images/50.jpeg", "Endişe. Kabus.", "Kart 50", 49, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/51.jpeg", "Placeholder", "Kart 51", 50, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doğrudan saldırmak yerine arka kapıdan dolaş. Planlarını kendine sakla. Zekanı kullan ve hedefine sessizce ulaş. 🔮 GÜNÜN GÖREVİ: Bugün hedeflerin hakkında kimseye bahsetme, sırrını kendine sakla.", "/images/52.jpeg", "Strateji. Gizlilik.", "Kart 52", 51, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/53.jpeg", "Placeholder", "Kart 53", 52, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/54.jpeg", "Placeholder", "Kart 54", 53, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Korkudan gözlerini kapattın. Seçim yapmamak da bir seçimdir. Gözündeki bağı çöz; mantığının ve kalbinin buluştuğu o kararı ver. 🔮 GÜNÜN GÖREVİ: Uzun süredir ertelediğin o kararı (küçük de olsa) bugün ver ve uygula.", "/images/55.jpeg", "Kararsızlık. Denge.", "Kart 55", 54, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duygularına yer yok. Kararların keskin bir kılıç gibi olmalı. Merhametle değil adaletle karar ver ve gerekeni yap. 🔮 GÜNÜN GÖREVİ: Bugün duygusal davranmayı bırak, olaylara sadece mantık çerçevesinden bak.", "/images/56.jpeg", "Otorite. Mantık.", "Kart 56", 55, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seni tutan tek şey \"Yapamam\" inancın. Gözlerini aç ve o görünmez hapishaneden kendi iradenle çık. 🔮 GÜNÜN GÖREVİ: \"Yapamam\" dediğin bir şeyi bugün yaparak kendine meydan oku.", "/images/57.jpeg", "Zihinsel hapis. Uyanış.", "Kart 57", 56, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zihnin çok aktif. Ancak her duyduğuna inanma; bilgiyi topla, analiz et ve sadece gerçeğin peşinden git. 🔮 GÜNÜN GÖREVİ: Merak ettiğin bir konuda derinlemesine bir araştırma yap, makale oku.", "/images/58.jpeg", "Merak. Haberci.", "Kart 58", 57, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ok yaydan çıktı. Hedefine doğru hızla ilerliyorsun. Hırsın gözünü kör etmesin, nereye koştuğunu bilerek hızlan. 🔮 GÜNÜN GÖREVİ: Bugün işlerini hızlıca hallet, zaman kaybetme, dinamik ol.", "/images/59.jpeg", "Hız. Hedefe kilitlenme.", "Kart 59", 58, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kader sana küçük bir mesaj gönderiyor. Hayata şüpheyle bakmayı bırak; içindeki çocuğu dinle ve o küçük jesti kabul et. 🔮 GÜNÜN GÖREVİ: Bugün birine beklemediği küçük bir sürpriz yap veya iltifat et.", "/images/60.jpeg", "Tatlı sürpriz. Haber.", "Kart 60", 59, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "İç sesin sana doğruyu söylüyor. Etrafına şifa yayıyorsun ama kendini unutma. Bugün mantığınla değil hislerinle hareket et. 🔮 GÜNÜN GÖREVİ: Bugün rüyalarını bir yere not et ve hislerine güvenerek hareket et.", "/images/61.jpeg", "Şefkat. Sezgi.", "Kart 61", 60, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fırtınalı denizde bile gemisini sakince yürüten kaptansın. Olaylara sakin yaklaş ve çevrendeki krizi bilgeliğinle çöz. 🔮 GÜNÜN GÖREVİ: Gergin bir ortamda sakinliğini koru ve arabulucu rolünü üstlen.", "/images/62.jpeg", "Duygusal denge. Huzur.", "Kart 62", 61, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zorlu kıyıları geride bırakıp sakin sulara açılıyorsun. Arkana bakma; bu bir kaçış değil, iyileşmek için çıkılan bir yolculuk. 🔮 GÜNÜN GÖREVİ: Seni üzen eski mesajları veya fotoğrafları bugün arşivle veya sil.", "/images/63.jpeg", "Geçiş dönemi. Umut.", "Kart 63", 62, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beyaz atlı prens veya ilham perisi kapıda. Rüyalar alemi güzeldir ama harekete geçmezsen hayal kalır. Kalbinin götürdüğü yere git. 🔮 GÜNÜN GÖREVİ: Hoşlandığın kişiye bir mesaj at veya partnerine romantik bir jest yap.", "/images/64.jpeg", "Romantizm. Teklif.", "Kart 64", 63, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evren sana kocaman bir \"Evet\" diyor. Dileğin gerçekleşmek üzere. Endişelenmeyi bırak, arkana yaslan ve anın tadını çıkar. 🔮 GÜNÜN GÖREVİ: Kendini şımart; en sevdiğin yemeği ye veya kendine bir hediye al.", "/images/65.jpeg", "Dilek kartı. Keyif.", "Kart 65", 64, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimsenin oyuncağı değilsin. Gereksiz insanları hayatından çıkarmaktan korkma. Sınırlarını net çiz ve taviz verme. 🔮 GÜNÜN GÖREVİ: Bugün sınırlarını ihlal eden birine nazikçe ama kesin bir dille dur de.", "/images/66.jpeg", "Dürüstlük. Netlik.", "Kart 66", 65, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bir devir kapandı, acı bitti. Artık daha kötüye gidemezsin. Yerden kalk, üzerindeki tozu silkele ve doğan güneşe bak. 🔮 GÜNÜN GÖREVİ: Sabah güneş doğarken uyan ve pencereyi açıp derin bir nefes al.", "/images/67.jpeg", "Bitiş. Yeni şafak.", "Kart 67", 66, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duygularına yer yok. Kararların keskin bir kılıç gibi olmalı. Merhametle değil adaletle karar ver ve gerekeni yap. 🔮 GÜNÜN GÖREVİ: Bugün duygusal davranmayı bırak, olaylara sadece mantık çerçevesinden bak.", "/images/68.jpeg", "Otorite. Mantık.", "Kart 68", 67, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Önünde sonsuz ihtimaller var. Mantığı bir kenara bırak. Çantana korkularını koyma, sadece kalbini al ve o ilk adımı at. 🔮 GÜNÜN GÖREVİ: Bugün daha önce hiç gitmediğin bir sokağa gir veya yeni bir şey dene.", "/images/69.jpeg", "Sıfır noktası. Cesaret.", "Kart 69", 68, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "İhtiyacın olan her şeye sahipsin. Beklemeyi bırak, plan yapma zamanı geçti; şimdi sihrini konuşturma ve yapma zamanı. 🔮 GÜNÜN GÖREVİ: Aynanın karşısına geç, gözlerinin içine bak ve \"Ben yapabilirim\" de.", "/images/70.jpeg", "Yaratım gücü. Yetenek.", "Kart 70", 69, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sırtındaki yükler seni yere eğmiş olabilir. Hedefe çok yaklaştın. Ancak her şeyi tek başına yapamazsın; bugün yardım iste. 🔮 GÜNÜN GÖREVİ: Üzerindeki iş yükünü hafifletmek için bir işi başkasına devret.", "/images/71.jpeg", "Ağır yük. Sorumluluk.", "Kart 71", 70, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/72.jpeg", "Placeholder", "Kart 72", 71, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatının kontrolünü eline al. Kuralları sen koy. Duygusal davranma; dik dur, planını yap ve disiplinle uygula. 🔮 GÜNÜN GÖREVİ: Hayatındaki düzensiz bir alanı (masa, dolap veya planlar) bugün düzenle.", "/images/73.jpeg", "Otorite. Düzen.", "Kart 73", 72, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cevaplar dış dünyada değil, içindeki sessizlikte. Mantığını devre dışı bırak. Bugün rüyalarına ve ilk hissine güven. 🔮 GÜNÜN GÖREVİ: Bugün fal baktır, meditasyon yap veya sadece iç sesini dinle.", "/images/74.jpeg", "Sezgi. Gizem.", "Kart 74", 73, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dünya avuçlarının içinde. Güvenli limanda kalmak mı, yoksa ufka açılmak mı? Korkma, büyük düşün ve o ilk adımı at. 🔮 GÜNÜN GÖREVİ: Gelecek 1 yıl için en büyük hedefini bir kağıda yaz ve duvara as.", "/images/75.jpeg", "Planlama. Vizyon.", "Kart 75", 74, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evren sana yanan bir meşale uzatıyor. Aklındaki o yeni fikri veya projeyi hayata geçirmek için en doğru gün bugündür. Başla! 🔮 GÜNÜN GÖREVİ: Aklına gelen o çılgın fikri not al ve hemen ilk araştırmasını yap.", "/images/76.jpeg", "Kıvılcım. İlham.", "Kart 76", 75, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeholder", "/images/77.jpeg", "Placeholder", "Kart 77", 76, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "İlerlemek için bazen durmak gerekir. Çabalamayı bırak, olaylara tersten bak; çözümün aslında sorunun içinde olduğunu göreceksin. 🔮 GÜNÜN GÖREVİ: Bugün bir olay karşısında hemen tepki verme, dur ve karşı tarafı anlamaya çalış.", "/images/78.jpeg", "Farklı bakış. Bekleyiş.", "Kart 78", 77, null, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 78);

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

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "The Fool represents new beginnings, innocence, spontaneity, and a leap of faith. This card encourages you to embrace the unknown with optimism and trust in the journey ahead. It symbolizes the pure potential of new experiences and the courage to step into uncharted territory.", "/images/fool.svg", "New beginnings, innocence, spontaneity, and a leap of faith." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "The Magician represents manifestation, willpower, skill, and the power to create your reality. This card shows that you have all the tools and resources needed to achieve your goals. It encourages you to take action and use your talents to manifest your desires.", "/images/magician.svg", "Manifestation, willpower, skill, and the power to create your reality." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "The High Priestess represents intuition, subconscious knowledge, mystery, and spiritual insight. This card encourages you to trust your inner voice and pay attention to your dreams and intuition. It symbolizes the hidden knowledge that comes from within.", "/images/high-priestess.svg", "Intuition, subconscious knowledge, mystery, and spiritual insight." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "The Empress represents fertility, abundance, creativity, and nurturing energy. This card symbolizes the divine feminine and the power of creation. It encourages you to embrace your creative side and nurture your projects and relationships with love and care.", "/images/empress.svg", "Fertility, abundance, creativity, and nurturing energy." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "The Emperor represents authority, structure, leadership, and establishing order. This card encourages you to take charge of your life and create stability through discipline and organization. It symbolizes the power of structure and the importance of setting boundaries.", "/images/emperor.svg", "Authority, structure, leadership, and establishing order." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "The Hierophant represents tradition, spiritual guidance, learning, and conventional wisdom. This card encourages you to seek knowledge from established sources and follow traditional paths of learning. It symbolizes the importance of spiritual guidance and structured learning.", "/images/hierophant.svg", "Tradition, spiritual guidance, learning, and conventional wisdom." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "The Lovers represents love, relationships, choices, and harmony between opposites. This card encourages you to make choices based on love and to seek harmony in your relationships. It symbolizes the power of love to unite different aspects of life.", "/images/lovers.svg", "Love, relationships, choices, and harmony between opposites." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "The Chariot represents determination, willpower, victory, and overcoming obstacles. This card encourages you to stay focused on your goals and use your willpower to overcome challenges. It symbolizes the power of determination to achieve success.", "/images/chariot.svg", "Determination, willpower, victory, and overcoming obstacles." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Strength represents inner strength, courage, patience, and compassion. This card encourages you to find strength within yourself and to approach challenges with patience and compassion. It symbolizes the power of inner strength over physical force.", "/images/strength.svg", "Inner strength, courage, patience, and compassion." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "The Hermit represents soul-searching, introspection, inner guidance, and wisdom. This card encourages you to take time for self-reflection and to seek answers within yourself. It symbolizes the importance of inner wisdom and spiritual guidance.", "/images/hermit.svg", "Soul-searching, introspection, inner guidance, and wisdom." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "The Wheel of Fortune represents change, cycles, destiny, and the turning of fate. This card reminds you that life is cyclical and that change is inevitable. It encourages you to embrace the ups and downs of life and trust in the natural flow of destiny.", "/images/wheel-of-fortune.svg", "Change, cycles, destiny, and the turning of fate." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Justice represents fairness, truth, balance, and karmic justice. This card encourages you to seek truth and fairness in all your dealings. It symbolizes the importance of balance and the concept that what goes around comes around.", "/images/justice.svg", "Fairness, truth, balance, and karmic justice." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "The Hanged Man represents sacrifice, letting go, new perspectives, and spiritual growth. This card encourages you to let go of what no longer serves you and to see things from a different perspective. It symbolizes the power of surrender and spiritual enlightenment.", "/images/hanged-man.svg", "Sacrifice, letting go, new perspectives, and spiritual growth." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Death represents transformation, endings, change, and rebirth. This card encourages you to embrace change and let go of what needs to end. It symbolizes the natural cycle of death and rebirth that leads to transformation and new beginnings.", "/images/death.svg", "Transformation, endings, change, and rebirth." });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FullDescription", "ImageUrl", "Meaning" },
                values: new object[] { "Temperance represents balance, moderation, patience, and finding middle ground. This card encourages you to find balance in all aspects of your life and to practice patience and moderation. It symbolizes the importance of harmony and the art of finding the right balance.", "/images/temperance.svg", "Balance, moderation, patience, and finding middle ground." });
        }
    }
}
