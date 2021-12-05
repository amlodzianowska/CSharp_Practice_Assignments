using Microsoft.AspNetCore.Mvc;

namespace razorFun.Controllers
{
    public class MainController : Controller
    {

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}