using Entidades;
using Service.InterfacesService;
using Service.Serivicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers.Cotroladores
{
    public class AlumnoController : Controller
    {
        private IAlumnoService _alumnoService;
        public AlumnoController()
        {
            if (_alumnoService==null) {
                _alumnoService = new AlumnoService();
            }
        } 
        // GET: Alumno
        public ActionResult Index()
        {
            var alumno = _alumnoService.GetaAlumnos();
            return View(alumno);
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _alumnoService.addAlumno(alumno);

                    return RedirectToAction("Index");
                }
                return View("Create", alumno);
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var al = _alumnoService.GetAlumnoId(id);

            if (al == null)
            {
                return HttpNotFound();
            }
            return View(al);
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(Alumno alumno)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    _alumnoService.EditarAlumno(alumno);

                    return RedirectToAction("Index");
                }
                return View(alumno);
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var al = _alumnoService.GetAlumnoId(id);

            if (al == null)
            {
                return HttpNotFound();
            }
            return View(al);
        }

        // POST: Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    _alumnoService.EliminarAlumno(id);


                    return RedirectToAction("Index");
                }
                return View(id);
            }
            catch
            {
                return View();
            }
        }
    }
}
