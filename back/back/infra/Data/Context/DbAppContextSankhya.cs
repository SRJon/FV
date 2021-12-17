using back.data.entities.AD_ESTPRODCOR;
using back.data.entities.AD_ESTPROGPROD;
using back.data.entities.AD_FAMGR1;
using back.data.entities.AD_FAMGR2;
using back.data.entities.AD_FAMGR3;
using back.data.entities.AD_PANTONE;
using back.data.entities.AD_TIPNEG;
using back.data.entities.DataViews.VIEW_AD_VGFRPV;
using back.data.entities.TGFEXC;
using back.data.entities.TGFIPI;
using back.data.entities.TGFParceiro;
using back.data.entities.TGFPRO;
using back.data.entities.TGFVEN;
using back.data.entities.TSIEmpresa;
using back.data.entities.VGFTAB;
using back.data.entities.VIEW_AD_VGFRPV;
using back.data.entities.TSIEndereco;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

using back.data.entities.TSIBairro;
using back.data.entities.TSICidade;
using back.data.entities.TGFContato;
using back.data.entities.View_AD_SALDO_PARCEIRO;
using Microsoft.Extensions.Configuration;
using back.data.entities.TGFTPVenda;
using back.data.entities.TCSProjeto;
using back.data.entities.TGFCABNota;

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
        public DbSet<TGFVEN> TGFVEN { get; set; }
        public DbSet<TSIEMP> TSIEMP { get; set; }
        public DbSet<AD_TIPNEG> AD_TIPNEG { get; set; }
        public DbSet<AD_SALDO_PARCEIRO> AD_SALDO_PARCEIRO { get; set; }
        public DbSet<AD_ESTPROGPROD> AD_ESTPROGPROD { get; set; }
        public DbSet<AD_FAMGR1> AD_FAMGR1 { get; set; }
        public DbSet<AD_FAMGR2> AD_FAMGR2 { get; set; }
        public DbSet<AD_FAMGR3> AD_FAMGR3 { get; set; }
        public DbSet<TGFEXC> TGFEXC { get; set; }
        public DbSet<TGFIPI> TGFIPI { get; set; }
        public DbSet<TGFPRO> TGFPRO { get; set; }
        public DbSet<VGFTAB> VGFTAB { get; set; }
        public DbSet<AD_PANTONE> AD_PANTONE { get; set; }
        public DbSet<AD_ESTPRODCOR> AD_ESTPRODCOR { get; set; }
        public DbSet<TGFTPV> TGFTPV { get; set; }
        public DbSet<TCSPRJ> TCSPRJ { get; set; }
        public DbSet<TGFCAB> TGFCAB { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AD_VGFRPVRelationConfiguring();
            modelBuilder.TGFPARRelationConfiguring();
            modelBuilder.TSIENDRelationConfiguring();
            modelBuilder.TSIBAIRelationConfiguring();
            modelBuilder.TSICIDRelationConfiguring();
            modelBuilder.TGFCTTRelationConfiguring();
            modelBuilder.AD_SALDO_PARCEIRORelationConfiguring();
            modelBuilder.TGFTPVRelationConfiguring();
            modelBuilder.TCSPRJRelationConfiguring();
            modelBuilder.TGFCABRelationConfiguring();

            modelBuilder.Entity<TGFVEN>().HasKey(x => x.CODVEND).HasName("PrimaryKey_CODVEND");
            modelBuilder.Entity<TSIEMP>().HasKey(x => x.CODEMP).HasName("PrimaryKey_CODEMP");
            modelBuilder.Entity<AD_TIPNEG>().HasKey(x => x.CodTipVenda).HasName("PrimaryKey_CodTipVenda");
            modelBuilder.Entity<AD_ESTPROGPROD>().HasKey(x => x.CodEmp).HasName("PrimaryKey_CodEmp");
            modelBuilder.Entity<AD_FAMGR1>().HasKey(x => x.CodProdgr1).HasName("PrimaryKey_CodProdgr1");
            modelBuilder.Entity<AD_FAMGR2>().HasKey(x => x.CodProdgr1).HasName("PrimaryKey_CodProdgr1");
            modelBuilder.Entity<AD_FAMGR3>().HasKey(x => x.CodProdgr1).HasName("PrimaryKey_CodProdgr1");
            modelBuilder.Entity<TGFEXC>().HasKey(x => x.NuTab).HasName("PrimaryKey_NuTab");
            modelBuilder.Entity<TGFIPI>().HasKey(x => x.CodIpi).HasName("PrimaryKey_CodIpi");
            modelBuilder.Entity<TGFPRO>().HasKey(x => x.codprod).HasName("PrimaryKey_CodProd");
            modelBuilder.Entity<VGFTAB>().HasKey(x => x.CodTab).HasName("PrimaryKey_CodTab");
            modelBuilder.Entity<AD_PANTONE>().HasKey(x => x.CodCor).HasName("PrimaryKey_CodCor");
            modelBuilder.Entity<AD_ESTPRODCOR>().HasKey(x => x.CodEmp).HasName("PrimaryKey_CodEmp");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration _config = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json")
               .Build();
            var isProduction = _config.GetValue<bool>("isProduction");
            if (!isProduction)
            {

                optionsBuilder.LogTo(Console.WriteLine);
            }
            base.OnConfiguring(optionsBuilder);

        }

    }

}