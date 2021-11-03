using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace back.data.entities.Screen
{
    public class TelaConfig : IEntityTypeConfiguration<Tela>
    {
        public void Configure(EntityTypeBuilder<Tela> modelBuilder)
        {
            modelBuilder.Property(u => u.TelaId).HasPrecision(12, 0);

        }
    }
}