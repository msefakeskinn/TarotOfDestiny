using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TarotOfDestiny.Models;

namespace TarotOfDestiny.Controllers
{
    public class OrderController : Controller
    {
        private readonly TarotDbContext _context;

        public OrderController(TarotDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var orderContent = await _context.OrderPageContents.FirstOrDefaultAsync() ?? new OrderPageContent();
            return View(orderContent);
        }

        [HttpPost]
        public async Task<IActionResult> Submit(string name, string email, string question)
        {
            var orderContent = await _context.OrderPageContents.FirstOrDefaultAsync() ?? new OrderPageContent();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(question))
            {
                ViewBag.Error = orderContent.ErrorMessageFormat;
                return View("Index", orderContent);
            }

            // Create new order submission
            var orderSubmission = new OrderSubmission
            {
                Name = name,
                Email = email,
                Question = question,
                SubmissionDate = DateTime.Now
            };

            try
            {
                _context.OrderSubmissions.Add(orderSubmission);
                await _context.SaveChangesAsync();

                ViewBag.SuccessMessage = string.Format(orderContent.SuccessMessageFormat, name);
            }
            catch (Exception)
            {
                ViewBag.Error = "An error occurred while submitting your question. Please try again.";
            }

            return View("Index", orderContent);
        }
    }
}



