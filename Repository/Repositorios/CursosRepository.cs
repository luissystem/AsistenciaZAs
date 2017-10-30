using Repository.InterfacesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clases;
using Repository.Configuraciones;
using System.Data.Entity;

namespace Repository.Repositorios
{
    public class CursosRepository : MasterRepository, IcursoRepository
    {
        public void AddCurso(Cursos curso)
        {
            Context.Cursos.Add(curso);
            Context.SaveChanges();
        }

        public void EditarCurso(Cursos curso)
        {

            Context.Entry(curso).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarCurso(int idCurso)
        {
            var curs = Context.Cursos.Find(idCurso);
            if (curs != null)
            {
                Context.Cursos.Remove(curs);
                Context.SaveChanges();
            }
        }

        public Cursos GetCursoById(int? idCurso)
        {
            return Context.Cursos.Find(idCurso);
        }

        public IEnumerable<Cursos> GetCursos()
        {
            var query = from c in Context.Cursos
                        select c;
            return query;
        }
    }
}
