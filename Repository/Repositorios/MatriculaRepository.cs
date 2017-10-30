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
    public class MatriculaRepository : MasterRepository, IMatriculaRepository
    {
        public void AddMatricula(Matricula matricula)
        {
            Context.Matriculas.Add(matricula);
            Context.SaveChanges();
        }

        public void EditarMatricula(Matricula matriculas)
        {
            Context.Entry(matriculas).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarMatricula(int idMatricula)
        {
            var matricula = Context.Matriculas.Find(idMatricula);

            if (matricula != null)
            {
                Context.Matriculas.Remove(matricula);
                Context.SaveChanges();
            }
        }

        public Matricula GetMatriculaById(int? idMatricula)
        {

            return Context.Matriculas.Find(idMatricula);
        }

        public IEnumerable<Matricula> GetMatriculas()
        {
            var query = from c in Context.Matriculas
                        select c;
            return query;
        }
    }
}
