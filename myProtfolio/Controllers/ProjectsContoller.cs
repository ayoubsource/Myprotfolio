using Microsoft.AspNetCore.Mvc;
using myProtfolio.Models;

namespace myProtfolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var project = GetProjectById(id);
            return  View("~/Views/Projects/Details.cshtml",project);
        }

        // Helper method to retrieve the skill details from your data source
        private Project GetProjectById(int id)
        {
            // Implement your logic to fetch the skill details by ID
            // This can be from a database, API, or any other data source

            // Example: returning a mock skill object for demonstration
            var project = new Project
            {
                Id = id,
                Name = "HTML",
                Description = "HyperText Markup Language"
            };

            return project;
        }
    }
}
