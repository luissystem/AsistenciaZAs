using Entidades.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Alumnos")]
   public class Alumno
    {
        [Key]
        public int AlumnoId { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nombres { get; set; }
        [Required]
        [MaxLength(80)]
        public String Apellidos { get; set; }
        [Required]
        [MaxLength(8)]
        
        public string Dni { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

     
        public string Genero { get; set; }
      
        public bool Estado { get; set; }
        public List<Matricula> matriculas { get; set; }
    }
}
