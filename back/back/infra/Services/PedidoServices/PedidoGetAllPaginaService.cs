using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Request;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.PedidoServices
{
    public static class PedidoGetAllPaginaService
    {
        public static async Task<List<Pedido>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.Pedido.ToListAsync();
        }

    }
}