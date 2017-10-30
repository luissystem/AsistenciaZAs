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
    public class GradoController : Controller
    {
        // GET: Grado
        private INivelService _nivelService;
        private IGradoService _gradoService;
        public GradoController()
        {
            if (_nivelService == null)
            {
                _nivelService = new NivelService();

            }
            if (_gradoService == null)
            {
                _gradoService = new GradoService();
            }

        }
        public ActionResult Index()
        {
            var gra = _gradoService.GetGrados();
            return View(gra);
        }

        // GET: Grado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Grado/Create
        public ActionResult Create()
        {
            var ni = _nivelService.GetNiveles();
            ViewBag.nivel = new SelectList(ni, "NivelId", "Nombre");
            return View();
        }

        // POST: Grado/Create
        [HttpPost]
        public ActionResult Create(Grado grado)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _gradoService.AddGrado(grado);

                    return RedirectToAction("Index");
                }
                return View(grado);
            }
            catch
            {
                return View();
            }
        }

        // GET: Grado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Grado/Edit/5
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

        // GET: Grado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Grado/Delete/5
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
