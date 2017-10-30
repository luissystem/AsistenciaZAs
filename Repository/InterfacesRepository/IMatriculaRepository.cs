using Entidades.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InterfacesRepository
{
    public interface IMatriculaRepository
    {
        IEnumerable<Matricula> GetMatriculas();
        Matricula GetMatriculaById(Int32? idMatricula);

        void AddMatricula(Matricula matricula);
        void EditarMatricula(Matricula matricula);

        void EliminarMatricula(Int32 idMatricula);
    }
}
