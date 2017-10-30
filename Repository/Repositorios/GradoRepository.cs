using Repository.Configuraciones;
using Repository.InterfacesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clases;
using System.Data.Entity;

namespace Repository.Repositorios
{
    public class GradoRepository : MasterRepository, IGradoRepository
    {
        public void AddGrado(Grado Grado)
        {
            Context.Grados.Add(Grado);
            Context.SaveChanges();
        }

        public void EditarGrado(Grado Grado)
        {
            Context.Entry(Grado).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarGrado(int idGrado)
        {
            var gr = Context.Grados.Find(idGrado);
            if (gr != null)
            {
                Context.Grados.Remove(gr);
                Context.SaveChanges();
            }
        }

        public Grado GetGradoById(int? idGrado)
        {
            return Context.Grados.Find(idGrado);
        }

        public IEnumerable<Grado> GetGrados()
        {
            var query = from g in Context.Grados.Include("Nivel")
                        select g;

            return query;
        }
    }
}
