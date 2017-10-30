namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class i : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnos",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        Apellidos = c.String(nullable: false, maxLength: 80),
                        Dni = c.String(nullable: false, maxLength: 8),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Genero = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AlumnoId);
            
            CreateTable(
                "dbo.Matricula",
                c => new
                    {
                        MatriculaId = c.Int(nullable: false, identity: true),
                        AlumnoId = c.Int(nullable: false),
                        FechaMatricula = c.DateTime(nullable: false),
                        SeccionId = c.Int(nullable: false),
                        AnioAcademicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MatriculaId)
                .ForeignKey("dbo.Alumnos", t => t.AlumnoId)
                .ForeignKey("dbo.AnioAcademico", t => t.AnioAcademicoId)
                .ForeignKey("dbo.Seccion", t => t.SeccionId)
                .Index(t => t.AlumnoId)
                .Index(t => t.SeccionId)
                .Index(t => t.AnioAcademicoId);
            
            CreateTable(
                "dbo.AnioAcademico",
                c => new
                    {
                        AnioAcademicoId = c.Int(nullable: false, identity: true),
                        Activo = c.Boolean(nullable: false),
                        Anio = c.String(nullable: false),
                        FechaApertura = c.DateTime(nullable: false),
                        FechaClausura = c.DateTime(nullable: false),
                        FechaInicioMatricula = c.DateTime(nullable: false),
                        FechaFinMatricula = c.DateTime(nullable: false),
                        FechaMatriculaExtemporanea = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AnioAcademicoId);
            
            CreateTable(
                "dbo.Seccion",
                c => new
                    {
                        SeccionId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Capacidad = c.Int(),
                        GradoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SeccionId)
                .ForeignKey("dbo.Grado", t => t.GradoId)
                .Index(t => t.GradoId);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 70),
                        Seccion_SeccionId = c.Int(),
                    })
                .PrimaryKey(t => t.CursoId)
                .ForeignKey("dbo.Seccion", t => t.Seccion_SeccionId)
                .Index(t => t.Seccion_SeccionId);
            
            CreateTable(
                "dbo.Asistencia",
                c => new
                    {
                        AsistenciaId = c.Int(nullable: false, identity: true),
                        Estado = c.Boolean(nullable: false),
                        FechaAsistencia = c.DateTime(nullable: false),
                        CursosId = c.Int(nullable: false),
                        cuso_CursoId = c.Int(),
                    })
                .PrimaryKey(t => t.AsistenciaId)
                .ForeignKey("dbo.Curso", t => t.cuso_CursoId)
                .Index(t => t.cuso_CursoId);
            
            CreateTable(
                "dbo.Grado",
                c => new
                    {
                        GradoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        NivelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GradoId)
                .ForeignKey("dbo.Nivel", t => t.NivelId)
                .Index(t => t.NivelId);
            
            CreateTable(
                "dbo.Nivel",
                c => new
                    {
                        NivelId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.NivelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matricula", "SeccionId", "dbo.Seccion");
            DropForeignKey("dbo.Seccion", "GradoId", "dbo.Grado");
            DropForeignKey("dbo.Grado", "NivelId", "dbo.Nivel");
            DropForeignKey("dbo.Curso", "Seccion_SeccionId", "dbo.Seccion");
            DropForeignKey("dbo.Asistencia", "cuso_CursoId", "dbo.Curso");
            DropForeignKey("dbo.Matricula", "AnioAcademicoId", "dbo.AnioAcademico");
            DropForeignKey("dbo.Matricula", "AlumnoId", "dbo.Alumnos");
            DropIndex("dbo.Grado", new[] { "NivelId" });
            DropIndex("dbo.Asistencia", new[] { "cuso_CursoId" });
            DropIndex("dbo.Curso", new[] { "Seccion_SeccionId" });
            DropIndex("dbo.Seccion", new[] { "GradoId" });
            DropIndex("dbo.Matricula", new[] { "AnioAcademicoId" });
            DropIndex("dbo.Matricula", new[] { "SeccionId" });
            DropIndex("dbo.Matricula", new[] { "AlumnoId" });
            DropTable("dbo.Nivel");
            DropTable("dbo.Grado");
            DropTable("dbo.Asistencia");
            DropTable("dbo.Curso");
            DropTable("dbo.Seccion");
            DropTable("dbo.AnioAcademico");
            DropTable("dbo.Matricula");
            DropTable("dbo.Alumnos");
        }
    }
}
