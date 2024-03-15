using CPW219_eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CPW219_eCommerceSite.Controllers
{
    public class GamesController : Controller
    {
        // GET: /Games/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] // This action is hit after the user submits form data
        public IActionResult Create(IFormCollection formData) 
        {
            Games g = new()
            {

            };

            // Validate all data

            // Add to database

            // Return a view
            return RedirectToAction("Index", "Home");
        }
    }
}
