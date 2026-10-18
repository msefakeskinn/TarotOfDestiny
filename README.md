# 🔮 Kader Kutusu (Tarot of Destiny)

**Kader Kutusu**, fiziksel e-ticaret ürünlerini (özel tasarım takı, tarot kartı) QR kod entegrasyonuyla dijital bir web deneyimine dönüştüren **ASP.NET Core MVC** tabanlı bir web uygulamasıdır.

Kullanıcılar kutu içerisinden çıkan özel QR kodu telefonlarıyla okutarak, veritabanında tanımlı 78 özgün tarot kartından kendilerine çıkan kartın dijital fısıltısına, anlamlarına ve rehberlik mesajlarına anında erişebilirler.

---

## 📸 Ekran Görüntüleri

<img width="1871" height="902" alt="Ekran görüntüsü 2026-10-18 184355" src="https://github.com/user-attachments/assets/2a01a3fc-86f0-4314-a457-c581d1b7ed39" />
<img width="1827" height="890" alt="Ekran görüntüsü 2026-10-18 184531" src="https://github.com/user-attachments/assets/c8fc18e6-68bd-4a10-a0b3-fe3f5fe09940" />
<img width="1767" height="886" alt="Ekran görüntüsü 2026-10-18 185443" src="https://github.com/user-attachments/assets/678d09b6-20d7-4256-9b19-1c6b1dee2726" />
<img width="1806" height="817" alt="Ekran görüntüsü 2026-10-18 185325" src="https://github.com/user-attachments/assets/b42a925e-7246-47e4-95bc-892b91cfac54" />


---

## 🚀 Öne Çıkan Özellikler

- **QR Kod Yönlendirme:** Kutudaki QR kod okutulduğunda doğrudan ilgili kartın detay sayfasına (`/Cards/Details/{id}`) giden dinamik yönlendirme altyapısı.
- **78 Özgün Tarot Kartı Veritabanı:** Her kart için ayrı ayrı tanımlanmış görsel, başlık, kısa özet ve detaylı fısıltı içerikleri.
- **Shopier E-Ticaret Entegrasyonu:** Web arayüzünden doğrudan satın alma sayfasına pürüzsüz yönlendirme.
- **Responsive Mobil Arayüz:** Mobil cihazlarda akıcı çalışan modern ve mistik tema tasarımı.
- **EF Core Code-First Mimarisi:** Entity Framework Core ve SQL Server tabanlı esnek veri yönetimi.

---

## 🛠️ Kullanılan Teknolojiler

- **Backend:** C#, .NET (ASP.NET Core MVC)
- **Database & ORM:** MS SQL Server, Entity Framework Core
- **Frontend:** HTML5, CSS3, JavaScript, Bootstrap
- **Entegrasyon:** Shopier Payment API

---

## ⚙️ Kurulum ve Çalıştırma

1. Projeyi yerel ortamınıza klonlayın:
   git clone https://github.com/kullanici-adiniz/TarotOfDestiny.git
   cd TarotOfDestiny

2. appsettings.json dosyasındaki veritabanı bağlantı dizesini güncelleyin:
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=TarotOfDestinyDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
   }

3. Veritabanı migration işlemlerini uygulayın:
   dotnet ef database update

4. Uygulamayı başlatın:
   dotnet run

---

## 📄 Proje Yapısı

TarotOfDestiny/
├── Controllers/      # Kart ve yönlendirme mantığını yöneten kontrolcüler
├── Migrations/       # Veritabanı verileri ve şema geçmişi
├── Models/           # Card modeli ve veri yapıları
├── Program.cs        # Uygulama başlangıç ve servis yapılandırması
├── appsettings.json  # Veritabanı ve ortam ayarları
└── TarotOfDestiny.sln

---

## 📜 Lisans

Bu proje açık kaynaklı olarak geliştirilmiştir.<img width="1871" height="902" alt="Ekran görüntüsü 2026-10-18 184355" src="https://github.com/user-attachments/assets/e362b618-33d3-44ac-b98a-a0ed65717d4e" />
