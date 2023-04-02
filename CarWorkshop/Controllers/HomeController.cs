using CarWorkshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarWorkshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var model = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Jakub",
                    LastName = "Kozera"
                },
                new Person()
                {
                    FirstName = "Adam",
                    LastName = "Małysz"
                },
            };

            return View(model);
        }

        public IActionResult About()
        {
            var model = new About()
            {
                Title = "Title 1",
                Description = "Description 1",
                Tags = new string[] { "Tag1", "Tag 2" }
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}