using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.DataViews.VIEW_AD_PRODUTO_PV
{
    public static class AD_PRODUTO_PVRelation
    {
        public static ModelBuilder AD_PRODUTO_PVRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AD_PRODUTO_PV>().HasNoKey().ToTable("AD_PRODUTO_PV");
            modelBuilder.Entity<AD_PRODUTO_PV>().Property(ad => ad.Nunota).HasColumnName("NUNOTA");
            modelBuilder.Entity<AD_PRODUTO_PV>().Property(ad => ad.Codigo_Cor).HasColumnName("CODIGO_COR");
            modelBuilder.Entity<AD_PRODUTO_PV>().Property(ad => ad.Codigo_Produto).HasColumnName("CODIGO_PRODUTO");
            modelBuilder.Entity<AD_PRODUTO_PV>().Property(ad => ad.Comissao).HasColumnName("COMISSAO");
            modelBuilder.Entity<AD_PRODUTO_PV>().Property(ad => ad.Valor_Unitario).HasColumnName("VALOR_UNITARIO");
            modelBuilder.Entity<AD_PRODUTO_PV>().Property(ad => ad.Quantidade_Negociada).HasColumnName("QUANTIDADE_NEGOCIADA");
            modelBuilder.Entity<AD_PRODUTO_PV>().Property(ad => ad.Valor_Total).HasColumnName("VALOR_TOTAL");
            modelBuilder.Entity<AD_PRODUTO_PV>().Property(ad => ad.Controle).HasColumnName("CONTROLE");
            modelBuilder.Entity<AD_PRODUTO_PV>().Property(ad => ad.Descricao_Completa).HasColumnName("DESCRICAO_COMPLETA");
            modelBuilder.Entity<AD_PRODUTO_PV>().Property(ad => ad.Tabela).HasColumnName("TABELA");
            modelBuilder.Entity<AD_PRODUTO_PV>().Property(ad => ad.Hexa_Pantone).HasColumnName("HEXA_PANTONE");

            return modelBuilder;
        }
    }
}