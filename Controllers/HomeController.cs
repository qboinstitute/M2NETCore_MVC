using M2NETCore_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace M2NETCore_MVC.Controllers
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
            return View();
        }

        public IActionResult Services()
        {
            List<Servicios> servicios = new List<Servicios>();
            Servicios servicios1 = new Servicios(1, "Cocinar");
            Servicios servicios2 = new Servicios(2, "Lavar");
            Servicios servicios3 = new Servicios(3, "Limpiar");
            servicios.Add(servicios1);
            servicios.Add(servicios2);
            servicios.Add(servicios3);
            ViewBag.ListadoServicio = servicios;
            //return RedirectToAction("Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
