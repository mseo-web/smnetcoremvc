using Microsoft.AspNetCore.Mvc;

namespace smnetcoremvc.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
