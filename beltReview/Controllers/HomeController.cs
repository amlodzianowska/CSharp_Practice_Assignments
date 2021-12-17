using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using beltReview.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace beltReview.Controllers
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

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d => d.UserId == (int)HttpContext.Session.GetInt32("loggedInUser"));
            ViewBag.AllPosts = _context.Posts.Include(d => d.Poster).OrderBy(s => s.UpdatedAt).ToList();
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use!");
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
                User userindb = _context.Users.FirstOrDefault(u => u.Email == logUser.LEmail);
                if(userindb == null)
                {
                    ModelState.AddModelError("LEmail", "Invalid login attempt");
                    return View("Index");
                }
                PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
                var result = hasher.VerifyHashedPassword(logUser, userindb.Password, logUser.LPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("LEmail", "Invalid login attempt");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("loggedInUser", userindb.UserId);
                return RedirectToAction("Dashboard");
            }else{
                return View("Index");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("addPost")]
        public IActionResult AddPost()
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost("createPost")]
        public IActionResult CreatePost(Post newPost)
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            if(ModelState.IsValid)
            {
                newPost.UserId = (int)HttpContext.Session.GetInt32("loggedInUser");
                _context.Add(newPost);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            }else {
                return View("AddPost");
            }
        }

        [HttpGet("post/{postId}")]
        public IActionResult OnePost(int postId)
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d => d.UserId == (int)HttpContext.Session.GetInt32("loggedInUser"));
            Post onePost = _context.Posts.Include(f => f.Poster).FirstOrDefault(p => p.PostId == postId);
            return View(onePost);
        }

        [HttpGet("edit/{postId}")]
        public IActionResult Edit(int postId)
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            Post postToEdit = _context.Posts.FirstOrDefault(p => p.PostId == postId);
            return View(postToEdit);
        }

        [HttpPost("update/{postId}")]
        public IActionResult Update(Post newVersion, int postId)
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            Post postToUpdate = _context.Posts.FirstOrDefault(p => p.PostId == postId);
            if(HttpContext.Session.GetInt32("loggedInUser") != postToUpdate.UserId)
            {
                return RedirectToAction("Logout");
            }
            postToUpdate.URL = newVersion.URL;
            postToUpdate.Description = newVersion.Description;
            postToUpdate.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("delete/{postId}")]
        public IActionResult Delete(int postId)
        {
            Post postToDelete = _context.Posts.FirstOrDefault(p => p.PostId == postId);
            if(HttpContext.Session.GetInt32("loggedInUser") != postToDelete.UserId)
            {
                return RedirectToAction("Logout");
            }
            _context.Posts.Remove(postToDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
