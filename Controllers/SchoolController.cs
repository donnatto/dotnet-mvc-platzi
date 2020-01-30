using System;
using Microsoft.AspNetCore.Mvc;
using Platzi_MVC.Models;

namespace Platzi_MVC.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            var school = new School();
            school.FoundationYear = 2005;
            school.SchoolId = Guid.NewGuid().ToString();
            school.SchoolName = "Platzi School";

            /* Se envia el objeto como parametro */
            return View(school);
        }
    }
}