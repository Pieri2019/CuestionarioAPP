using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace APPCuestionario
{
    public class IEContexto : DbContext
    {
        public IEContexto()
            : base("IEDb")
        { 
        
        }

        public DbSet<EstadoDeCuestionario> EstadoDeCuestionarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cuestionario> Cuestionarios { get; set; }
        public DbSet<Alternativas> Alternativas { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasKey(k => k.IDUsuario);
            modelBuilder.Entity<Cuestionario>().HasKey(k => k.IDCuestionario);
            modelBuilder.Entity<Pregunta>().HasKey(k => k.IDPregunta);
            modelBuilder.Entity<Alternativas>().HasKey(k => k.IDAlternativa);
            modelBuilder.Entity<EstadoDeCuestionario>().HasKey(k => k.IDEstadoDeCuestionario);

        }

    }
}
