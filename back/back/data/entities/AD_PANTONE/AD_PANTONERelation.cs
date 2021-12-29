using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.AD_PANTONE
{
    public static class AD_PANTONERelation
    {
        public static ModelBuilder AD_PANTONERelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Relação entity <> sankhya"
            // modelBuilder.Entity<AD_PANTONE>().HasKey(u=>u.CodCor);
            modelBuilder.Entity<AD_PANTONE>().Property(p => p.CodCor).HasColumnName("CODCOR");
            modelBuilder.Entity<AD_PANTONE>().Property(p => p.CodHex).HasColumnName("CODHEX");
            modelBuilder.Entity<AD_PANTONE>().Property(p => p.Pagina).HasColumnName("PAGINA");
            modelBuilder.Entity<AD_PANTONE>().Property(p => p.CodCor2).HasColumnName("CODCOR2");
            modelBuilder.Entity<AD_PANTONE>().Property(p => p.CodGrupoCor).HasColumnName("CODGRUPOCOR");
            modelBuilder.Entity<AD_PANTONE>().Property(p => p.CodPantone).HasColumnName("CODPANTONE");
            modelBuilder.Entity<AD_PANTONE>().Property(p => p.NomeCor).HasColumnName("NOMECOR");
            modelBuilder.Entity<AD_PANTONE>().Property(p => p.Estampado).HasColumnName("ESTAMPADO");
            #endregion
            return modelBuilder;
        }
    }
}