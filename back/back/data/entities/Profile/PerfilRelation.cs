using Microsoft.EntityFrameworkCore;

namespace back.data.entities.Profile
{
    public static class PerfilRelation
    {
        public static ModelBuilder ProfileRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Perfil>()
                        .HasMany(a => a.Usuario)
                        .WithOne(a => a.Perfil);

            modelBuilder.Entity<Perfil>()
                        .HasMany(a => a.PerfilTela)
                        .WithOne(a => a.Perfil);

            modelBuilder.Entity<Perfil>()
                        .HasMany(a => a.PerfilTela)
                        .WithOne(p => p.Perfil);

            return modelBuilder;
        }
    }
}