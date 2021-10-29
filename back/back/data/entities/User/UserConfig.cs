using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace back.data.entities.User
{
    public class UserConfig : IEntityTypeConfiguration<Usuario>
    {

        public void Configure(EntityTypeBuilder<Usuario> modelBuilder)
        {
            modelBuilder.Property(u => u.SgVendedorUCod).HasPrecision(10, 2);
            modelBuilder.Property(u => u.PerfilId).HasPrecision(10, 0);
            modelBuilder.Property(u => u.UsuarioId).HasPrecision(12, 0);

        }
    }
}