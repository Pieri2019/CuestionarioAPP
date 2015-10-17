namespace APPCuestionario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IEDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alternativas",
                c => new
                    {
                        IDAlternativa = c.Int(nullable: false, identity: true),
                        Descripcion = c.Int(nullable: false),
                        RAlternativa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDAlternativa);
            
            CreateTable(
                "dbo.Preguntas",
                c => new
                    {
                        IDPregunta = c.Int(nullable: false, identity: true),
                        Descripcion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDPregunta);
            
            CreateTable(
                "dbo.Cuestionarios",
                c => new
                    {
                        IDCuestionario = c.Int(nullable: false, identity: true),
                        Descripcion = c.Int(nullable: false),
                        FechaFin = c.Int(nullable: false),
                        FechaInicio = c.Int(nullable: false),
                        NPreguntas = c.Int(nullable: false),
                        Orden = c.Int(nullable: false),
                        Tiempo = c.Int(nullable: false),
                        Titulo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDCuestionario);
            
            CreateTable(
                "dbo.EstadoDeCuestionarios",
                c => new
                    {
                        IDEstadoDeCuestionario = c.Int(nullable: false, identity: true),
                        Descripcion = c.Int(nullable: false),
                        Cuestionario_IDCuestionario = c.Int(),
                    })
                .PrimaryKey(t => t.IDEstadoDeCuestionario)
                .ForeignKey("dbo.Cuestionarios", t => t.Cuestionario_IDCuestionario)
                .Index(t => t.Cuestionario_IDCuestionario);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IDUsuario = c.Int(nullable: false, identity: true),
                        Apellido = c.Int(nullable: false),
                        Contraseña = c.Int(nullable: false),
                        Login = c.Int(nullable: false),
                        Nombre = c.Int(nullable: false),
                        Rol = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDUsuario);
            
            CreateTable(
                "dbo.PreguntaAlternativas",
                c => new
                    {
                        Pregunta_IDPregunta = c.Int(nullable: false),
                        Alternativas_IDAlternativa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Pregunta_IDPregunta, t.Alternativas_IDAlternativa })
                .ForeignKey("dbo.Preguntas", t => t.Pregunta_IDPregunta, cascadeDelete: true)
                .ForeignKey("dbo.Alternativas", t => t.Alternativas_IDAlternativa, cascadeDelete: true)
                .Index(t => t.Pregunta_IDPregunta)
                .Index(t => t.Alternativas_IDAlternativa);
            
            CreateTable(
                "dbo.CuestionarioPreguntas",
                c => new
                    {
                        Cuestionario_IDCuestionario = c.Int(nullable: false),
                        Pregunta_IDPregunta = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Cuestionario_IDCuestionario, t.Pregunta_IDPregunta })
                .ForeignKey("dbo.Cuestionarios", t => t.Cuestionario_IDCuestionario, cascadeDelete: true)
                .ForeignKey("dbo.Preguntas", t => t.Pregunta_IDPregunta, cascadeDelete: true)
                .Index(t => t.Cuestionario_IDCuestionario)
                .Index(t => t.Pregunta_IDPregunta);
            
            CreateTable(
                "dbo.UsuarioCuestionarios",
                c => new
                    {
                        Usuario_IDUsuario = c.Int(nullable: false),
                        Cuestionario_IDCuestionario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Usuario_IDUsuario, t.Cuestionario_IDCuestionario })
                .ForeignKey("dbo.Usuarios", t => t.Usuario_IDUsuario, cascadeDelete: true)
                .ForeignKey("dbo.Cuestionarios", t => t.Cuestionario_IDCuestionario, cascadeDelete: true)
                .Index(t => t.Usuario_IDUsuario)
                .Index(t => t.Cuestionario_IDCuestionario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsuarioCuestionarios", "Cuestionario_IDCuestionario", "dbo.Cuestionarios");
            DropForeignKey("dbo.UsuarioCuestionarios", "Usuario_IDUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.CuestionarioPreguntas", "Pregunta_IDPregunta", "dbo.Preguntas");
            DropForeignKey("dbo.CuestionarioPreguntas", "Cuestionario_IDCuestionario", "dbo.Cuestionarios");
            DropForeignKey("dbo.EstadoDeCuestionarios", "Cuestionario_IDCuestionario", "dbo.Cuestionarios");
            DropForeignKey("dbo.PreguntaAlternativas", "Alternativas_IDAlternativa", "dbo.Alternativas");
            DropForeignKey("dbo.PreguntaAlternativas", "Pregunta_IDPregunta", "dbo.Preguntas");
            DropIndex("dbo.UsuarioCuestionarios", new[] { "Cuestionario_IDCuestionario" });
            DropIndex("dbo.UsuarioCuestionarios", new[] { "Usuario_IDUsuario" });
            DropIndex("dbo.CuestionarioPreguntas", new[] { "Pregunta_IDPregunta" });
            DropIndex("dbo.CuestionarioPreguntas", new[] { "Cuestionario_IDCuestionario" });
            DropIndex("dbo.PreguntaAlternativas", new[] { "Alternativas_IDAlternativa" });
            DropIndex("dbo.PreguntaAlternativas", new[] { "Pregunta_IDPregunta" });
            DropIndex("dbo.EstadoDeCuestionarios", new[] { "Cuestionario_IDCuestionario" });
            DropTable("dbo.UsuarioCuestionarios");
            DropTable("dbo.CuestionarioPreguntas");
            DropTable("dbo.PreguntaAlternativas");
            DropTable("dbo.Usuarios");
            DropTable("dbo.EstadoDeCuestionarios");
            DropTable("dbo.Cuestionarios");
            DropTable("dbo.Preguntas");
            DropTable("dbo.Alternativas");
        }
    }
}
