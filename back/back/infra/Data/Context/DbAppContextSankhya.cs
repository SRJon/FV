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
using back.data.entities.TGFProduto;
using back.data.entities.TGFVEN;
using back.data.entities.TSIEmpresa;
using back.data.entities.VGFTAB;
using back.data.entities.VIEW_AD_VGFRPV;
using back.data.entities.TSIEndereco;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

using back.data.entities.TSIBairro;
using back.data.entities.TSICidade;
using back.data.entities.TGFContato;
using back.data.entities.View_AD_SALDO_PARCEIRO;
using Microsoft.Extensions.Configuration;
using back.data.entities.TGFTPVenda;
using back.data.entities.TCSProjeto;
using back.data.entities.TGFCABNota;
using back.data.entities.TGFGrupoProdutoVendedor;
using back.data.entities.TGFGrupoProduto;
using back.data.entities.View_AD_DEVSOLICITACAO;
using back.data.entities.TGFinanceiro;
using back.data.entities.AD_Estoque;

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
        public DbSet<TGFRGV> TGFRGV { get; set; }
        public DbSet<TGFGRU> TGFGRU { get; set; }
        public DbSet<TGFFIN> TGFFIN { get; set; }
        public DbSet<AD_DEVSOLICITACAO> AD_DEVSOLICITACAO { get; set; }


        public DbSet<AD_ESTCODPROD> AD_ESTCODPROD { get; set; }


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
            modelBuilder.TGFRGVRelationConfiguring();

            modelBuilder.Entity<TGFVEN>().HasKey(x => x.codvend).HasName("PrimaryKey_CODVEND");
            modelBuilder.AD_DEVSOLICITACAORelationConfiguring();
            modelBuilder.TGFFINRelationConfiguring();
            modelBuilder.TSIEMPRelationConfiguring();
            modelBuilder.TGFPRORelationConfiguring();
            modelBuilder.AD_ESTPRODCORRelationConfiguring();
            modelBuilder.AD_ESTPROGPRODRelationConfiguring();
            modelBuilder.AD_FAMGR1RelationConfiguring();
            modelBuilder.AD_FAMGR2RelationConfiguring();
            modelBuilder.AD_FAMGR3RelationConfiguring();
            modelBuilder.AD_PANTONERelationConfiguring();
            modelBuilder.AD_TIPNEGRelationConfiguring();
            modelBuilder.TGFEXCRelationConfiguring();
            modelBuilder.TGFIPIRelationConfiguring();
            modelBuilder.TGFVENRelationConfiguring();
            modelBuilder.VGFTABRelationConfiguring();



            modelBuilder.Entity<TGFVEN>().HasKey(x => x.codvend).HasName("PrimaryKey_CODVEND");
            modelBuilder.Entity<TSIEMP>().HasKey(x => x.CODEMP).HasName("PrimaryKey_CODEMP");
            //modelBuilder.Entity<AD_TIPNEG>().HasKey(x => x.CodTipVenda).HasName("PrimaryKey_CodTipVenda"); VIEW SEM CHAVE
            //modelBuilder.Entity<AD_ESTPROGPROD>().HasKey(x => x.CodEmp).HasName("PrimaryKey_CodEmp"); VIEW SEM CHAVE
            modelBuilder.Entity<AD_FAMGR1>().HasKey(x => x.CodProdgr1).HasName("PrimaryKey_CodProdgr1");
            modelBuilder.Entity<AD_FAMGR2>().HasKey(x => x.CodProdgr1).HasName("PrimaryKey_CodProdgr1");
            modelBuilder.Entity<AD_FAMGR3>().HasKey(x => x.CodProdgr1).HasName("PrimaryKey_CodProdgr1");
            modelBuilder.Entity<TGFEXC>().HasKey(x => x.NuTab).HasName("PrimaryKey_NuTab");
            modelBuilder.Entity<TGFIPI>().HasKey(x => x.CodIpi).HasName("PrimaryKey_CodIpi");
            modelBuilder.Entity<TGFPRO>().HasKey(x => x.codprod).HasName("PrimaryKey_CodProd");
            //modelBuilder.Entity<VGFTAB>().HasKey(x => x.CodTab).HasName("PrimaryKey_CodTab"); VIEW SEM CHAVE
            // modelBuilder.Entity<VGFTAB>().HasKey(x => x.CodTab).HasName("PrimaryKey_CodTab");
            modelBuilder.Entity<AD_PANTONE>().HasKey(x => x.CodCor).HasName("PrimaryKey_CodCor");
            modelBuilder.Entity<AD_ESTPRODCOR>().HasNoKey();
            modelBuilder.Entity<TGFRGV>().HasKey(x => x.CODGRUPOPROD).HasName("PrimaryKey_CODGRUPOPROD");
            modelBuilder.Entity<TGFGRU>().HasKey(x => x.CODGRUPOPROD).HasName("PrimaryKey_CODGRUPOPROD");
            //modelBuilder.Entity<AD_ESTPRODCOR>().HasKey(x => x.CodEmp).HasName("PrimaryKey_CodEmp"); VIEW SEM CHAVE

            modelBuilder.Entity<AD_ESTCODPROD>().HasNoKey();
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