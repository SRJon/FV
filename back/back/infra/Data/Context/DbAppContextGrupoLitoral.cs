using back.data.entities.User;
using back.ioc;
using Microsoft.EntityFrameworkCore;

namespace back.infra
{
    public class DbAppContextGrupoLitoral : DbContext
    {


        public DbAppContextGrupoLitoral(DbContextOptions<DbAppContextGrupoLitoral> options)
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