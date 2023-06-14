using Microsoft.AspNetCore.Mvc;

namespace smnetcoremvc.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
