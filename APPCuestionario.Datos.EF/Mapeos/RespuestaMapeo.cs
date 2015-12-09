

using System.Data.Entity.ModelConfiguration;

namespace APPCuestionario.Datos.EF.Mapeos
{
    class RespuestaMapeo : EntityTypeConfiguration<Respuesta>
    {

        public RespuestaMapeo()
        {
            ToTable("RESPUESTAS", "CS");
            HasKey(k => k.IDRespuesta);
            Property(p => p.IDRespuesta).HasColumnName("RESPUESTA_ID").IsRequired();
            Property(p => p.IDAlternativa).HasColumnName("ALTERNATIVA_ID").IsRequired();
            Property(p => p.Alternativa).HasColumnName("RESPUESTA_ALTERNATIVA").IsRequired();
            Property(p => p.IDPregunta).HasColumnName("PREGUNTA_ID").IsRequired();
            Property(p => p.IDCuestionarioRealizado).HasColumnName("CUESTIONARIOREALIZADO_ID").IsRequired();

            HasRequired(m => m.CuestionarioRealizado).WithMany().HasForeignKey(f => f.IDCuestionarioRealizado);
            HasRequired(m => m.Alternativa).WithMany().HasForeignKey(f => f.IDAlternativa);
            HasRequired(m => m.Pregunta ).WithMany().HasForeignKey(f => f.IDPregunta);





        }
    }
}
