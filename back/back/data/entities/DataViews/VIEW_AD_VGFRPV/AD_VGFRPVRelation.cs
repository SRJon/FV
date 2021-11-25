using back.data.entities.VIEW_AD_VGFRPV;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.DataViews.VIEW_AD_VGFRPV
{
    public static class AD_VGFRPVRelation
    {
        public static ModelBuilder AD_VGFRPVRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AD_VGFRPV>().HasNoKey().ToTable("AD_VGFRPV");
            modelBuilder.Entity<AD_VGFRPV>().Property(ad => ad.Codparc).HasColumnName("CODPARC");
            modelBuilder.Entity<AD_VGFRPV>().Property(ad => ad.Codvend).HasColumnName("CODVEND");
            modelBuilder.Entity<AD_VGFRPV>().Property(ad => ad.Nomvend).HasColumnName("NOMEVEND");
            modelBuilder.Entity<AD_VGFRPV>().Property(ad => ad.Nomeparc).HasColumnName("NOMEPARC");
            modelBuilder.Entity<AD_VGFRPV>().Property(ad => ad.Cgc_cpf).HasColumnName("CGC_CPF");
            modelBuilder.Entity<AD_VGFRPV>().Property(ad => ad.Atraso).HasColumnName("ATRASO");
            return modelBuilder;
        }

    }
}