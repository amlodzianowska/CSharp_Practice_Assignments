using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            // IEnumerable<Dish> allDishes = _context.Dishes.ToList();
            ViewBag.allDishes = _context.Dishes.ToList();
            return View();
        }

        [HttpGet("newDish")]
        public IActionResult newDish()
        {
            return View("newDish");
        }

        [HttpPost("addDish")]
        public IActionResult addDish(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }else{
                return View("Index");
            }
        }

        [HttpGet("dish/{dishId}")]
        public IActionResult oneDish(int dishId)
        {
            ViewBag.oneDish = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View("oneDish");
        }

        [HttpGet("edit/{dishId}")]
        public IActionResult Edit(int dishId)
        {
            Dish oneDish = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View(oneDish);
        }

        [HttpGet("delete/{dishId}")]
        public IActionResult deleteDish(int dishId)
        {
            Dish oneDish = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
            _context.Remove(oneDish);
            _context.SaveChanges();
            return View("oneDish");
        }

        [HttpPost("updateDish/{dishId}")]
        public IActionResult Update(int dishId, Dish edited)
        {
            Dish original = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
            original.Name = edited.Name;
            original.Chef = edited.Chef;
            original.Tastiness = edited.Tastiness;
            original.Calories = edited.Calories;
            original.Description = edited.Description;
            original.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
