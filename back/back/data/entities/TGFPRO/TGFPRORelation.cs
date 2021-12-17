using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TGFPRO
{
    public static class TGFPRORelation
    {
        public static ModelBuilder TGFPRORelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Parametrização Entity <> Sankhya"
            modelBuilder.Entity<TGFPRO>().HasKey(u => u.codprod);
            #endregion
            return modelBuilder;
        }
    }
}