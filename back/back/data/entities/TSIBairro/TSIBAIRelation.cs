using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TSIBairro
{
    public static class TSIBAIRelation
    {
        public static ModelBuilder TSIBAIRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TSIBAI>().Property(p => p.CodBai).HasColumnName("CODBAI");
            modelBuilder.Entity<TSIBAI>().Property(p => p.NomeBai).HasColumnName("NOMEBAI");
            modelBuilder.Entity<TSIBAI>().Property(p => p.Codreg).HasColumnName("CODREG");
            modelBuilder.Entity<TSIBAI>().Property(p => p.Dtalter).HasColumnName("DTALTER");
            modelBuilder.Entity<TSIBAI>().Property(p => p.DescricaoCorreio).HasColumnName("DESCRICAOCORREIO");
            modelBuilder.Entity<TSIBAI>().Property(p => p.Nuversao).HasColumnName("NUVERSAO");
            return modelBuilder;
        }
    }
}