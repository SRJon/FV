using System.Threading.Tasks;
using back.data.entities.Pedido;
using back.infra.Data.Context;

namespace back.infra.Services.PedidoServices
{
    public static class PedidoCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, Pedido Pedido)
        {
            ctx.Pedido.Add(Pedido);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}