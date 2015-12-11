using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using APPCuestionario.Datos.EF.Mapeos;
using APPCuestionario.Datos.EF.Contextos;

namespace APPCuestionario
{
    public class IEContexto : DbContext
    {
        public IEContexto()
            : base("IEDb")
        {
            Database.SetInitializer(new InicializadorDB());
        }

        public IEContexto(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<EstadoDeCuestionario> EstadoDeCuestionarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cuestionario> Cuestionarios { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMapeo());
            modelBuilder.Configurations.Add(new CuestionarioMapeo());
            modelBuilder.Configurations.Add(new CuestionarioRealizadoMapeo());
            modelBuilder.Configurations.Add(new PreguntaMapeo());
            modelBuilder.Configurations.Add(new RespuestaMapeo());
            modelBuilder.Configurations.Add(new AlternativaMapeo());

            //           base.OnModelCreating(modelBuilder);
            //           modelBuilder.Entity<Usuario>().HasKey(k => k.IDUsuario);
            //            modelBuilder.Entity<Cuestionario>().HasKey(k => k.IDCuestionario);
            //            modelBuilder.Entity<Pregunta>().HasKey(k => k.IDPregunta);
            //            modelBuilder.Entity<Alternativa>().HasKey(k => k.IDAlternativa);
            //            modelBuilder.Entity<EstadoDeCuestionario>().HasKey(k => k.IDEstadoDeCuestionario);

        }


    }
}