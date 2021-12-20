using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using weddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace weddingPlanner.Controllers
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
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("loggedInUser", newUser.UserId);
                return RedirectToAction("Dashboard");
            }else{
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LogUser logUser)
        {
            if(ModelState.IsValid)
            {
                User userinDb = _context.Users.FirstOrDefault(u => u.Email == logUser.LogEmail);
                if(userinDb == null)
                {
                    ModelState.AddModelError("LogEmail", "Invalid login attempt");
                    return View("Index");
                }
                PasswordHasher<LogUser> Hasher = new PasswordHasher<LogUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logUser, userinDb.Password, logUser.LogPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("LogEmail", "Invalid login attempt");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("loggedInUser", userinDb.UserId);
                return RedirectToAction("Dashboard");
            }else {
                return View("Index");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.AllWeddings = _context.Weddings.Include(f => f.Host).Include(d => d.WeddingGuests).ThenInclude(g => g.Guest).OrderBy(s => s.UpdatedAt).ToList();
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d => d.UserId == (int)HttpContext.Session.GetInt32("loggedInUser"));
            return View();
        }

        [HttpGet("newWedding")]
        public IActionResult NewWedding()
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost("addWedding")]
        public IActionResult AddWedding(Wedding newWedding)
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            if(ModelState.IsValid)
            {
                newWedding.UserId = (int)HttpContext.Session.GetInt32("loggedInUser");
                _context.Add(newWedding);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            }else {
                return View("NewWedding");
            }
        }
        
        [HttpGet("rsvp/{weddingId}/{userId}")]
        public IActionResult Rsvp(int weddingId, int userId)
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            if(HttpContext.Session.GetInt32("loggedInUser") != userId)
            {
                return RedirectToAction("Logout");
            }
            Attendance attend = new Attendance();
            attend.WeddingId = weddingId;
            attend.UserId = userId;
            _context.Add(attend);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("delete/{WeddingId}")]
        public IActionResult Delete(int WeddingId)
        {
            Wedding WeddingToDelete = _context.Weddings.FirstOrDefault(p => p.WeddingId == WeddingId);
            if(HttpContext.Session.GetInt32("loggedInUser") != WeddingToDelete.UserId)
            {
                return RedirectToAction("Logout");
            }
            _context.Weddings.Remove(WeddingToDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("wedding/{weddingId}")]
        public IActionResult OneWedding(int weddingId)
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d => d.UserId == (int)HttpContext.Session.GetInt32("loggedInUser"));
            Wedding oneWedding = _context.Weddings.Include(f => f.WeddingGuests).ThenInclude(f => f.Guest).FirstOrDefault(p => p.WeddingId == weddingId);
            return View(oneWedding);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
