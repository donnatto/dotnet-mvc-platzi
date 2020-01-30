using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Platzi_MVC.Models;

namespace Platzi_MVC.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View(new Alumno{Nombre="Pepe Grillo", UniqueId=Guid.NewGuid().ToString()});
        }

        public IActionResult MultiAlumno()
        {
            var listAlumno = new List<Alumno>(){
                new Alumno{UniqueId=Guid.NewGuid().ToString() ,Nombre="Juan Jose"},
                new Alumno{UniqueId=Guid.NewGuid().ToString() ,Nombre="Pedro Perez"},
                new Alumno{UniqueId=Guid.NewGuid().ToString() ,Nombre="Luis Leon"},
                new Alumno{UniqueId=Guid.NewGuid().ToString() ,Nombre="Jose Juarez"}
            };

            ViewBag.Fecha = DateTime.Now;

            return View(listAlumno);
        }
    }
}