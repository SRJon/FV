using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TGFEXC
{
    public static class TGFEXCRelation
    {
        public static ModelBuilder TGFEXCRelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Relação entity <> sankhya"
            modelBuilder.Entity<TGFEXC>().Property(p => p.NuTab).HasColumnName("NUTAB");
            modelBuilder.Entity<TGFEXC>().Property(p => p.CodProd).HasColumnName("CODPROD");
            modelBuilder.Entity<TGFEXC>().Property(p => p.CodLocal).HasColumnName("CODLOCAL");
            modelBuilder.Entity<TGFEXC>().Property(p => p.Controle).HasColumnName("CONTROLE");
            modelBuilder.Entity<TGFEXC>().Property(p => p.VlrVenda).HasColumnName("VLRVENDA");
            modelBuilder.Entity<TGFEXC>().Property(p => p.Tipo).HasColumnName("TIPO");
            modelBuilder.Entity<TGFEXC>().Property(p => p.ModBaseIcms).HasColumnName("MODBASEICMS");
            modelBuilder.Entity<TGFEXC>().Property(p => p.PercDesc).HasColumnName("PERCDESC");
            modelBuilder.Entity<TGFEXC>().Property(p => p.MargLucro).HasColumnName("MARGLUCRO");
            modelBuilder.Entity<TGFEXC>().Property(p => p.PercCom).HasColumnName("PERCCOM");
            modelBuilder.Entity<TGFEXC>().Property(p => p.Ad_Observacao).HasColumnName("AD_OBSERVACAO");
            modelBuilder.Entity<TGFEXC>().Property(p => p.Ad_Comissao).HasColumnName("AD_COMISSAO");
            modelBuilder.Entity<TGFEXC>().Property(p => p.Ad_VlrVenda_Old).HasColumnName("AD_VLRVENDA_OLD");
            modelBuilder.Entity<TGFEXC>().Property(p => p.Ad_Cod_Tag).HasColumnName("AD_COD_TAG");
            modelBuilder.Entity<TGFEXC>().Property(p => p.Ad_Desconto_Esp).HasColumnName("AD_DESCONTO_ESP");
            modelBuilder.Entity<TGFEXC>().Property(p => p.Ad_Moeda).HasColumnName("AD_MOEDA");
            modelBuilder.Entity<TGFEXC>().Property(p => p.Ad_CodProj).HasColumnName("AD_CODPROJ");
            #endregion
            return modelBuilder;
        }
    }
}