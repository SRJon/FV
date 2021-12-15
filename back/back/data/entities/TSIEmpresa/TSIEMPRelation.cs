using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TSIEmpresa
{
    public static class TSIEMPRelation
    {
        public static ModelBuilder TSIEMPRelationConfiguring(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TSIEMP>().HasKey(u => u.CODEMP);
            modelBuilder.Entity<TSIEMP>().Property(p => p.CODEMP).HasColumnName("CODEMP");

            return modelBuilder;
        }
    }
}