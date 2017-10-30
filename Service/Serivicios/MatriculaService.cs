using Service.InterfacesService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clases;
using Repository.InterfacesRepository;
using Repository.Repositorios;

namespace Service.Serivicios
{
    public class MatriculaService : IMatriculaService
    {
        private IMatriculaRepository _matriculaRepository;


        public MatriculaService()
        {
            if (_matriculaRepository == null)
            {
                _matriculaRepository = new MatriculaRepository();
            }
        }
        public void AddMatricula(Matricula matricula)
        {
            _matriculaRepository.AddMatricula(matricula);
        }

        public void EditarMatricula(Matricula matricula)
        {
            _matriculaRepository.EditarMatricula(matricula);
        }

        public void EliminarMatricula(int idMatricula)
        {
            _matriculaRepository.EliminarMatricula(idMatricula);
        }

        public Matricula GetMatriculaById(int? idMatricula)
        {
            return _matriculaRepository.GetMatriculaById(idMatricula);
        }

        public IEnumerable<Matricula> GetMatriculas()
        {
            return _matriculaRepository.GetMatriculas();
        }
    }
}
