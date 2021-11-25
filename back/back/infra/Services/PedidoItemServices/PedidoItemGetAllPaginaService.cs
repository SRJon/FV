using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.RequestItem;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.PedidoItemServices
{
    public static class PedidoItemGetAllPaginaService
    {
        public static async Task<List<PedidoItem>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.PedidoItem.ToListAsync();
        }

    }
}