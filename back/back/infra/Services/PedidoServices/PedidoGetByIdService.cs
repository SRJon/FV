using System.Threading.Tasks;
using back.data.entities.Pedido;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.PedidoServices
{
    public static class PedidoGetByIdService
    {
        public static Task<Pedido> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.Pedido.FirstOrDefaultAsync(x => x.Id == id);
    }
}