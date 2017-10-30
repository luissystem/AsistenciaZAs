using Entidades.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InterfacesService
{
   public  interface IGradoService
    {
        IEnumerable<Grado> GetGrados();
        Grado GetGradoById(Int32? idGrado);

        void AddGrado(Grado Grado);
        void EditarGrado(Grado Grado);

        void EliminarGrado(Int32 idGrado);
    }
}
