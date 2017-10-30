using Service.InterfacesService;
using Service.Serivicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers.Cotroladores
{
    public class AsistenciaController : Controller
    {
        private IAsistenciaService _service;
        private IMatriculaService _matricula;
        private ISeccionService _seccion;
        private IGradoService _grado;
        private INivelService _nivel;
        private ICursoService _curso;
       // private IAnioAcademicoService _anioEscolar;
        private IAlumnoService _alumno;
        // GET: Asistencia

        public AsistenciaController()
        {
            if (_service == null)
            {
                _service = new AsistenciaService();
            }
            if (_matricula == null)
            {
                _matricula = new MatriculaService();
            }
            if (_seccion == null)
            {
                _seccion = new SeccionService();
            }
            if (_grado == null)
            {
                _grado = new GradoService();

            }
            if (_nivel == null)
            {
                _nivel = new NivelService();
            }
            if (_curso == null)
            {
                _curso = new CursoService();
            }
            //if (_anioEscolar == null)
            //{
            //    _anioEscolar = new AnioAcademicoService();
            //}
            if (_alumno == null)
            {
                _alumno = new AlumnoService();
            }
        }

        public ActionResult Index()
        {
            var a = _service.getAsistencia();
            return View(a);
        }

        // GET: Asistencia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Asistencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Asistencia/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Asistencia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Asistencia/Edit/5
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

        // GET: Asistencia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Asistencia/Delete/5
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
