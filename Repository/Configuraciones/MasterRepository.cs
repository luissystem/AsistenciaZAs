using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuraciones
{
   public abstract class MasterRepository
        
    {
        private readonly AsistenciaContext _context;

        protected MasterRepository()
        {
            if (_context==null) {
                _context = new AsistenciaContext();
            }
        }
        protected AsistenciaContext Context
        {
            get { return _context; }
        }
    }
}
