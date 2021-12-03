using Microsoft.AspNetCore.Mvc;

namespace portfolioI.Controllers
{
    public class MainController : Controller
    {
        //This is where my routes and controls go
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "This is my Index";
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return "This are my Projects";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact";
        }
    }
}