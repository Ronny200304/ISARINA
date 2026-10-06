using Microsoft.AspNetCore.Mvc;

namespace ISARINA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}