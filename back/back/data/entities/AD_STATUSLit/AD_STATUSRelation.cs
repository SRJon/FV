using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.AD_STATUSLit
{
    public static class AD_STATUSRelation
    {
        public static ModelBuilder AD_STATUSRelationConfiguring(this ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<AD_STATUS>().HasOne(c => c.AD_PED).WithOne().HasForeignKey<AD_STATUS>(p => p.Nunota);

            #region "Parametrização Entity <> Sankhya"
            modelBuilder.Entity<AD_STATUS>().HasKey(u => u.Nunota);
            modelBuilder.Entity<AD_STATUS>().Property(p => p.Nunota).HasColumnName("NUNOTA");
            modelBuilder.Entity<AD_STATUS>().Property(p => p.StatusLit).HasColumnName("STATUSLIT");
            #endregion

            return modelBuilder;
        }

    }
}