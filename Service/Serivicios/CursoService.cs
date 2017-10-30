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
    public class CursoService : ICursoService
    {
        private IcursoRepository _cursoRepository;
        public CursoService()
        {
            if (_cursoRepository == null)
            {
                _cursoRepository = new CursosRepository();
            }
        }
        public void AddCurso(Cursos curso)
        {

            _cursoRepository.AddCurso(curso);
        }

        public void EditarCurso(Cursos curso)
        {

            _cursoRepository.EditarCurso(curso);
        }

        public void EliminarCurso(int idCurso)
        {
            _cursoRepository.EliminarCurso(idCurso);
        }

        public Cursos GetCursoById(int? idCurso)
        {
            return _cursoRepository.GetCursoById(idCurso);
        }

        public IEnumerable<Cursos> GetCursos()
        {
            return _cursoRepository.GetCursos();
        }
    }
}
