﻿using CPW219_eCommerceSite.Data;
using CPW219_eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CPW219_eCommerceSite.Controllers
{
    public class GamesController : Controller
    {

        private readonly GamesContext _context;

		public GamesController(GamesContext context)
		{
			_context = context;
		}

        public IActionResult Index()
        {
            // Get all games form the DB
            List<Games> game = _context.Game.ToList();

            // Show them on the page

            return View(game);
        }

		[HttpGet]
        public IActionResult CreateWithModelBinding() 
        { 
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> CreateWithModelBinding(Games g)
        {  
            if (ModelState.IsValid)
            {
                _context.Game.Add(g); //Prepares insert
                await _context.SaveChangesAsync(); //Executes pending insert

                ViewData["Message"] = $"{g.Title} was added successfully!";
                return View();
            }

            return View(g);
        }
    }
}
