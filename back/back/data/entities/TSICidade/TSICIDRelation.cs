using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TSICidade
{
    public static class TSICIDRelation
    {
        public static ModelBuilder TSICIDRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TSICID>().Property(p => p.CodCid).HasColumnName("CODCID");
            modelBuilder.Entity<TSICID>().Property(p => p.Uf).HasColumnName("UF");
            modelBuilder.Entity<TSICID>().Property(p => p.NomeCid).HasColumnName("NOMECID");
            modelBuilder.Entity<TSICID>().Property(p => p.Ddd).HasColumnName("DDD");
            modelBuilder.Entity<TSICID>().Property(p => p.Dtalter).HasColumnName("DTALTER");


            return modelBuilder;
        }
    }
}