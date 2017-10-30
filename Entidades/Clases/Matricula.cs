using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    [Table("Matricula")]
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaMatricula { get; set; }
        public int SeccionId { get; set; }
        public Seccion Seccion { get; set; }
        public int AnioAcademicoId { get; set; }
        public AnioAcademico anioacademicos { get; set; }
    }
}
