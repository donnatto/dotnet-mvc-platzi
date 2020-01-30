using System;
using Microsoft.AspNetCore.Mvc;
using Platzi_MVC.Models;

namespace Platzi_MVC.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var school = new Escuela();
            school.AñoDeCreación = 2005;
            school.UniqueId = Guid.NewGuid().ToString();
            school.Nombre = "Platzi School";
            school.Ciudad = "Bogota";
            school.Pais = "Colombia";
            school.Direccion = "Calle Wallaby";
            school.TipoEscuela = TiposEscuela.Secundaria;


            ViewBag.DynamicThing = "La Monja";

            /* Se envia el objeto como parametro */
            return View(school);
        }
    }
}