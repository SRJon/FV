using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TGFIPI
{
    public static class TGFIPIRelation
    {
        public static ModelBuilder TGFIPIRelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Relação entity <> sankhya"
            modelBuilder.Entity<TGFIPI>().HasKey(u => u.CodIpi);
            modelBuilder.Entity<TGFIPI>().Property(p => p.CodIpi).HasColumnName("CODIPI");
            modelBuilder.Entity<TGFIPI>().Property(p => p.CodFisIpi).HasColumnName("CODFISIPI");
            modelBuilder.Entity<TGFIPI>().Property(p => p.Percentual).HasColumnName("PERCENTUAL");
            modelBuilder.Entity<TGFIPI>().Property(p => p.VlrPauta).HasColumnName("VLRPAUTA");
            modelBuilder.Entity<TGFIPI>().Property(p => p.Descricao).HasColumnName("DESCRICAO");
            modelBuilder.Entity<TGFIPI>().Property(p => p.CodExNcm).HasColumnName("CODEXNCM");
            modelBuilder.Entity<TGFIPI>().Property(p => p.CodExii).HasColumnName("CODEXII");
            modelBuilder.Entity<TGFIPI>().Property(p => p.Aliqii).HasColumnName("ALIQII");
            modelBuilder.Entity<TGFIPI>().Property(p => p.PercPis).HasColumnName("PERCPIS");
            modelBuilder.Entity<TGFIPI>().Property(p => p.PercCofins).HasColumnName("PERCCONFINS");
            modelBuilder.Entity<TGFIPI>().Property(p => p.PercCssl).HasColumnName("PERCCSSL");
            modelBuilder.Entity<TGFIPI>().Property(p => p.AliqIcms).HasColumnName("ALIQIICMS");
            modelBuilder.Entity<TGFIPI>().Property(p => p.CstIpiEnt).HasColumnName("CSTIPIENT");
            modelBuilder.Entity<TGFIPI>().Property(p => p.CstIpiSai).HasColumnName("CSTIPISAI");
            modelBuilder.Entity<TGFIPI>().Property(p => p.CodStii).HasColumnName("CODSTII");
            modelBuilder.Entity<TGFIPI>().Property(p => p.PercImportacao).HasColumnName("PERCIMPORTACAO");
            modelBuilder.Entity<TGFIPI>().Property(p => p.CodEnqIpiEnt).HasColumnName("CODENQIPIENT");
            modelBuilder.Entity<TGFIPI>().Property(p => p.CodEnqIpiSai).HasColumnName("CODENQIPISAI");
            modelBuilder.Entity<TGFIPI>().Property(p => p.PerCredVlrIpi).HasColumnName("PERCREDVLRIPI");
            #endregion
            return modelBuilder;
        }
    }
}