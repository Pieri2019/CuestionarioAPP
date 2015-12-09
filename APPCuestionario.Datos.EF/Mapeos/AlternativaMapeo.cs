
using System.Data.Entity.ModelConfiguration;
namespace APPCuestionario.Datos.EF.Mapeos
{
    class AlternativaMapeo : EntityTypeConfiguration<Alternativa>

    {
        public AlternativaMapeo()
        {
            ToTable("ALTERNATIVAS", "");
            HasKey(k => k.IDAlternativa);
            Property(p => p.IDAlternativa).HasColumnName("ALTERNATIVA_ID").IsRequired();
            Property(p => p.Descripcion).HasColumnName("DESCRIPCION").IsRequired();
            Property(p => p.EsCorrecta).HasColumnName("CORRECTA").IsRequired();
            Property(p => p.IDPregunta).HasColumnName("PREGUNTA_ID").IsRequired();

            HasRequired(m => m.Pregunta).WithMany().HasForeignKey(f => f.IDPregunta);
        }

    }
}
