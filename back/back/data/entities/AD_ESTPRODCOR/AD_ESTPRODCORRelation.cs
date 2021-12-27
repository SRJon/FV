using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.AD_ESTPRODCOR
{
    public static class AD_ESTPRODCORRelation
    {
        public static ModelBuilder AD_ESTPRODCORRelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Relação entity <> sankhya"
            modelBuilder.Entity<AD_ESTPRODCOR>().HasNoKey();
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.CodEmp).HasColumnName("CODEMP");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.CodLocal).HasColumnName("CODLOCAL");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.CodProdgr1).HasColumnName("CODPRODGR1");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.CodProdgr2).HasColumnName("CODPRODGR2");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.CodProd).HasColumnName("CODPROD");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.CodCor).HasColumnName("CODCOR");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.CodCor2).HasColumnName("CODCOR2");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.Ad_CodCorant).HasColumnName("AD_CODCORANT");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.CodGrupoCor).HasColumnName("CODGRUPOCOR");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.CodHex).HasColumnName("CODHEX");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.CodPantone).HasColumnName("CODPANTONE");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.Disponivel).HasColumnName("DISPONIVEL");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.Produto).HasColumnName("PRODUTO");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.Sequencia).HasColumnName("SEQUENCIA");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.Ad_Ld).HasColumnName("AD_LD");
            modelBuilder.Entity<AD_ESTPRODCOR>().Property(p => p.CodVol).HasColumnName("CODVOL");
            #endregion
            return modelBuilder;
        }
    }
}