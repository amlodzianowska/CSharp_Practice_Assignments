using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dojoSurveyModel.Models;

namespace dojoSurveyModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        static User newUser;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(User user)
        {
            if (ModelState.IsValid)
            {
                newUser = user;
                return RedirectToAction("Results");
            } else {
                return View("Index");
            }
        }

        [HttpGet("results")]
        public IActionResult Results()
        {
            return View(newUser);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
