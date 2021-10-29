using back.data.entities.User;
using back.ioc;
using Microsoft.EntityFrameworkCore;

namespace back.infra
{
    public class DbAppContext : DbContext
    {


        public DbAppContext(DbContextOptions<DbAppContext> options)
        : base(options)
        {
        }


        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.EntitiesConfigurationInjection();
        }
    }
}