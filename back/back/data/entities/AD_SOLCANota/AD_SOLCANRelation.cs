using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.AD_SOLCANota
{
    public static class AD_SOLCANRelation
    {
        public static ModelBuilder AD_SOLCANRelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Parametrização Entity <> Sankhya"
            modelBuilder.Entity<AD_SOLCAN>().HasKey(u => u.NuNota);
            modelBuilder.Entity<AD_SOLCAN>().Property(p => p.NuNota).HasColumnName("NUNOTA");
            modelBuilder.Entity<AD_SOLCAN>().Property(p => p.Motivo).HasColumnName("MOTIVO");
            modelBuilder.Entity<AD_SOLCAN>().Property(p => p.Autorizacao).HasColumnName("AUTORIZACAO");
            modelBuilder.Entity<AD_SOLCAN>().Property(p => p.DtSolicitacao).HasColumnName("DTSOLICITACAO");
            modelBuilder.Entity<AD_SOLCAN>().Property(p => p.DtAutorizacao).HasColumnName("DTAUTORIZACAO");
            modelBuilder.Entity<AD_SOLCAN>().Property(p => p.Proposta).HasColumnName("PROPOSTA");
            modelBuilder.Entity<AD_SOLCAN>().Property(p => p.CodVend).HasColumnName("CODVEND");
            modelBuilder.Entity<AD_SOLCAN>().Property(p => p.ContraProposta).HasColumnName("CONTRAPROPOSTA");
            modelBuilder.Entity<AD_SOLCAN>().Property(p => p.MotivoNegado).HasColumnName("MOTIVO_NEGADO");
            modelBuilder.Entity<AD_SOLCAN>().Property(p => p.CodParc).HasColumnName("CODPARC");
            modelBuilder.Entity<AD_SOLCAN>().Property(p => p.Ad_PedidoId).HasColumnName("AD_PEDIDOID");
            #endregion
            return modelBuilder;
        }
    }
}