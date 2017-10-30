using Entidades.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InterfacesRepository
{
  public  interface IAsistenciaRepository
    {
        IEnumerable<Asistencia> getAsistencia();
        void addAsistencia(Asistencia asistencia);
        void EditarAsistencia(Asistencia asistencia);
        void EliminarAsistencia(int IdAsistencia);

        Asistencia GetAsistenciaId(int? idAsistencia);
    }
}
