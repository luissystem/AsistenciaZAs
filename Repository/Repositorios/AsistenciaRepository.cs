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
    public class AsistenciaRepository : MasterRepository, IAsistenciaRepository
    {
        public void addAsistencia(Asistencia asistencia)
        {

            Context.Asistencias.Add(asistencia);
            Context.SaveChanges();
        }

        public void EditarAsistencia(Asistencia asistencia)
        {
            Context.Entry(asistencia).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarAsistencia(int IdAsistencia)
        {
            var Asistencia = Context.Asistencias.Find(IdAsistencia);
            if (Asistencia != null)
            {
                Context.Asistencias.Remove(Asistencia);
                Context.SaveChanges();
            }
        }

        public IEnumerable<Asistencia> getAsistencia()
        {
            var query = from c in Context.Asistencias
                        select c;
            return query;
        }

        public Asistencia GetAsistenciaId(int? idAsistencia)
        {
            return Context.Asistencias.Find(idAsistencia);
        }
    }
}
