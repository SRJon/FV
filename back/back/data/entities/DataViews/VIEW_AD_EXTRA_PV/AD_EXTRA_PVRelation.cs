using Microsoft.EntityFrameworkCore;

namespace back.data.entities.DataViews.VIEW_AD_EXTRA_PV
{
    public static class AD_EXTRA_PVRelation
    {
        public static ModelBuilder AD_EXTRA_PVRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AD_EXTRA_PV>().HasNoKey().ToTable("AD_EXTRA_PV");
            modelBuilder.Entity<AD_EXTRA_PV>().Property(ad => ad.Nunota).HasColumnName("NUNOTA");
            modelBuilder.Entity<AD_EXTRA_PV>().Property(ad => ad.Comissao).HasColumnName("COMISSAO");
            modelBuilder.Entity<AD_EXTRA_PV>().Property(ad => ad.Valor_Pedido).HasColumnName("VALOR_PEDIDO");
            modelBuilder.Entity<AD_EXTRA_PV>().Property(ad => ad.Observacao).HasColumnName("OBSERVACAO");
            modelBuilder.Entity<AD_EXTRA_PV>().Property(ad => ad.Ordem_Compra).HasColumnName("ORDEM_COMPRA");
            modelBuilder.Entity<AD_EXTRA_PV>().Property(ad => ad.Venda_Direta).HasColumnName("VENDA_DIRETA");

            return modelBuilder;
        }
    }
}