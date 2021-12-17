using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


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

            ViewBag.ExceptFootball = _context.Leagues
                .Where(l => l.Sport!="Football")
                .ToList();
            // 2 ALTERNATIVE WAYS:
            // 1.
            // ViewBag.ExceptFootball = _context.Leagues
            //     .Where(l => !l.Sport.Contains("Football"))
            //     .ToList();
            // 2.
            // IEnumerable<League> AllLeagues = _context.Leagues;
            // IEnumerable<League> FootballLeagues = _context.Leagues
            //     .Where(l => l.Sport.Contains("Football"))
            //     .ToList();
            // ViewBag.ExceptFootball = AllLeagues.Except(FootballLeagues).OrderBy(l => l.Sport);
            
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
            IEnumerable<Team> ASCTeams = _context.Teams.Include(t => t.CurrLeague).Where(l => l.CurrLeague.Name == "Atlantic Soccer Conference").ToList();
            ViewBag.ASCTeams = ASCTeams;

            IEnumerable<Player> BostonPenguinsPlayers = _context.Players.Include(p => p.CurrentTeam).Where(t => t.CurrentTeam.TeamName == "Penguins");
            ViewBag.BPPlayers = BostonPenguinsPlayers;

            IEnumerable<Player> CollegiateBaseballConference = _context.Players.Include(p => p.CurrentTeam).ThenInclude(l => l.CurrLeague).Where(t => t.CurrentTeam.CurrLeague.Name == "International Collegiate Baseball Conference").OrderBy(n => n.LastName);
            ViewBag.ICBCPlayers = CollegiateBaseballConference;

            IEnumerable<Player> Lopez = _context.Players.Include(p => p.CurrentTeam).ThenInclude(l => l.CurrLeague).Where(t => t.LastName == "Lopez").Where(t => t.CurrentTeam.CurrLeague.Name == "American Conference of Amateur Football");
            ViewBag.Lopez = Lopez;

            IEnumerable<Player> FootballPlayers = _context.Players.Include(p => p.CurrentTeam).ThenInclude(l => l.CurrLeague).Where(t => t.CurrentTeam.CurrLeague.Sport == "Football").OrderBy(n => n.LastName);
            ViewBag.FBPlayers = FootballPlayers;

            IEnumerable<Team> TeamsWithSophia = _context.Teams.Include(t => t.AllPlayers).Where(p => p.CurrentPlayers.Any(p => p.FirstName == "Sophia")).ToList();
            ViewBag.TWSophia = TeamsWithSophia;

            IEnumerable<League> LeaguesWithSophia = _context.Leagues.Include(t => t.Teams).ThenInclude(l => l.CurrentPlayers).Where(p => p.Teams.Any(t => t.CurrentPlayers.Any(p => p.FirstName == "Sophia"))).ToList();
            ViewBag.LWSophia = LeaguesWithSophia;

            IEnumerable<Player> Flores = _context.Players.Include(p => p.CurrentTeam).Where(t => t.LastName == "Flores").Where(t => t.CurrentTeam.TeamName != "Roughriders");
            ViewBag.Flores = Flores;

            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}