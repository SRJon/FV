using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.View_AD_SALDO_PARCEIRO
{
    public static class AD_SALDO_PARCEIRO_Relation
    {
        public static ModelBuilder AD_SALDO_PARCEIRORelationConfiguring(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AD_SALDO_PARCEIRO>().HasNoKey();

            modelBuilder.Entity<AD_SALDO_PARCEIRO>().Property(p => p.Saldo).HasColumnName("SALDO");
            modelBuilder.Entity<AD_SALDO_PARCEIRO>().Property(p => p.CodParc).HasColumnName("CODPARC");
            modelBuilder.Entity<AD_SALDO_PARCEIRO>().Property(p => p.LimCred).HasColumnName("LIMCRED");

            return modelBuilder;
        }
    }
}