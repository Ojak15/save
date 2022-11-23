using Microsoft.AspNetCore.Mvc;

namespace Test2.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
