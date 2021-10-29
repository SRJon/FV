using Microsoft.EntityFrameworkCore;

namespace back.data.entities.User
{
    public static class UserConfig
    {

        public static ModelBuilder UserConfigurations(this ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Usuario>()
            //     .HasIndex(u => u.)
            //     .IsUnique();
            return modelBuilder;
        }
    }
}