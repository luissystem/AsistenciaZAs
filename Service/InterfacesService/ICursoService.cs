using Entidades.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InterfacesService
{
  public  interface ICursoService
    {
        IEnumerable<Cursos> GetCursos();
        Cursos GetCursoById(Int32? idCurso);

        void AddCurso(Cursos curso);
        void EditarCurso(Cursos curso);

        void EliminarCurso(Int32 idCurso);
    }
}
