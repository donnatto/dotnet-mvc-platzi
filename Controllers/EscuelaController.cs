using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Platzi_MVC.Models;

namespace Platzi_MVC.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Index()
        {
            ViewBag.DynamicThing = "La Monja";

            var escuela = _context.Escuelas.FirstOrDefault();

            /* Se envia el objeto como parametro */
            return View(escuela);
        }

        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}