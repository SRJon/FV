using System.Threading.Tasks;
using back.data.entities.PedidoItem;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.PedidoItemServices
{
    public static class PedidoItemGetByIdService
    {
        public static Task<PedidoItem> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.PedidoItem.FirstOrDefaultAsync(x => x.Id == id);
    }
}