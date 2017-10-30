using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    [Table("AnioAcademico")]
    public class AnioAcademico
    {
        [Key]
        public int AnioAcademicoId { get; set; }
        public bool Activo { get; set; }
        [Required]

        public string Anio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaApertura { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaClausura { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FechaInicioMatricula { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FechaFinMatricula { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FechaMatriculaExtemporanea { get; set; }
    }
}
