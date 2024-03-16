using CPW219_eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using CPW219_eCommerceSite.Data;

namespace CPW219_eCommerceSite.Controllers
{
    public class MembersController : Controller
    {
        private readonly GamesContext _context;

        public MembersController(GamesContext context) 
        { 
            _context = context;
        }  

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel regModel) 
        { 
            if (ModelState.IsValid) 
            {
                // Map RegisterViewModel data ti Member object
                Member newMember = new()
                {
                    Email = regModel.Email,
                    Password = regModel.Password,

                };

                _context.Members.Add(newMember);
                await _context.SaveChangesAsync();

                // Redirect to home page
                return RedirectToAction("Index", "Home");   
            }
            return View(regModel);
        }
    }
}
