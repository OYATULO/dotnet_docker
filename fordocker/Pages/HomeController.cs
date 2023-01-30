using Microsoft.AspNetCore.Mvc;

namespace fordocker.Pages
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
