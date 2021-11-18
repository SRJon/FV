using back.data.entities.Profile;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.User
{
    public static class UserRelation
    {
        public static ModelBuilder UserRelationConfiguring(this ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Usuario>()
            //     .HasOne(u => u.Perfil)
            //     .WithOne();
            // .HasForeignKey(e => e.PerfilId);
            // modelBuilder.Entity<TelaDTO>().HasOne(a => a.tela).WithOne().HasForeignKey<TelaDTOChild>(a => a.TelaId);


            return modelBuilder;
        }
    }
}