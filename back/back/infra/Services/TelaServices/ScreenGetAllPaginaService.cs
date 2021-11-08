using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Screen;

using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TelaServices
{
    public static class ScreenGetAllPagina
    {
        public static async Task<List<Tela>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.Tela.ToListAsync();
        }



    }
}