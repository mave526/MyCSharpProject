using Microsoft.AspNetCore.Mvc;

namespace MyCSharpProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}