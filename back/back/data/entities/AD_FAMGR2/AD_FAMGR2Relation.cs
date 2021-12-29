using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.AD_FamiliaGR2
{
    public static class AD_FAMGR2Relation
    {
        public static ModelBuilder AD_FAMGR2RelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Relação entity <> sankhya"
            modelBuilder.Entity<AD_FAMGR2>().Property(p => p.CodProdgr1).HasColumnName("CODPRODGR1");
            modelBuilder.Entity<AD_FAMGR2>().Property(p => p.CodProdgr2).HasColumnName("CODPRODGR2");
            #endregion
            return modelBuilder;
        }
    }
}