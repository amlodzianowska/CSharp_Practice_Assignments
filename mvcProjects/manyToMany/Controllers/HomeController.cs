using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using manyToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace manyToMany.Controllers
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
            ViewBag.AllMovies = _context.Movies.OrderBy(m => m.Title).ToList();
            return View();
        }

        [HttpGet("actors")]
        public IActionResult Actors()
        {
            ViewBag.AllActors = _context.Actors.OrderBy(a => a.LName).ToList();
            return View();
        }

        [HttpGet("movie/{movieId}")]
        public IActionResult OneMovie(int movieId)
        {
            ViewBag.AllActors = _context.Actors.OrderBy(a => a.LName).ToList();
            Movie one = _context.Movies.Include(f => f.CastList).ThenInclude(g => g.Actor).FirstOrDefault(d => d.MovieId == movieId);
            return View(one);
        }

        [HttpGet("actor/{actorId}")]
        public IActionResult OneActor(int actorId)
        {
            ViewBag.AllMovies = _context.Movies.OrderBy(m => m.Title).ToList();
            Actor one = _context.Actors.Include(f => f.ActedIn).ThenInclude(g => g.Movie).FirstOrDefault(d => d.ActorId == actorId);
            return View(one);
        }

        [HttpPost("addMovie")]
        public IActionResult addMovie(Movie newMovie)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newMovie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }else{
                ViewBag.AllMovies = _context.Movies.OrderBy(m => m.Title).ToList();
                return View("Index");
            }
        }

        [HttpPost("addActor")]
        public IActionResult addActor(Actor newActor)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newActor);
                _context.SaveChanges();
                return RedirectToAction("Actors");
            }else{
                ViewBag.AllActors = _context.Actors.OrderBy(a => a.LName).ToList();
                return View("Actors");
            }
        }

        [HttpPost("addToCast")]
        public IActionResult addToCast(Cast newRole)
        {
            _context.Add(newRole);
            _context.SaveChanges();
            return Redirect($"/movie/{newRole.MovieId}");
        }

        [HttpPost("addRole")]
        public IActionResult addToRoles(Cast newRole)
        {
            _context.Add(newRole);
            _context.SaveChanges();
            return Redirect($"/actor/{newRole.ActorId}");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
