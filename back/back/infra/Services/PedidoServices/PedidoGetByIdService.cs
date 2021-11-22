using System.Threading.Tasks;
using back.data.entities.Request;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.PedidoServices
{
    public static class PedidoGetByIdService
    {
        public static Task<Pedido> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id)
        {
            var b = ctx.Pedido.Include(u => u.Usuario).Include(u => u.Empresa).FirstOrDefaultAsync(x => x.Id == id);
            return b;
        }
    }
}