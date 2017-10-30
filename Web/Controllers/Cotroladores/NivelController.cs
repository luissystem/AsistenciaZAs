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
    public class NivelController : Controller
    {

        private INivelService _nivelService;
        public NivelController()
        {
            if (_nivelService == null)
            {
                _nivelService = new NivelService();
            }
        }
        // GET: Nivel
        public ActionResult Index()
        {
            var ni = _nivelService.GetNiveles();
            return View(ni);
        }

        // GET: Nivel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Nivel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nivel/Create
        [HttpPost]
        public ActionResult Create(Nivel nivel)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _nivelService.AddNivel(nivel);

                    return RedirectToAction("Index");
                }
                return View(nivel);
            }
            catch
            {
                return View();
            }
        }

        // GET: Nivel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Nivel/Edit/5
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

        // GET: Nivel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Nivel/Delete/5
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
