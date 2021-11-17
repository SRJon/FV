using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BProdutoImg;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.BProdutoImgServices
{
    public static class BProdutoImgGetAllPaginaService
    {
        public static async Task<List<BProdutoImg>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.BProdutoImg.ToListAsync();
        }

    }
}