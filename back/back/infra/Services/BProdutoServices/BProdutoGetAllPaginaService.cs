using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BProduto;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.BProdutoServices
{
    public static class BProdutoGetAllPaginaService
    {
        public static async Task<List<BProduto>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.BProduto.ToListAsync();
        }

    }
}