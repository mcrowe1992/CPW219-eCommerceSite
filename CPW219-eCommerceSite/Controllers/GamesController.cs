using CPW219_eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CPW219_eCommerceSite.Controllers
{
    public class GamesController : Controller
    {
        

        [HttpGet]
        public IActionResult CreateWithModelBinding() 
        { 
            return View(); 
        }

        [HttpPost]
        public IActionResult CreateWithModelBinding(Games g)
        {  
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(g);
        }
    }
}
