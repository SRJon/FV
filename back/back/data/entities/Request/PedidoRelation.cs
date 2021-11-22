using Microsoft.EntityFrameworkCore;

namespace back.data.entities.Request
{
    public static class PedidoRelation
    {
        public static ModelBuilder PedidoRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .HasOne(u => u.Usuario);

            modelBuilder.Entity<Pedido>()
                .HasOne(u => u.Empresa);

            modelBuilder.Entity<Pedido>()
                .HasMany(p => p.PedidoItem)
                .WithOne(p => p.Pedido);
            return modelBuilder;
        }
    }
}