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
    public class AsistenciaService : IAsistenciaService
    {
        private IAsistenciaRepository _asistenciaAlumnoRepository;
        public AsistenciaService()
        {
            if (_asistenciaAlumnoRepository == null)
            {
                _asistenciaAlumnoRepository = new AsistenciaRepository();
            }
        }
        public void addAsistencia(Asistencia asistencia)
        {
            _asistenciaAlumnoRepository.addAsistencia(asistencia);
        }

        public void EditarAsistencia(Asistencia asistencia)
        {
            throw new NotImplementedException();
        }

        public void EliminarAsistencia(int IdAsistencia)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Asistencia> getAsistencia()
        {
            return _asistenciaAlumnoRepository.getAsistencia();
        }

        public Asistencia GetAsistenciaId(int? idAsistencia)
        {
            return _asistenciaAlumnoRepository.GetAsistenciaId(idAsistencia);
        }
    }
}
