using Microsoft.AspNetCore.Mvc;

namespace smnetcoremvc.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
