using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TarotOfDestiny.Models;

namespace TarotOfDestiny.Controllers
{
    public class CardsController : Controller
    {
        private readonly TarotDbContext _context;

        public CardsController(TarotDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var cards = await _context.TarotCards.ToListAsync();
            return View(cards);
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(int number)
        {
            var card = await _context.TarotCards.FirstOrDefaultAsync(c => c.Number == number);

            if (card != null)
            {
                return RedirectToAction("Details", "Cards", new { id = card.Id });
            }
            else
            {
                TempData["ErrorMessage"] = $"No card found with number {number}. Please try a number between 0 and 77.";
                return View();
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            var card = await _context.TarotCards.FirstOrDefaultAsync(c => c.Id == id);

            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        public IActionResult HizliKartYukle()
        {
            // 1. WhatsApp resimlerinin olduğu klasör (Yolunu kontrol et)
            string kaynakKlasor = @"C:\TarotResimleri";

            // Hedef klasör (Projenin içindeki wwwroot/images)
            string hedefKlasor = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
            if (!Directory.Exists(hedefKlasor)) Directory.CreateDirectory(hedefKlasor);

            // 2. Klasördeki tüm resim dosyalarını bul (Sırası önemli değil, rastgele alır)
            var dosyalar = Directory.GetFiles(kaynakKlasor, "*.*")
                                    .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png"))
                                    .ToList();

            int sayac = 0;

            foreach (var dosyaYolu in dosyalar)
            {
                // 3. Dosyayı "0.jpg", "1.jpg" diye biz yeniden isimlendiriyoruz.
                // Böylece WhatsApp'ın karışık isimlerinden kurtuluyoruz.
                string uzanti = Path.GetExtension(dosyaYolu); // .jpg veya .png
                string yeniDosyaAdi = $"{sayac}{uzanti}"; // Örn: 0.jpg
                string hedefYol = Path.Combine(hedefKlasor, yeniDosyaAdi);

                // Veritabanında bu numarayla kart var mı? Yoksa ekle.
                string kartAdi = sayac.ToString(); // İsim yerine sadece sayı: "0", "1"

                if (!_context.TarotCards.Any(c => c.Name == kartAdi))
                {
                    // Resmi yeni ismiyle kopyala
                    System.IO.File.Copy(dosyaYolu, hedefYol, true);

                    // Veritabanı kaydı
                    var yeniKart = new TarotCard
                    {
                        Name = kartAdi, // Ekranda görünecek isim: "0", "1"
                        ImageUrl = yeniDosyaAdi, // Resim yolu: "0.jpg"
                        Meaning = "Gizemli bir kart...", // Geçici anlam
                    };

                    _context.TarotCards.Add(yeniKart);

                    // Sayacı artır ki bir sonraki kart "1", sonraki "2" olsun
                    sayac++;
                }
            }

            _context.SaveChanges();

            return Content($"İşlem tamam! {sayac} adet fotoğraf otomatik isimlendirilip yüklendi.");
        }
        [HttpGet]
        public IActionResult YollariDuzelt()
        {
            var cards = _context.TarotCards.ToList();

            foreach (var card in cards)
            {
                if (!string.IsNullOrEmpty(card.ImageUrl))
                {
                    if (!card.ImageUrl.StartsWith("images/"))
                    {
                        card.ImageUrl = "images/" + card.ImageUrl;
                    }
                }
            }

            _context.SaveChanges();

            return Content("HARİKA! Tüm resim yolları başarıyla düzeltildi 🚀");
        }

    }
}

