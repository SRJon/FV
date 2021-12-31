using Microsoft.EntityFrameworkCore;

namespace back.data.entities.DataViews.VIEW_AD_GERAL_PV
{
    public static class AD_GERAL_PVRelation
    {
        public static ModelBuilder AD_GERAL_PVRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AD_GERAL_PV>().HasNoKey().ToTable("AD_GERAL_PV");
            modelBuilder.Entity<AD_GERAL_PV>().Property(ad => ad.Nunota).HasColumnName("NUNOTA");
            modelBuilder.Entity<AD_GERAL_PV>().Property(ad => ad.Vendedor).HasColumnName("VENDEDOR");
            modelBuilder.Entity<AD_GERAL_PV>().Property(ad => ad.Parceiro).HasColumnName("PARCEIRO");
            modelBuilder.Entity<AD_GERAL_PV>().Property(ad => ad.ParcRemessa).HasColumnName("PARCREMESSA");
            modelBuilder.Entity<AD_GERAL_PV>().Property(ad => ad.Redespacho).HasColumnName("REDESPACHO");
            modelBuilder.Entity<AD_GERAL_PV>().Property(ad => ad.TipOper).HasColumnName("TIPOPER");
            modelBuilder.Entity<AD_GERAL_PV>().Property(ad => ad.TipoNeg).HasColumnName("TIPONEG");
            modelBuilder.Entity<AD_GERAL_PV>().Property(ad => ad.CodProj).HasColumnName("CODPROJ");

            return modelBuilder;
        }
    }
}