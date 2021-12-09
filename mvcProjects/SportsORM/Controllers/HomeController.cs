using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            ViewBag.WomensLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Womens"))
                .ToList();
            ViewBag.HockeyLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Hockey"))
                .ToList();
            ViewBag.ConferenceLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Conference"))
                .ToList();
            ViewBag.AtlanticLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Atlantic"))
                .ToList();
            IEnumerable<League> AllLeagues = _context.Leagues;
            IEnumerable<League> FootballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Football"))
                .ToList();
            ViewBag.ExceptFootball = AllLeagues.Except(FootballLeagues).OrderBy(l => l.Sport);
            
            ViewBag.DallasTeams = _context.Teams
                .Where(t => t.Location.Contains("Dallas"))
                .ToList();
            ViewBag.RaptorsTeams = _context.Teams
                .Where(t => t.TeamName.Contains("Raptors"))
                .ToList();
            ViewBag.CityTeams = _context.Teams
                .Where(t => t.Location.Contains("City"))
                .ToList();
            ViewBag.TTeams = _context.Teams
                .Where(t => t.TeamName.StartsWith("T"))
                .ToList();
            ViewBag.AllTeamsByLocation = _context.Teams
                .OrderBy(t => t.Location)
                .ToList();
            ViewBag.AllTeamsByNameDesc = _context.Teams
                .OrderByDescending(t => t.TeamName)
                .ToList();

            IEnumerable<Player> CooperPlayers = _context.Players
                .Where(p => p.LastName.Contains("Cooper"))
                .ToList();
            IEnumerable<Player> JoshuaPlayers = _context.Players
                .Where(p => p.FirstName.Contains("Joshua"))
                .ToList();
            ViewBag.Joshuas = JoshuaPlayers;
            ViewBag.Coopers = CooperPlayers;
            ViewBag.CoopersExceptJoshuas = CooperPlayers.Except(JoshuaPlayers);
            IEnumerable<Player> Alexes = _context.Players
                .Where(p => p.FirstName.Contains("Alexander"))
                .ToList();
            IEnumerable<Player> Wyatts = _context.Players
                .Where(p => p.FirstName.Contains("Wyatt"))
                .ToList();
            ViewBag.AlexOrWyatt = Alexes.Concat(Wyatts);
            

            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}