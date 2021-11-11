using back.data.entities.Enterprise;
using back.data.entities.Screen;
using back.data.entities.User;
using back.ioc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace back.infra.Data.Context
{
    public class DbAppContextFVUDB_TESTE : DbContext
    {

        ILoggerFactory _loggerFactory;

        public DbAppContextFVUDB_TESTE(DbContextOptions<DbAppContextFVUDB_TESTE> options, ILoggerFactory loggerFactory)
        : base(options)
        {
            _loggerFactory = loggerFactory;
            _ = Database.EnsureCreated();

        }


        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tela> Tela { get; set; }
        public DbSet<Empresa> Empresa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.EntitiesConfigurationInjection();
            modelBuilder.Entity<Tela>().HasOne(a => a.tela).WithOne().HasForeignKey<Tela>(a => a.TelaId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var loggerFactory = LoggerFactory.Create(builder =>
   {
       builder
       .AddConsole((options) => { })
       .AddFilter((category, level) =>
           category == DbLoggerCategory.Database.Command.Name
           && level == LogLevel.Information);
   });
            optionsBuilder.UseLoggerFactory(loggerFactory);
            base.OnConfiguring(optionsBuilder);



        }

    }
}