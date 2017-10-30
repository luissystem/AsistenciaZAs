using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
  public  class Asistencia
    {   [Key]
        public int AsistenciaId { get; set; }
        public bool Estado { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaAsistencia { get; set; }

        public int CursosId  { get; set; }
        public Cursos cuso { get; set; }

    }
}
