using back.data.entities.UserEmp;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.User
{
    public static class UserRelation
    {
        public static ModelBuilder UserRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasOne(a => a.Perfil).WithMany(a => a.Usuario);

            modelBuilder.Entity<Usuario>().HasMany(a => a.UsuarioEmp).WithOne().HasForeignKey(a => a.UsuarioId);

            return modelBuilder;
        }
    }
}