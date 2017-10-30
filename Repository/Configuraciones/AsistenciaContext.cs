using Entidades;
using Entidades.Clases;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class AsistenciaContext:DbContext
    {

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Nivel> Niveles { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Seccion> Secciones { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<AnioAcademico> AnioAcademicos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
