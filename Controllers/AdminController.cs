using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TarotOfDestiny.Models;

namespace TarotOfDestiny.Controllers
{
    public class AdminController : Controller
    {
        private readonly TarotDbContext _context;
        private const string AdminPassword = "tarot123"; // Simple password for demo

        public AdminController(TarotDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string password)
        {
            if (password == AdminPassword)
            {
                HttpContext.Session.SetString("IsAdmin", "true");
                return RedirectToAction("Index");
            }

            ViewBag.Error = "Invalid password.";
            return View();
        }

        public IActionResult Index()
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Login");
            }

            var cards = _context.TarotCards.ToList();
            return View(cards);
        }

        public IActionResult Create()
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Login");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TarotCard card)
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Login");
            }

            if (ModelState.IsValid)
            {
                card.CreatedAt = DateTime.Now;
                card.UpdatedAt = DateTime.Now;
                _context.TarotCards.Add(card);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(card);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Login");
            }

            var card = await _context.TarotCards.FindAsync(id);
            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, TarotCard card)
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Login");
            }

            if (id != card.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    card.UpdatedAt = DateTime.Now;
                    _context.Update(card);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TarotCardExists(card.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }

            return View(card);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Login");
            }

            var card = await _context.TarotCards.FindAsync(id);
            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Login");
            }

            var card = await _context.TarotCards.FindAsync(id);
            if (card != null)
            {
                _context.TarotCards.Remove(card);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("IsAdmin");
            return RedirectToAction("Login");
        }

        private bool IsAdmin()
        {
            return HttpContext.Session.GetString("IsAdmin") == "true";
        }

        private bool TarotCardExists(int id)
        {
            return _context.TarotCards.Any(e => e.Id == id);
        }

        // HomePageContent Management
        public async Task<IActionResult> EditHomePage()
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Login");
            }

            var homePageContent = await _context.HomePageContents.FirstOrDefaultAsync();
            if (homePageContent == null)
            {
                // Create default content if none exists
                homePageContent = new HomePageContent
                {
                    PageTitle = "Kader Kutusu - Ana Sayfa",
                    MainHeading = "Evrenin sana göndereceği mesajı keşfet.",
                    SubHeading = "Kutunun kedisi bugün senin kartını seçti.",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                _context.HomePageContents.Add(homePageContent);
                await _context.SaveChangesAsync();
            }

            return View(homePageContent);
        }

        [HttpPost]
        public async Task<IActionResult> EditHomePage(HomePageContent homePageContent)
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Login");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    homePageContent.UpdatedAt = DateTime.Now;
                    _context.Update(homePageContent);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Home page content updated successfully!";
                    return RedirectToAction("Index");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomePageContentExists(homePageContent.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return View(homePageContent);
        }

        private bool HomePageContentExists(int id)
        {
            return _context.HomePageContents.Any(e => e.Id == id);
        }

        // OrderPageContent Management
        public async Task<IActionResult> EditOrderPage()
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Login");
            }

            var orderPageContent = await _context.OrderPageContents.FirstOrDefaultAsync();
            if (orderPageContent == null)
            {
                // Create default content if none exists
                orderPageContent = new OrderPageContent
                {
                    Title = "✨ Get Your Personalized Tarot Reading",
                    Subtitle = "Unlock the mysteries of your destiny with a custom tarot reading",
                    NameLabel = "Your Name",
                    EmailLabel = "Email Address",
                    QuestionLabel = "Your Question",
                    SubmitButtonText = "Submit Reading Request 🔮",
                    SuccessMessageFormat = "Thank you, {0}! Your personalized tarot reading will be prepared within 24 hours. We'll send your mystical insights to your email address.",
                    ErrorMessageFormat = "Please fill in all fields.",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                _context.OrderPageContents.Add(orderPageContent);
                await _context.SaveChangesAsync();
            }

            return View(orderPageContent);
        }

        [HttpPost]
        public async Task<IActionResult> EditOrderPage(OrderPageContent orderPageContent)
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Login");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    orderPageContent.UpdatedAt = DateTime.Now;
                    _context.Update(orderPageContent);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Order page content updated successfully!";
                    return RedirectToAction("Index");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderPageContentExists(orderPageContent.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return View(orderPageContent);
        }

        private bool OrderPageContentExists(int id)
        {
            return _context.OrderPageContents.Any(e => e.Id == id);
        }

        // Order Submissions Management
        public async Task<IActionResult> ListOrders()
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Login");
            }

            var orders = await _context.OrderSubmissions
                .OrderByDescending(o => o.SubmissionDate)
                .ToListAsync();

            return View(orders);
        }
    }
}



