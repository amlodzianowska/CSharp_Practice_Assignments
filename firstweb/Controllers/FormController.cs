using System;
using Microsoft.AspNetCore.Mvc;

namespace firstWeb.Controllers
{
    public class FormController : Controller
    {
        public static string pName;
        public static string pType;

        //This is where my routes and controls go
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(string petName, string petType)
        {
            // Console.WriteLine($"Pet Name: {petName}, Pet Type: {petType}"); 
            pName = petName;
            pType = petType;
            return RedirectToAction("Result");
        }

        [HttpGet]
        [Route("Result")]
        public IActionResult Result()
        {
            ViewBag.Name = pName;
            ViewBag.Type = pType;
            return View("Result");
        }


    // }
    }
}