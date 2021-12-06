using System;
using Microsoft.AspNetCore.Mvc;

namespace dojoSurvey.Controllers
{
    public class MainController : Controller
    {
        //This is where my routes and controls go
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("results")]
        public IActionResult Process(string userName, string location, string language, string comment)
        {
            ViewBag.name = userName;
            ViewBag.dojoLocation = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            Console.WriteLine(ViewBag.dojoLocation);
            return View("Results");
        }

    }
}