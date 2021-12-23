using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.AD_FAMGR3
{
    public static class AD_FAMGR3Relation
    {
        public static ModelBuilder AD_FAMGR3RelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Relação entity <> sankhya"
            modelBuilder.Entity<AD_FAMGR3>().Property(p => p.CodProdgr1).HasColumnName("CODPRODGR1");
            modelBuilder.Entity<AD_FAMGR3>().Property(p => p.CodProdgr2).HasColumnName("CODPRODGR2");
            modelBuilder.Entity<AD_FAMGR3>().Property(p => p.CodProdgr3).HasColumnName("CODPRODGR3");
            #endregion
            return modelBuilder;
        }
    }
}