using Microsoft.AspNetCore.Mvc;

namespace TheFinalFarmer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
