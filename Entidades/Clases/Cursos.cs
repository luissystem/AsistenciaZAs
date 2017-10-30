using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    [Table("Curso")]
    public  class Cursos
    {
        [Key]
        public int CursoId { get; set; }
        [Required]
        [MaxLength(70)]
        public string Nombre { get; set; }

        public List<Asistencia> asistencia { get; set; }



    }
}
