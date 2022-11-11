using Back_end_BD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_end_BD.Controllers
{
    public class MaestrosController : Controller
    {
        // GET: Maestros
        public ActionResult Index()
        {
            using (AlumnoDBContex dbMaestro = new AlumnoDBContex())
            {
                return View(dbMaestro.Maestros.ToList());
            }
        }
        public ActionResult Details(int? id)
        {
            using (AlumnoDBContex dbMaestro = new AlumnoDBContex())
            {
               Maestros maestro = dbMaestro.Maestros.Find(id);
                if (maestro == null)
                {
                    return HttpNotFound();
                }
                return View(maestro);
            }

        }
        public ActionResult Create()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Create(Maestros mae)
        {
            using (AlumnoDBContex dbMaestros = new AlumnoDBContex())
            {
                dbMaestros.Maestros.Add(mae);
                dbMaestros.SaveChanges();
            }
            return RedirectToAction("Index");

        }
        public ActionResult Edit(int? id)
        {
            using (AlumnoDBContex dbMaestro = new AlumnoDBContex())
            {

                return View(dbMaestro.Maestros.Where(x => x.Matricula == id).FirstOrDefault());
            }


        }
        [HttpPost]

        public ActionResult Edit(Maestros mae)
        {
            using (AlumnoDBContex dbMaestro = new AlumnoDBContex())
            {
                dbMaestro.Entry(mae).State = System.Data.Entity.EntityState.Modified;
                dbMaestro.SaveChanges();
            }
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int? id)
        {
            using (AlumnoDBContex dbMaestro = new AlumnoDBContex())
            {

                return View(dbMaestro.Maestros.Where(x => x.Matricula == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Delete(Maestros mae, int? id)
        {
            using (AlumnoDBContex dbMaestro = new AlumnoDBContex())
            {
                Maestros al = dbMaestro.Maestros.Where(x => x.Matricula == id).FirstOrDefault();
                dbMaestro.Maestros.Remove(al);
                dbMaestro.SaveChanges();
            }
            return RedirectToAction("Index");

        }
    }
}