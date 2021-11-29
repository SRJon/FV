using back.data.entities.AnexoCont;
using back.data.entities.DataViews.VIEW_AD_VGFRPV;
using back.data.entities.TGFParceiro;
using back.data.entities.TGFVEN;
using back.data.entities.TSIEMP;
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
        public DbSet<TGFVEN> TGFVEN { get; set; }
        public DbSet<TSIEMP> TSIEMP { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AD_VGFRPVRelationConfiguring();
            modelBuilder.TGFPARRelationConfiguring();
            modelBuilder.Entity<TGFVEN>().HasKey(x => x.CODVEND).HasName("PrimaryKey_CODVEND");
            modelBuilder.Entity<TSIEMP>().HasKey(x => x.CODEMP).HasName("PrimaryKey_CODEMP");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
            base.OnConfiguring(optionsBuilder);

        }

    }

}