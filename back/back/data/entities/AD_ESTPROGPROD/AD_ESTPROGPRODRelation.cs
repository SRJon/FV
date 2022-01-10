using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.View_AD_ESTPROGPROD
{
    public static class AD_ESTPROGPRODRelation
    {
        public static ModelBuilder AD_ESTPROGPRODRelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Relação entity <> sankhya"
            modelBuilder.Entity<AD_ESTPROGPROD>().HasNoKey();
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodEmp).HasColumnName("CODEMP");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodLocal).HasColumnName("CODLOCAL");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodProdgr1).HasColumnName("CODPRODGR1");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodProdgr2).HasColumnName("CODPRODGR2");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodProd).HasColumnName("CODPROD");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodCor).HasColumnName("CODCOR");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodCor2).HasColumnName("CODCOR2");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.AD_CodCorant).HasColumnName("AD_CODCORANT");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodGrupoCor).HasColumnName("CODGRUPOCOR");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodHex).HasColumnName("CODHEX");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodPantone).HasColumnName("CODPANTONE");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodProj).HasColumnName("CODPROJ");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.Controle).HasColumnName("CONTROLE");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.Disponivel).HasColumnName("DISPONIVEL");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.Produto).HasColumnName("PRODUTO");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.Sequencia).HasColumnName("SEQUENCIA");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.Bloqueado).HasColumnName("BLOQUEADO");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.Ad_Ld).HasColumnName("AD_LD");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodVol).HasColumnName("CODVOL");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.DtPrevisaoCheg).HasColumnName("DTPREVISAOCHEG");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.DescrProd).HasColumnName("DESCPROD");
            modelBuilder.Entity<AD_ESTPROGPROD>().Property(p => p.CodGrupoProd).HasColumnName("CODGRUPOPROD");
            #endregion
            return modelBuilder;
        }
    }
}