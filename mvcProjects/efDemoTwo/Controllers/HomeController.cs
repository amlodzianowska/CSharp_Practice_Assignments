using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using efDemoTwo.Models;
using Microsoft.EntityFrameworkCore;


namespace efDemoTwo.Controllers
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
            //                       DB   Table  .Actions
            ViewBag.allAnimals = _context.Animals.ToList();
            return View();
        }

        [HttpPost("addAnimal")]
        public IActionResult addAnimal(Animal newAnimal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newAnimal);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }else{
                return View("Index");
            }
        }

        [HttpGet("animal/{anId}")]
        public IActionResult oneAnimal(int anId)
        {
            Animal one = _context.Animals.FirstOrDefault(a => a.AnimalId == anId);
            return View(one);
        }

        [HttpGet("delete/{anId}")]
        public IActionResult deleteAnimal(int anId)
        {
            Animal one = _context.Animals.FirstOrDefault(a => a.AnimalId == anId);
            _context.Remove(one);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{anId}")]
        public IActionResult Edit(int anId)
        {
            Animal oneAnimal = _context.Animals.FirstOrDefault(a => a.AnimalId == anId);
            return View(oneAnimal);
        }

        [HttpPost("updateAnimal/{anId}")]
        public IActionResult Update(int anId, Animal edited)
        {
            Animal original = _context.Animals.FirstOrDefault(a => a.AnimalId == anId);
            original.Species = edited.Species;
            original.numLegs = edited.numLegs;
            original.isMammal = edited.isMammal;
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
