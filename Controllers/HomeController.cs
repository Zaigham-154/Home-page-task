using Microsoft.AspNetCore.Mvc;

namespace Zaigham.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult quiz()
        {
            return View();
        }
        public IActionResult data(string name, string lname, string emaill, string gender, string num, string department)
        {
            ViewBag.Message = name + " " + lname + " has email: " + emaill + " and phone number: " + num + " and is a " + gender + " from " + department;
            return View();
        }
    }
}
