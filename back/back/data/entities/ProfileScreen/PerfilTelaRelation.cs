using Microsoft.EntityFrameworkCore;
namespace back.data.entities.ProfileScreen
{
    public static class PerfilTelaRelation
    {
        public static ModelBuilder ProfileScreenConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PerfilTela>()
                        .HasOne(a => a.Telas)
                        ;

            modelBuilder.Entity<PerfilTela>()
                            .HasOne(a => a.Perfil)
                            .WithMany(b => b.PerfilTela);

            return modelBuilder;
        }
    }
}