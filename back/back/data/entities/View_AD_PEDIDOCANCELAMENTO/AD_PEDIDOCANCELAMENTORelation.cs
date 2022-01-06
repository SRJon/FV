using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.View_AD_PEDIDOCANCELAMENTO
{
    public static class AD_PEDIDOCANCELAMENTORelation
    {
        public static ModelBuilder AD_PEDEDIDOCANCELAMENTORelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().HasNoKey();

            #region "Parametrização Entity <> Sankhya"
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().HasNoKey();
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.Ped_Nunota).HasColumnName("PED_NUNOTA");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.Codvend).HasColumnName("CODVEND");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.StatusLit).HasColumnName("STATUSLIT");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.Motivo).HasColumnName("MOTIVO");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.DtSolicitacao).HasColumnName("DTSOLICITACAO");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.DtAutorizacao).HasColumnName("DTAUTORIZACAO");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.Autorizacao).HasColumnName("AUTORIZACAO");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.Proposta).HasColumnName("PROPOSTA");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.Contraproposta).HasColumnName("CONTRAPROPOSTA");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.Pedad_PedidoId).HasColumnName("PEDAD_PEDIDOID");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.PedNomeParc).HasColumnName("PEDNOMEPARC");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.PedCodProj).HasColumnName("PEDCODPROJ");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.PedEstoqueAbrv).HasColumnName("PEDESTOQUEABRV");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.PedVlrPedido).HasColumnName("PEDVLRPEDIDO");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.Status_ped).HasColumnName("STATUS_PED");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.DataFatur).HasColumnName("DATAFATUR");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.CodParc).HasColumnName("CODPARC");
            modelBuilder.Entity<AD_PEDIDOCANCELAMENTO>().Property(p => p.Nota_NumNota).HasColumnName("NOTA_NUMNOTA");
            #endregion
            return modelBuilder;
        }
    }
}