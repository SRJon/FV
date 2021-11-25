using back.data.entities.Profile;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.User
{
    public static class UserRelation
    {
        public static ModelBuilder UserRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                        .HasOne(a => a.Perfil)
                        .WithMany(a => a.Usuario);
            return modelBuilder;
        }
    }
}