using Microsoft.EntityFrameworkCore;

namespace back.data.entities.DataViews.VIEW_AD_PEDIDOS
{
    public static class AD_PEDIDOSRelation
    {
        public static ModelBuilder AD_PEDIDOSRelationConfiguring(this ModelBuilder modelBuilder){
            modelBuilder.Entity<AD_PEDIDOS>().HasNoKey().ToTable("AD_PEDIDOS");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.Confirmada).HasColumnName("CONFIRMADA");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.Nunota).HasColumnName("NUNOTA");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.DtEmisssao).HasColumnName("DTEMISSSAO");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.NumeroPedido).HasColumnName("NUMEROPEDIDO");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.NumeroNota).HasColumnName("NUMERONOTA");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.NomeParc).HasColumnName("NOMEPARC");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.CodParc).HasColumnName("CODPARC");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.CodTioper_DescrOper).HasColumnName("CODTIOPER_DESCROPER");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.CodProj).HasColumnName("CODPROJ");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.VlrNota).HasColumnName("VLRNOTA");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.DestinoParc).HasColumnName("DESTINOPARC");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.OrdemCompra).HasColumnName("ORDEMCOMPRA");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.Observacao).HasColumnName("OBSERVACAO");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.BolDiasVenc).HasColumnName("BOLDIASVENC");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.DtCartao).HasColumnName("DTCARTAO");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.CalcPrazo).HasColumnName("CALCPRAZO");
            modelBuilder.Entity<AD_PEDIDOS>().Property(ad => ad.VendaDireta).HasColumnName("VENDADIRETA");

            return modelBuilder;
        }
    }
}