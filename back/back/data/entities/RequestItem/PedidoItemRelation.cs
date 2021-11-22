using Microsoft.EntityFrameworkCore;

namespace back.data.entities.RequestItem
{
    public static class PedidoItemRelation
    {
        public static ModelBuilder PedidoItemRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PedidoItem>()
                .HasOne(p => p.Pedido)
                .WithMany(p => p.PedidoItem);

            return modelBuilder;
        }
    }
}