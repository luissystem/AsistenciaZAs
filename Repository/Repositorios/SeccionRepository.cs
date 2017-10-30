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
    public class SeccionRepository : MasterRepository, ISeccionRepository
    {
        public void AddSeccion(Seccion Seccion)
        {
            Context.Secciones.Add(Seccion);
            Context.SaveChanges();
        }

        public void EditarSeccion(Seccion Seccion)
        {
            Context.Entry(Seccion).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarSeccion(int idSeccion)
        {
            var sec = Context.Secciones.Find(idSeccion);
            if (sec != null)
            {
                Context.Secciones.Remove(sec);
                Context.SaveChanges();
            }
        }

        public IEnumerable<Seccion> GetSeccion()
        {
            var query = from s in Context.Secciones.Include("Grado")
                        select s;

            return query;
        }

        public Seccion GetSeccionById(int? idSeccion)
        {

            return Context.Secciones.Find(idSeccion);
        }
    }
}
