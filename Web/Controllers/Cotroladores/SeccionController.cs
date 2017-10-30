using Entidades.Clases;
using Service.InterfacesService;
using Service.Serivicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers.Cotroladores
{
    public class SeccionController : Controller
    {
        // GET: Seccion
        private INivelService _nivelService;
        private IGradoService _gradoService;
        private ISeccionService _seccionService;
        public SeccionController()
        {
            if (_nivelService == null)
            {
                _nivelService = new NivelService();

            }
            if (_gradoService == null)
            {
                _gradoService = new GradoService();
            }
            if (_seccionService == null)
            {
                _seccionService = new SeccionService();
            }
        }
        public ActionResult Index()
        {
            var sec = _seccionService.GetSeccion();
            return View(sec);
        }

        // GET: Seccion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seccion/Create
        public ActionResult Create()
        {
            var sec = _seccionService.GetSeccion();
            return View();
        }

        // POST: Seccion/Create
        [HttpPost]
        public ActionResult Create(Seccion seccion)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _seccionService.AddSeccion(seccion);

                    return RedirectToAction("Index");
                }
                return View(seccion);
            }
            catch
            {
                return View();
            }
        }

        // GET: Seccion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seccion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Seccion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seccion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
