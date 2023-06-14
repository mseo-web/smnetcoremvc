using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using smnetcoremvc.Data;
using smnetcoremvc.Models;

namespace smnetcoremvc.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly DataContext _context;

        public ProjectsController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories;
            var projects = _context.Projects;

            ViewBag.Categories = categories;

            /*return View(categories, projects);*/
            return View(projects);
        }

        public async Task<IActionResult> Project(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }
    }
}
