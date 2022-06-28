using Microsoft.AspNetCore.Mvc;

namespace Zaigham.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
