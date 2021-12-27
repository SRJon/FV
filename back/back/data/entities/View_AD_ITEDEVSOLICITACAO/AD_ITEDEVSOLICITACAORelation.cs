using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.View_AD_ITEDEVSOLICITACAO
{
    public static class AD_ITEDEVSOLICITACAORelation
    {
        public static ModelBuilder AD_ITEDEVSOLICITACAORelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AD_ITEDEVSOLICITACAO>().HasKey(u => new { u.nusoldev, u.sequencia });

            modelBuilder.Entity<AD_ITEDEVSOLICITACAO>().Property(p => p.nusoldev).HasColumnName("NUSOLDEV");
            modelBuilder.Entity<AD_ITEDEVSOLICITACAO>().Property(p => p.sequencia).HasColumnName("SEQUENCIA");
            modelBuilder.Entity<AD_ITEDEVSOLICITACAO>().Property(p => p.codprod).HasColumnName("CODPROD");
            modelBuilder.Entity<AD_ITEDEVSOLICITACAO>().Property(p => p.qtdneg).HasColumnName("QTDNEG");
            modelBuilder.Entity<AD_ITEDEVSOLICITACAO>().Property(p => p.ocorrencia).HasColumnName("OCORRENCIA");
            modelBuilder.Entity<AD_ITEDEVSOLICITACAO>().Property(p => p.nusoldev).HasColumnName("PRECO");
            modelBuilder.Entity<AD_ITEDEVSOLICITACAO>().Property(p => p.nusoldev).HasColumnName("ALIQIPI");

            return modelBuilder;
        }

    }
}