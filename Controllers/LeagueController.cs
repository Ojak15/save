using Microsoft.AspNetCore.Mvc;

namespace Test2.Controllers
{
    public class LeagueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
