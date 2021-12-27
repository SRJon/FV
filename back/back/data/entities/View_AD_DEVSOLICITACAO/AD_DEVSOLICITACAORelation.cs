using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.View_AD_DEVSOLICITACAO
{
    public static class AD_DEVSOLICITACAORelation
    {
        public static ModelBuilder AD_DEVSOLICITACAORelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AD_DEVSOLICITACAO>().HasOne(c => c.TGFCAB).WithMany().HasForeignKey(c => c.NuNota);
            modelBuilder.Entity<AD_DEVSOLICITACAO>().HasMany(c => c.AD_ITEDEVSOLICITACAO).WithOne().HasForeignKey(c => c.nusoldev);
            #region "Parametrização Entity <> Sankhya"
            modelBuilder.Entity<AD_DEVSOLICITACAO>().HasNoKey();
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Nusoldev).HasColumnName("NUSOLDEV");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.TipFrete).HasColumnName("TIPFRETE");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.DtNeg).HasColumnName("DTNEG");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.TipoDev).HasColumnName("TIPODEV");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.NuNota).HasColumnName("NUNOTA");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.CodParc).HasColumnName("CODPARC");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.CodEmp).HasColumnName("CODEMP");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Desconto).HasColumnName("DESCONTO");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.PercDesc).HasColumnName("PERCDESC");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.CodVend).HasColumnName("CODVEND");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.NumNota_Old).HasColumnName("NUMNOTA_OLD");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.CodTipoPerdev).HasColumnName("CODTIPOPERDEV");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Comissao).HasColumnName("COMISSAO");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Status).HasColumnName("STATUS");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Contato).HasColumnName("CONTATO");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Email).HasColumnName("EMAIL");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Telefone).HasColumnName("TELEFONE");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.AutorizaDesc).HasColumnName("AUTORIZADESC");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Observacao).HasColumnName("OBSERVACAO");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.VlrOcorrencia).HasColumnName("VLROCORRENCIA");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Nrnfct).HasColumnName("NRNFCT");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Vlrct).HasColumnName("VLRCT");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Volct).HasColumnName("VOLCT");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Qtdct).HasColumnName("QTDCT");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Enviadoct).HasColumnName("ENVIADOCT");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.FreteDev).HasColumnName("FRETEDEV");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.CodBco).HasColumnName("CODBCO");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.CodAge).HasColumnName("CODAGE");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.CodOpbc).HasColumnName("CODOPBC");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.CodcTabcoint).HasColumnName("CODCTABCOINT");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.Ar).HasColumnName("AR");
            modelBuilder.Entity<AD_DEVSOLICITACAO>().Property(p => p.ParcMatriz).HasColumnName("PARCMATRIZ");
            #endregion
            return modelBuilder;
        }
    }
}