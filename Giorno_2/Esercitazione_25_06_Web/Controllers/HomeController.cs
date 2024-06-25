using Esercitazione_25_06;
using Esercitazione_25_06_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Esercitazione_25_06_Web.Controllers
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
            CV cv = new CV
            {
                Info = new InformazioniPersonali
                {
                    Nome = "Ilario",
                    Cognome = "Alicante",
                    Email = "ilarioalicante@gmail.com",
                    Telefono = "+39328123456"
                },
                Studi = new StudiEffettivi
                {
                    Qualifica = "DJ",
                    Istituto = "Mat Academy",
                    Tipo = "Diploma",
                    Dal = "10/09/2005",
                    Al = "15/03/2007"
                },
                Impieghi = new Impieghi
                {
                    Esperienza = new Esperienza
                    {
                        Azienda = "Drumcode",
                        JobTitle = "Dj & Producer",
                        Dal = "20/09/2006",
                        Al = "- Attuale",
                        Descrizione = "Dj & Producer a titolo professionale",
                        Compiti = "Dj & Producer a titolo professionale, Analyst Drumcode Records & Radio"
                    }
                }
            };
            return View(cv);
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
