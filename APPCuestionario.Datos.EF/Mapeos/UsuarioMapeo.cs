
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APPCuestionario.Datos.EF.Mapeos
{
    class UsuarioMapeo : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapeo()
        {
            ToTable("USUARIOS", "CS");
            HasKey(k => k.IDUsuario);
            Property(p => p.IDUsuario).HasColumnName("USUARIO_ID").IsRequired();
            Property(p => p.Nombre).HasColumnName("USUARIO_NOMBRE").IsRequired();
            Property(p => p.Apellido).HasColumnName("USUARIO_APELLIDO").IsRequired();
            Property(p => p.Contraseña).HasColumnName("USUARIO_CONSTRASEÑA").IsRequired();
            Property(p => p.EsCreador ).HasColumnName("USUARIO_ROL").IsRequired();

        }
    }
}
