


using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APPCuestionario.Datos.EF.Mapeos
{
    class CuestionarioMapeo : EntityTypeConfiguration<Cuestionario>
    {

        public CuestionarioMapeo()
        {
            ToTable("CUESTIONARIOS", "CS");
            HasKey(k => k.IDCuestionario);
            Property(p => p.IDCuestionario).HasColumnName("CUESTIONARIO_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.IDUsuario).HasColumnName("USUARIO_ID").IsRequired();
            Property(p => p.Descripcion).HasColumnName("DESCRIPCION").IsRequired();
            Property(p => p.EstadoCuestionario).HasColumnName("ESTADO").IsRequired();
            Property(p => p.)

            HasRequired(m => m.Creador).WithMany().HasForeignKey(f => f.IDUsuario);
           
        }

    }
}
