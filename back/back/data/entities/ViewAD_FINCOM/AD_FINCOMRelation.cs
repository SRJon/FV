using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.ViewAD_FINCOM
{
    public static class AD_FINCOMRelation
    {
        public static ModelBuilder AD_FINCOMRelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Parametrização Entity <> Sankhya"
            modelBuilder.Entity<AD_FINCOM>().HasNoKey();
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.codemp).HasColumnName("CODEMP");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.empresa).HasColumnName("EMPRESA");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.nufim).HasColumnName("NUFIN");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.codvend).HasColumnName("CODVEND");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.codparc).HasColumnName("CODPARC");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.nomeparc).HasColumnName("NOMEPARC");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.codagencia).HasColumnName("CODAGENCIA");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.contabancaria).HasColumnName("CONTABANCARIA");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.nomebco).HasColumnName("NOMEBCO");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.dtvenc).HasColumnName("DTVENC");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.vlrdesdob).HasColumnName("VLRDESDOB");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.dhbaixa).HasColumnName("DHBAIXA");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.mes_ref).HasColumnName("MES_REF");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.ano_ref).HasColumnName("ANO_REF");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.calc_ir).HasColumnName("CALC_IR");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.vlr_ir).HasColumnName("VLR_IR");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.usuario).HasColumnName("usuario");
            modelBuilder.Entity<AD_FINCOM>().Property(p => p.vlrliquido).HasColumnName("VLRLIQUIDO");
            #endregion
            return modelBuilder;
        }
    }
}