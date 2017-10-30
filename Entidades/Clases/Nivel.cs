using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    [Table("Nivel")]
    public class Nivel
    {
        [Key]
        public int NivelId { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nombre { get; set; }
        public List<Grado> grados { get; set; }
    }
}
