using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.View_AD_PED
{
    public static class AD_PEDRelation
    {
        public static ModelBuilder AD_PEDRelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Parametrização Entity <> Sankhya"
            modelBuilder.Entity<AD_PED>().HasNoKey();
            modelBuilder.Entity<AD_PED>().Property(p => p.codemp).HasColumnName("CODEMP");
            modelBuilder.Entity<AD_PED>().Property(p => p.nomefantasia).HasColumnName("NOMEFANTASIA");
            modelBuilder.Entity<AD_PED>().Property(p => p.codparc).HasColumnName("CODPARC");
            modelBuilder.Entity<AD_PED>().Property(p => p.nomeparc).HasColumnName("NOMEPARC");
            modelBuilder.Entity<AD_PED>().Property(p => p.codvend).HasColumnName("CODVEND");
            modelBuilder.Entity<AD_PED>().Property(p => p.nomevend).HasColumnName("NOMEVEND");
            modelBuilder.Entity<AD_PED>().Property(p => p.pedNunota).HasColumnName("PED_NUNOTA");
            modelBuilder.Entity<AD_PED>().Property(p => p.pedNumnota).HasColumnName("PED_NUMNOTA");
            modelBuilder.Entity<AD_PED>().Property(p => p.dtneg).HasColumnName("DTNEG");
            modelBuilder.Entity<AD_PED>().Property(p => p.tipmov).HasColumnName("TIPMOV");
            modelBuilder.Entity<AD_PED>().Property(p => p.vlrpedido).HasColumnName("VLRPEDIDO");
            modelBuilder.Entity<AD_PED>().Property(p => p.adStatus).HasColumnName("AD_STATUS");
            modelBuilder.Entity<AD_PED>().Property(p => p.adPedidoid).HasColumnName("AD_PEDIDOID");
            modelBuilder.Entity<AD_PED>().Property(p => p.codproj).HasColumnName("CODPROJ");
            modelBuilder.Entity<AD_PED>().Property(p => p.codtipvenda).HasColumnName("CODTIPVENDA");
            modelBuilder.Entity<AD_PED>().Property(p => p.descrtipvenda).HasColumnName("DESCRTIPVENDA");
            modelBuilder.Entity<AD_PED>().Property(p => p.estoque).HasColumnName("ESTOQUE");
            modelBuilder.Entity<AD_PED>().Property(p => p.estoqueAbreviado).HasColumnName("ESTOQUE_ABREVIADO");
            modelBuilder.Entity<AD_PED>().Property(p => p.notaNunota).HasColumnName("NOTA_NUNOTA");
            modelBuilder.Entity<AD_PED>().Property(p => p.notaNumnota).HasColumnName("NOTA_NUMNOTA");
            modelBuilder.Entity<AD_PED>().Property(p => p.vlrnota).HasColumnName("VLRNOTA");
            modelBuilder.Entity<AD_PED>().Property(p => p.datafatur).HasColumnName("DATAFATUR");
            modelBuilder.Entity<AD_PED>().Property(p => p.codParcDest).HasColumnName("CODPARC_DEST");
            modelBuilder.Entity<AD_PED>().Property(p => p.nomeParcDest).HasColumnName("NOMEPARC_DEST");
            modelBuilder.Entity<AD_PED>().Property(p => p.notaRemNuNota).HasColumnName("NOTA_REM_NUNOTA");
            modelBuilder.Entity<AD_PED>().Property(p => p.notaRemNumNota).HasColumnName("NOTA_REM_NUMNOTA");
            modelBuilder.Entity<AD_PED>().Property(p => p.codparcTransp).HasColumnName("CODPARC_TRANSP");
            modelBuilder.Entity<AD_PED>().Property(p => p.nomeparcTransp).HasColumnName("NOMEPARC_TRANSP");
            modelBuilder.Entity<AD_PED>().Property(p => p.cancelado).HasColumnName("CANCELADO");
            modelBuilder.Entity<AD_PED>().Property(p => p.motvcanc).HasColumnName("MOTVCANC");
            modelBuilder.Entity<AD_PED>().Property(p => p.dtmov).HasColumnName("DTMOV");
            modelBuilder.Entity<AD_PED>().Property(p => p.statusPed).HasColumnName("STATUS_PED");
            #endregion
            return modelBuilder;
        }
    }
}