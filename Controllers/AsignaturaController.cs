using System;
using Microsoft.AspNetCore.Mvc;
using Platzi_MVC.Models;

namespace Platzi_MVC.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asign = new Asignatura{
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "ASP"
            };

            ViewBag.Fecha = DateTime.Now;

            return View(asign);
        }
    }
}