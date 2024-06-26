using Esercitazione_26_06.Models;
using Esercitazione_26_06.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Esercitazione_26_06.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static List<Prenotazione> list = new List<Prenotazione>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cinema()
        {
            var viewModel = new PrenotazioneViewModel
            {
                ListaPrenotazioni = list
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Crea(PrenotazioneViewModel viewModel)
        {
            viewModel.NuovaPrenotazione.Hall.PostiOccupati++;
            list.Add(viewModel.NuovaPrenotazione);
            
            return RedirectToAction("Cinema");
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
