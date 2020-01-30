using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Platzi_MVC.Models;

namespace Platzi_MVC.Controllers
{
    public class AsignaturaController : Controller
    {
        [Route("Asignatura/Index/{asignaturaId}")]
        public IActionResult Index(string asignaturaId)
        {
            if (!string.IsNullOrWhiteSpace(asignaturaId))
            {
                var asignatura =
                    from asig in _context.Asignaturas
                    where asig.Id == asignaturaId
                    select asig;
                return View(asignatura.SingleOrDefault());
            } else
            {
                return View("MultiAsignatura", _context.Asignaturas);
            }

        }

        public IActionResult MultiAsignatura()
        {
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAsignatura", _context.Asignaturas);
        }

        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}