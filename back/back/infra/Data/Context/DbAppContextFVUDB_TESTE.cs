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
            modelBuilder.Entity<TelaDTO>().HasOne(a => a.tela).WithOne().HasForeignKey<TelaDTOChild>(a => a.TelaId);


            //funciona +/-
            // modelBuilder.Entity<UsuarioDTO>()
            // .HasOne(a => a.Perfil)
            // .WithOne(p => p.Usuario)
            // .HasForeignKey<PerfilDTO>(a => a.PerfilId);


            modelBuilder.Entity<UsuarioDTO>()
                        .HasOne(a => a.Perfil)
                        .WithOne()
                        .HasForeignKey<PerfilDTOUserless>(a => a.PerfilId);

            modelBuilder.Entity<Perfil>()
                        .HasMany(a => a.PerfilTela)
                        .WithOne(a => a.Perfil)
                        .HasForeignKey(a => a.PerfilId);

            modelBuilder.Entity<PerfilDTOUserless>()
            .HasMany(a => a.PerfilTela)
            .WithOne()
            .HasForeignKey(a => a.PerfilId);

            modelBuilder.Entity<PerfilTelaDTOProfiless>()
            .HasMany(a => a.Telas)
            .WithOne()
            .HasForeignKey(a => a.TelaId);



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