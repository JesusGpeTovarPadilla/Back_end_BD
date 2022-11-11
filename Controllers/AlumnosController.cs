using Back_end_BD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_end_BD.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {using(AlumnoDBContex dbAlumno=new AlumnoDBContex())
            {
                return View(dbAlumno.Alumnos.ToList());
            }

            
        }
        public ActionResult Details(int? id)
        {
            using (AlumnoDBContex dbAlumno = new AlumnoDBContex())
            {
                Alumnos alumnos = dbAlumno.Alumnos.Find(id);
                if(alumnos== null)
                {
                    return HttpNotFound();
                }
                return View(alumnos);
            }


        }

        public ActionResult Create()
        {
          
                return View();
            


        }
        


        [HttpPost]
        public ActionResult Create(Alumnos alum)
        {
            using (AlumnoDBContex dbAlumno = new AlumnoDBContex())
            {
                dbAlumno.Alumnos.Add(alum);
                dbAlumno.SaveChanges();
            }
            return RedirectToAction("Index");

        }
        public ActionResult Edit(int? id)
        {
            using (AlumnoDBContex dbAlumno = new AlumnoDBContex())
            {

                return View(dbAlumno.Alumnos.Where(x => x.Id == id).FirstOrDefault());
            }


        }
        [HttpPost]
        public ActionResult Edit(Alumnos alum)
        {
            using (AlumnoDBContex dbAlumno = new AlumnoDBContex())
            {
                dbAlumno.Entry(alum).State=System.Data.Entity.EntityState.Modified;
                dbAlumno.SaveChanges();
            }
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int? id)
        {
            using (AlumnoDBContex dbAlumno = new AlumnoDBContex())
            {

                return View(dbAlumno.Alumnos.Where(x => x.Id == id).FirstOrDefault());
            }


        }
        [HttpPost]
        public ActionResult Delete(Alumnos alum, int? id)
        {
            using (AlumnoDBContex dbAlumno = new AlumnoDBContex())
            {
                Alumnos al=dbAlumno.Alumnos.Where(x=>x.Id == id).FirstOrDefault();
                dbAlumno.Alumnos.Remove(al);
                dbAlumno.SaveChanges();
            }
            return RedirectToAction("Index");

        }





    }

}