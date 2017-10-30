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
    public class NivelRepository : MasterRepository, INivelRepository
    {
        public void AddNivel(Nivel nivel)
        {
            Context.Niveles.Add(nivel);
            Context.SaveChanges();
        }

        public void EditarNivel(Nivel nivel)
        {
            Context.Entry(nivel).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarNivel(int idNivel)
        {
            var ni = Context.Niveles.Find(idNivel);
            if (ni != null)
            {
                Context.Niveles.Remove(ni);
                Context.SaveChanges();
            }
        }

        public Nivel GetNivelById(int? idNivel)
        {
            return Context.Niveles.Find(idNivel);
        }

        public IEnumerable<Nivel> GetNiveles()
        {
            var query = from c in Context.Niveles
                        select c;
            return query;
        }
    }
}
