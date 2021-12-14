using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TCSProjeto
{
    public static class TCSPRJRelation
    {
        public static ModelBuilder TCSPRJRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TCSPRJ>().Property(p => p.Codproj).HasColumnName("CODPROJ");
            modelBuilder.Entity<TCSPRJ>().Property(p => p.Codprod).HasColumnName("CODPROD");
            modelBuilder.Entity<TCSPRJ>().Property(p => p.Identificacao).HasColumnName("IDENTIFICACAO");
            modelBuilder.Entity<TCSPRJ>().Property(p => p.Abreviatura).HasColumnName("ABREVIATURA");
            modelBuilder.Entity<TCSPRJ>().Property(p => p.Ativo).HasColumnName("ATIVO");
            modelBuilder.Entity<TCSPRJ>().Property(p => p.Grau).HasColumnName("GRAU");
            modelBuilder.Entity<TCSPRJ>().Property(p => p.Codprojpai).HasColumnName("CODPROJPAI");
            modelBuilder.Entity<TCSPRJ>().Property(p => p.Analitico).HasColumnName("ANALITICO");
            modelBuilder.Entity<TCSPRJ>().Property(p => p.Ad_Blolanc).HasColumnName("AD_BLOLANC");

            return modelBuilder;
        }
    }
}