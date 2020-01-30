using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Platzi_MVC.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Ciudad = "Bogota";
            escuela.Pais = "Colombia";
            escuela.Direccion = "Springfield";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            modelBuilder.Entity<Escuela>().HasData(escuela);

            modelBuilder.Entity<Asignatura>().HasData(
                new Asignatura{ Nombre = "Math"},
                new Asignatura{ Nombre = "Code"},
                new Asignatura{ Nombre = "Physics"},
                new Asignatura{ Nombre = "Logic"}
            );

            modelBuilder.Entity<Alumno>().HasData(GenerarAlumnos().ToArray());
        }

        private List<Alumno> GenerarAlumnos()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick" };

            var listAlumnos =
                from n1 in nombre1
                from n2 in nombre2
                from a1 in apellido1
                select new Alumno {
                    Nombre = $"{n1} {n2} {a1}",
                    UniqueId = Guid.NewGuid().ToString()
                };

            return listAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
    }
}