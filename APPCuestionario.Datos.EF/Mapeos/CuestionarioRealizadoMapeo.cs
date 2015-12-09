

using System.Data.Entity.ModelConfiguration;

namespace APPCuestionario.Datos.EF.Mapeos
{
    class CuestionarioRealizadoMapeo : EntityTypeConfiguration<CuestionarioRealizado>


    {

        public CuestionarioRealizadoMapeo()
        {
            ToTable("CUESTIONARIO_REALIZADO", "CS");
            HasKey(k => k.IDCuestionarioRealizado);
            Property(p => p.IDCuestionarioRealizado).HasColumnName("CUESTIONARIOREALI_ID").IsRequired();
            Property(p => p.FechaInicio).HasColumnName("CUESTIONARIOREALI_FECHAINICIO").IsRequired();
            Property(p => p.FechaTermino).HasColumnName("CUESTIONARIOREALI_FECHAFIN").IsRequired();
            Property(p => p.IDCuestionario).HasColumnName("CUESTIONARIO_ID").IsRequired();
            Property(p => p.IDUsuario).HasColumnName("USUARIO_ID").IsRequired();

            HasRequired(m => m.Cuestionario).WithMany().HasForeignKey(f => f.IDCuestionario);
            HasRequired(m => m.Usuario ).WithMany().HasForeignKey(f => f.IDUsuario);
        }
    }
}
