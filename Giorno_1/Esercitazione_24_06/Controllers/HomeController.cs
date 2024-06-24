using Esercitazione_24_06.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Esercitazione_24_06.Controllers
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
            var list = new List<Food>
            {
                new Food {Name = "Coca Cola 150 ML", price = 2.50m },
                new Food {Name = "Insalata di Pollo", price = 5.20m },
                new Food {Name = "Pizza Margherita", price = 10m },
                new Food {Name = "Pizza 4 Formaggi", price = 12.50m },
                new Food {Name = "Pz patatine fritte", price = 3.50m },
                new Food {Name = "Insalata di riso", price = 8m },
                new Food {Name = "Frutta di stagione", price = 5m },
                new Food {Name = "Pizza Fritta", price = 5m },
                new Food {Name = "Piadina Vegetariana", price = 6m },
                new Food {Name = "Panino Hamburger", price = 7.90m }
            };

            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
