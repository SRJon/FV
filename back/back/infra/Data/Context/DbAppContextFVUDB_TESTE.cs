using back.data.entities.Screen;
using back.data.entities.User;
using back.ioc;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Context
{
    public class DbAppContextFVUDB_TESTE : DbContext
    {


        public DbAppContextFVUDB_TESTE(DbContextOptions<DbAppContextFVUDB_TESTE> options)
        : base(options)
        {
        }


        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tela> Tela { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.EntitiesConfigurationInjection();
        }
    }
}