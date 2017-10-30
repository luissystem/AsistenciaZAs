using Service.InterfacesService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Repository.InterfacesRepository;
using Repository.Repositorios;

namespace Service.Serivicios
{
    public class AlumnoService : IAlumnoService
    {
        private IAlumnoRepository _alumnoRepository;
        public AlumnoService()
        {
            if (_alumnoRepository == null)
            {
                _alumnoRepository = new AlumnoRepository();
            }
        }
        public void addAlumno(Alumno alumno)
        {
            _alumnoRepository.addAlumno(alumno);
        }

        public void EditarAlumno(Alumno alumno)
        {
            _alumnoRepository.EditarAlumno(alumno);
        }

        public void EliminarAlumno(int Idalumno)
        {
            _alumnoRepository.EliminarAlumno(Idalumno);
        }

        public IEnumerable<Alumno> GetaAlumnos()
        {
            return _alumnoRepository.GetaAlumnos();
        }

        public Alumno GetAlumnoId(int? idAlumno)
        {
            return _alumnoRepository.GetAlumnoId(idAlumno);
        }
    }
}
