

using System.Data.Entity.ModelConfiguration;

namespace APPCuestionario.Datos.EF.Mapeos
{
    class PreguntaMapeo : EntityTypeConfiguration<Pregunta>

    {

        public PreguntaMapeo()
        {
            ToTable("PREGUNTAS", "CS");
            HasKey(K => K.IDPregunta);
            Property(p => p.IDPregunta).HasColumnName("PREGUNTA_ID").IsRequired();
            Property(p => p.Descripcion).HasColumnName("PREGUNTA_DESCRIPCION").IsRequired();
            Property(p => p.IDCuestionario).HasColumnName("CUESTIONARIO_ID").IsRequired();

            HasRequired(m => m.Cuestionario).WithMany().HasForeignKey(f => f.IDCuestionario);

            
        }

    }
}
