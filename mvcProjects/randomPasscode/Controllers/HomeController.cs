using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using randomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace randomPasscode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        static string Passcode;
        static int? amount = 1;

        public string generatePassword(int len)
        {
            string alphabet= "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string randomPasscode = "";
            Random rand = new Random();
            for (int i = 0; i <=len; i++)
            {
                randomPasscode = randomPasscode + alphabet[rand.Next(alphabet.Length)];
            }
            return randomPasscode;
        }


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("passcode") == null)
            {
                HttpContext.Session.SetString("passcode", "Click to Start!");
            }
            if(HttpContext.Session.GetInt32("total") == null)
            {
                HttpContext.Session.SetInt32("total",0);
            }

            ViewBag.Passcode = HttpContext.Session.GetString("passcode");
            ViewBag.Total = HttpContext.Session.GetInt32("total");

            return View();
        }

        [HttpGet("generate")]
        public IActionResult Generate()
        {
            int? total = HttpContext.Session.GetInt32("total");
            HttpContext.Session.SetInt32("Total", (int)++total);
            HttpContext.Session.GetString("passcode");
            HttpContext.Session.SetString("passcode", generatePassword(14));
            Console.WriteLine(Passcode);

            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
