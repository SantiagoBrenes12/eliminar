using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoWEB.Data;
using ProyectoWEB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWEB.Controllers
{
    public class HomeController : Controller
    {
       //private readonly ILogger<HomeController> _logger;
       private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context) //constructor de la clase
        {
            _context = context; // le asignamos lo quie viene por parametro
        }
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult Formularioss(FormularioModel formulario)
        {
            if (ModelState.IsValid)
            {
                _context.Formularios.Add(formulario);
                _context.SaveChanges();

                TempData["mensaje"] = "El formulario se guardo correctamente!";
                return RedirectToAction("Formulario");
            }
            return View();
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
