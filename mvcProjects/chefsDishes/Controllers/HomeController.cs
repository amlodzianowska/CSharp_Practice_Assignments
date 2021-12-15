using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using chefsDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace chefsDishes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs.Include(a => a.MyDishes).ToList();
            return View();
        }

        [HttpGet("newChef")]
        public IActionResult addChef()
        {
            return View("addChef");
        }

        [HttpGet("newDish")]
        public IActionResult addDish()
        {
            ViewBag.AllChefs = _context.Chefs.Include(a => a.MyDishes).ToList();
            return View("addDish");
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewBag.dishWithChef = _context.Dishes.Include(dish => dish.MyChef).ToList();
            return View("Dishes");
        }

        [HttpPost("addChef")]
        public IActionResult addChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }else {
                ViewBag.AllChefs = _context.Chefs.Include(a => a.MyDishes).ToList();
                return View("Index");
            }
        }

        [HttpPost("addDish")]
        public IActionResult addDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }else {
                ViewBag.AllChefs = _context.Chefs.Include(a => a.MyDishes).ToList();
                return View("addDish");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
