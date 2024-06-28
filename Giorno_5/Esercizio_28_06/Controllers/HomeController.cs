using Esercizio_28_06.Entities;
using Esercizio_28_06.Models;
using Esercizio_28_06.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Esercizio_28_06.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IWebHostEnvironment _env;

        public HomeController(ILogger<HomeController> logger, IProductService productService, IWebHostEnvironment env)
        {
            _logger = logger;
            _productService = productService;
            _env = env;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll().OrderByDescending(p => p.Published);
            string uploads = Path.Combine(_env.WebRootPath, "images");
            foreach (Product p in products)
            {
                var cover = Path.ChangeExtension(Path.Combine(uploads, p.Id.ToString()), "jpg");
                if (System.IO.File.Exists(cover))
                    ViewBag.Cover = $"/images/{p.Id}.jpg";
            }
            return View(products);
        }

        public IActionResult Crea()
        {
            return View(new Product());
        }
        [HttpPost]
        public IActionResult Crea(Product product)
        {
            _productService.Create(product);

            string uploads = Path.Combine(_env.WebRootPath, "images");
            if (product.Cover.Length > 0)
            {
                string filePath = Path.ChangeExtension(Path.Combine(uploads, product.Id.ToString()), "jpg");
                using Stream fileStream = new FileStream(filePath, FileMode.Create);
                product.Cover.CopyTo(fileStream);
            }


            string uploads1 = Path.Combine(_env.WebRootPath, "images1");
            if (product.FirstImg.Length > 0)
            {
                string filePath = Path.ChangeExtension(Path.Combine(uploads1, product.Id.ToString()), "jpg");
                using Stream fileStream = new FileStream(filePath, FileMode.Create);
                product.FirstImg.CopyTo(fileStream);
            }


            string uploads2 = Path.Combine(_env.WebRootPath, "images2");
            if (product.SecondImg.Length > 0)
            {
                string filePath = Path.ChangeExtension(Path.Combine(uploads2, product.Id.ToString()), "jpg");
                using Stream fileStream = new FileStream(filePath, FileMode.Create);
                product.SecondImg.CopyTo(fileStream);
            }


            return RedirectToAction(nameof(Index));
        }

        public IActionResult Dettagli(int id)
        {
            var product = _productService.GetbyId(id);

            string uploads = Path.Combine(_env.WebRootPath, "images");
            var cover = Path.ChangeExtension(Path.Combine(uploads, product.Id.ToString()), "jpg");
            if (System.IO.File.Exists(cover))
                ViewBag.Cover = $"/images/{product.Id}.jpg";

            string uploads1 = Path.Combine(_env.WebRootPath, "images1");
            var firstImg = Path.ChangeExtension(Path.Combine(uploads1, product.Id.ToString()), "jpg");
            if (System.IO.File.Exists(cover))
                ViewBag.FirstImg = $"/images1/{product.Id}.jpg";

            string uploads2 = Path.Combine(_env.WebRootPath, "images2");
            var secondImg = Path.ChangeExtension(Path.Combine(uploads2, product.Id.ToString()), "jpg");
            if (System.IO.File.Exists(cover))
                ViewBag.SecondImg = $"/images2/{product.Id}.jpg";

            return View(product);
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
