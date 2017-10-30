using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InterfacesRepository
{
    public interface IAlumnoRepository
    {
        IEnumerable<Alumno> GetaAlumnos();
        void addAlumno(Alumno alumno);
        void EditarAlumno(Alumno alumno);
        void EliminarAlumno(int Idalumno);

        Alumno GetAlumnoId(int? idAlumno);

    }
}
