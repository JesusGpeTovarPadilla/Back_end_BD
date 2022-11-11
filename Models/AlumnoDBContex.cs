using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Back_end_BD.Models
{
    public class AlumnoDBContex:DbContext
    {
        private static string connection1 = "DefaultConnection";

        public AlumnoDBContex() : base(connection1)
        {

        }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Maestros> Maestros { get; set; }
    }
}