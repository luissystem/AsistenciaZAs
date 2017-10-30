using Entidades.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InterfacesRepository
{
   public interface ISeccionRepository
    {
      
        IEnumerable<Seccion> GetSeccion();
        Seccion GetSeccionById(Int32? idSeccion);

        void AddSeccion(Seccion Seccion);
        void EditarSeccion(Seccion Seccion);

        void EliminarSeccion(Int32 idSeccion);
    }
}
