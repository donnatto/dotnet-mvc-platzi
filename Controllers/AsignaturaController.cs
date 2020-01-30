using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Platzi_MVC.Models;

namespace Platzi_MVC.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            return View(new Asignatura{Nombre="Programacion", UniqueId=Guid.NewGuid().ToString()});
        }

        public IActionResult MultiAsignatura()
        {
            var listAsign = new List<Asignatura>(){
                new Asignatura{UniqueId=Guid.NewGuid().ToString() ,Nombre="Matematicas"},
                new Asignatura{UniqueId=Guid.NewGuid().ToString() ,Nombre="Educacion Fisica"},
                new Asignatura{UniqueId=Guid.NewGuid().ToString() ,Nombre="Castellano"},
                new Asignatura{UniqueId=Guid.NewGuid().ToString() ,Nombre="Ciencias Naturales"}
            };

            ViewBag.Fecha = DateTime.Now;

            return View(listAsign);
        }
    }
}