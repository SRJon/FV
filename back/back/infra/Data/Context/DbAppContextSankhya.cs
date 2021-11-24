using back.data.entities.AnexoCont;
using back.data.entities.TGFParceiro;
using back.data.entities.VIEW_AD_VGFRPV;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace back.infra.Data.Context
{
    public class DbAppContextSankhya : DbContext
    {

        ILoggerFactory _loggerFactory;

        public DbAppContextSankhya(DbContextOptions<DbAppContextSankhya> options, ILoggerFactory loggerFactory)
        : base(options)
        {
            _loggerFactory = loggerFactory;
            _ = Database.EnsureCreated();

        }

        // public DbSet<AnexoCont> AnexoCont { get; set; }
        public DbSet<AD_VGFRPV> AD_VGFRPV { get; set; }
        public DbSet<TGFPAR> TGFPAR { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AD_VGFRPV>().HasNoKey();
            modelBuilder.Entity<TGFPAR>().HasNoKey();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
            base.OnConfiguring(optionsBuilder);

        }

    }

}