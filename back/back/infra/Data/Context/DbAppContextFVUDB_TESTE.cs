using System;
using back.data.entities.Enterprise;
using back.data.entities.Profile;
using back.data.entities.ProfileScreen;
using back.data.entities.Screen;
using back.data.entities.User;
using back.domain.DTO.ProfileDTO;
using back.domain.DTO.ProfileScreenDTO;
using back.domain.DTO.ScreenDTO;
using back.domain.DTO.User;
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
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<PerfilTela> PerfilTela { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.EntitiesConfigurationInjection();
            // modelBuilder.Entity<Tela>().HasOne(a => a.tela).WithOne().HasForeignKey<Tela>(a => a.TelaId);
            modelBuilder.Entity<Tela>().HasOne(a => a.tela).WithOne().HasForeignKey<Tela>(a => a.TelaId);

            modelBuilder.Entity<Usuario>()
                        .HasOne(a => a.Perfil)
                        .WithMany(a => a.Usuario);

            modelBuilder.Entity<Perfil>()
                        .HasMany(a => a.Usuario)
                        .WithOne(a => a.Perfil);

            modelBuilder.Entity<Perfil>()
                        .HasMany(a => a.PerfilTela)
                        .WithOne(a => a.Perfil);

            modelBuilder.Entity<Perfil>()
                        .HasMany(a => a.PerfilTela)
                        .WithOne(p => p.Perfil);

            modelBuilder.Entity<PerfilTela>()
                        .HasOne(a => a.Telas)
                        .WithOne();

            modelBuilder.Entity<PerfilTela>()
                        .HasOne(a => a.Perfil)
                        .WithMany(b => b.PerfilTela);




            // modelBuilder.UserRelationConfiguring();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var loggerFactory = LoggerFactory.Create(builder =>
            //{
            //    builder
            //    .AddConsole((options) => { })
            //    .AddFilter((category, level) =>
            //        category == DbLoggerCategory.Database.Command.Name
            //        && level == LogLevel.Information);
            //}
            //    );
            // optionsBuilder.UseLoggerFactory(loggerFactory);
            optionsBuilder.LogTo(Console.WriteLine);
            base.OnConfiguring(optionsBuilder);



        }

    }

}