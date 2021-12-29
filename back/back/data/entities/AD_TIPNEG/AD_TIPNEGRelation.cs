using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.View_AD_TIPNEG
{
    public static class AD_TIPNEGRelation
    {
        public static ModelBuilder AD_TIPNEGRelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Relação entity <> sankhya"
            modelBuilder.Entity<AD_TIPNEG>().HasNoKey();
            modelBuilder.Entity<AD_TIPNEG>().Property(p => p.CodTipVenda).HasColumnName("CODTIPVENDA");
            modelBuilder.Entity<AD_TIPNEG>().Property(p => p.DhAlter).HasColumnName("DHALTER");
            modelBuilder.Entity<AD_TIPNEG>().Property(p => p.DescrTipVenda).HasColumnName("DESCRTIPVENDA");
            modelBuilder.Entity<AD_TIPNEG>().Property(p => p.Ativo).HasColumnName("ATIVO");
            modelBuilder.Entity<AD_TIPNEG>().Property(p => p.GrupoAutor).HasColumnName("GRUPOAUTOR");
            modelBuilder.Entity<AD_TIPNEG>().Property(p => p.Ad_LibRepresentate).HasColumnName("AD_LIBREPRESENTATE");
            modelBuilder.Entity<AD_TIPNEG>().Property(p => p.Media).HasColumnName("MEDIA");
            modelBuilder.Entity<AD_TIPNEG>().Property(p => p.Qtd_Parcelas).HasColumnName("QTD_PARCELAS");
            modelBuilder.Entity<AD_TIPNEG>().Property(p => p.CodParc).HasColumnName("CODPARC");
            modelBuilder.Entity<AD_TIPNEG>().Property(p => p.Prim_Parc).HasColumnName("PRIM_PARC");
            #endregion
            return modelBuilder;
        }
    }
}