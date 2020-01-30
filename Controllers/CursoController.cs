using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Platzi_MVC.Models;

namespace Platzi_MVC.Controllers
{
    public class CursoController : Controller
    {
        [Route("Alumno/Index")]
        [Route("Alumno/Index({cursoId}")]
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var curso =
                    from cur in _context.Cursos
                    where cur.Id == id
                    select cur;
                return View(curso.FirstOrDefault());
            } else
            {
                return View("MultiCurso", _context.Cursos);
            }
        }

        public IActionResult MultiCurso()
        {
            ViewBag.Fecha = DateTime.Now;

            return View("MultiCurso", _context.Cursos);
        }

        public IActionResult Create()
        {
            ViewBag.Fecha = DateTime.Now;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            ViewBag.Fecha = DateTime.Now;

            var escuela = _context.Escuelas.FirstOrDefault();

            curso.EscuelaId = escuela.Id;
            _context.Cursos.Add(curso);
            _context.SaveChanges();

            return View();
        }

        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}