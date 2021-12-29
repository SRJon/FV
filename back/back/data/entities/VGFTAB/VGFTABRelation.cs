using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.View_VGFTAB
{
    public static class VGFTABRelation
    {
        public static ModelBuilder VGFTABRelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Relação entity <> sankhya"
            modelBuilder.Entity<VGFTAB>().HasNoKey();
            modelBuilder.Entity<VGFTAB>().Property(p => p.CodTab).HasColumnName("CODTAB");
            modelBuilder.Entity<VGFTAB>().Property(p => p.Obs).HasColumnName("OBS");
            modelBuilder.Entity<VGFTAB>().Property(p => p.NomeTab).HasColumnName("NOMETAB");
            modelBuilder.Entity<VGFTAB>().Property(p => p.DecVenda).HasColumnName("DECVENDA");
            modelBuilder.Entity<VGFTAB>().Property(p => p.CodTipParc).HasColumnName("CODTIPPARC");
            modelBuilder.Entity<VGFTAB>().Property(p => p.CodTabFlex).HasColumnName("CODTABFLEX");
            modelBuilder.Entity<VGFTAB>().Property(p => p.CodReg).HasColumnName("CODREG");
            modelBuilder.Entity<VGFTAB>().Property(p => p.CodMoeda).HasColumnName("CODMOEDA");
            modelBuilder.Entity<VGFTAB>().Property(p => p.Ativo).HasColumnName("ATIVO");
            modelBuilder.Entity<VGFTAB>().Property(p => p.Percentual).HasColumnName("PERCENTUAL");
            modelBuilder.Entity<VGFTAB>().Property(p => p.NuTab).HasColumnName("NUTAB");
            modelBuilder.Entity<VGFTAB>().Property(p => p.Formula).HasColumnName("FORMULA");
            modelBuilder.Entity<VGFTAB>().Property(p => p.DtVigor).HasColumnName("DTVIGOR");
            modelBuilder.Entity<VGFTAB>().Property(p => p.DtAlter).HasColumnName("DTALTER");
            modelBuilder.Entity<VGFTAB>().Property(p => p.CodTabOrig).HasColumnName("CODTABORIG");
            modelBuilder.Entity<VGFTAB>().Property(p => p.Ad_Filtrar_Vendedor).HasColumnName("AD_FILTRAR_VENDEDOR");
            #endregion
            return modelBuilder;
        }
    }
}