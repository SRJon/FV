using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.AD_FamiliaGR1
{
    public static class AD_FAMGR1Relation
    {
        public static ModelBuilder AD_FAMGR1RelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Relação entity <> sankhya"
            modelBuilder.Entity<AD_FAMGR1>().Property(p => p.CodProdgr1).HasColumnName("CODPRODGR1");
            #endregion
            return modelBuilder;
        }
    }
}