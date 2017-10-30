using Repository.InterfacesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Repository.Configuraciones;
using System.Data.Entity;

namespace Repository.Repositorios
{
    public class AlumnoRepository :MasterRepository, IAlumnoRepository
    {
        public void addAlumno(Alumno alumno)
        {
            Context.Alumnos.Add(alumno);
            Context.SaveChanges();
        }

        public void EditarAlumno(Alumno alumno)
        {
            Context.Entry(alumno).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarAlumno(int Idalumno)
        {
            var alumno = Context.Alumnos.Find(Idalumno);
            if (alumno!=null) { Context.Alumnos.Remove(alumno);
                Context.SaveChanges();
            }
        }

        public IEnumerable<Alumno> GetaAlumnos()
        {
            var query = from c in Context.Alumnos
                        select c;
            return query;
        }

        public Alumno GetAlumnoId(int? idAlumno)
        {
            return Context.Alumnos.Find(idAlumno);
        }
    }
}
