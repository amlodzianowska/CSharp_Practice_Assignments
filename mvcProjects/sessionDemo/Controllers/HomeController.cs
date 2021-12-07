using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sessionDemo.Models;
using Microsoft.AspNetCore.Http;

namespace sessionDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        static Player user;
        static Player Opponent = new Player();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(Player newPlayer)
        {
            user = newPlayer;
            Opponent.name = "Player 2";
            HttpContext.Session.SetInt32("PlayerOneWins", 0);
            HttpContext.Session.SetInt32("PlayerTwoWins", 0);
            HttpContext.Session.SetInt32("Ties", 0);
            HttpContext.Session.SetInt32("TotalPlays", 0);
            return RedirectToAction("Game");
        }

        [HttpGet("game")]
        public IActionResult Game()
        {
            ViewBag.User = user;
            ViewBag.Opponent = Opponent;
            ViewBag.PlayerOneWins = HttpContext.Session.GetInt32("PlayerOneWins");
            ViewBag.PlayerTwoWins = HttpContext.Session.GetInt32("PlayerTwoWins");
            ViewBag.Ties = HttpContext.Session.GetInt32("Ties");
            ViewBag.TotalPlays = HttpContext.Session.GetInt32("TotalPlays");
            return View();
        }

        [HttpGet("playRound")]
        public IActionResult playRound()
        {
            user.PlayHand();
            Opponent.PlayHand();
            if(user.hand == "Paper" && Opponent.hand == "Scissors")
            {
                int? amount = HttpContext.Session.GetInt32("PlayerTwoWins");
                HttpContext.Session.SetInt32("PlayerTwoWins", (int)++amount);
            } else if (user.hand == "Paper" && Opponent.hand == "Rock")
            {
                int? amount = HttpContext.Session.GetInt32("PlayerOneWins");
                HttpContext.Session.SetInt32("PlayerOneWins", (int)++amount);
            } else if (user.hand == "Paper" && Opponent.hand == "Paper")
            {
                int? amount = HttpContext.Session.GetInt32("Ties");
                HttpContext.Session.SetInt32("Ties", (int)++amount);
            } else if (user.hand == "Rock" && Opponent.hand == "Scissors")
            {
                int? amount = HttpContext.Session.GetInt32("PlayerOneWins");
                HttpContext.Session.SetInt32("PlayerOneWins", (int)++amount);
            } else if (user.hand == "Rock" && Opponent.hand == "Rock")
            {
                int? amount = HttpContext.Session.GetInt32("Ties");
                HttpContext.Session.SetInt32("Ties", (int)++amount);
            } else if (user.hand == "Rock" && Opponent.hand == "Paper")
            {
                int? amount = HttpContext.Session.GetInt32("PlayerTwoWins");
                HttpContext.Session.SetInt32("PlayerTwoWins", (int)++amount);
            } else if(user.hand == "Scissors" && Opponent.hand == "Scissors")
            {
                int? amount = HttpContext.Session.GetInt32("Ties");
                HttpContext.Session.SetInt32("Ties", (int)++amount);
            } else if (user.hand == "Scissors" && Opponent.hand == "Rock")
            {
                int? amount = HttpContext.Session.GetInt32("PlayerTwoWins");
                HttpContext.Session.SetInt32("PlayerTwoWins", (int)++amount);
            } else if (user.hand == "Scissors" && Opponent.hand == "Paper")
            {
                int? amount = HttpContext.Session.GetInt32("PlayerOneWins");
                HttpContext.Session.SetInt32("PlayerOneWins", (int)++amount);
            }
            int? total = HttpContext.Session.GetInt32("TotalPlays");
            HttpContext.Session.SetInt32("TotalPlays", (int)++total);
            return RedirectToAction("Game");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
