
using back.data.entities.DataViews.VIEW_AD_VGFRPV;
using back.data.entities.TGFParceiro;
using back.data.entities.VIEW_AD_VGFRPV;
using back.data.entities.TSIEndereco;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using back.data.entities.TSIBairro;
using back.data.entities.TSICidade;
using back.data.entities.TGFContato;

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
        public DbSet<TSIEND> TSIEND { get; set; }
        public DbSet<TSIBAI> TSIBAI { get; set; }
        public DbSet<TSICID> TSICID { get; set; }
        public DbSet<TGFCTT> TGFCTT { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AD_VGFRPVRelationConfiguring();
            modelBuilder.TGFPARRelationConfiguring();
            modelBuilder.TSIENDRelationConfiguring();
            modelBuilder.TSIBAIRelationConfiguring();
            modelBuilder.TSICIDRelationConfiguring();
            modelBuilder.TGFCTTRelationConfiguring();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
            base.OnConfiguring(optionsBuilder);

        }

    }

}