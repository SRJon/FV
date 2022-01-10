using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.TGFVendedor;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TGFVENServices
{
    public static class TGFVENAnexoGetAllPaginaService
    {
        public static async Task<List<TGFVEN>> GetAllPaginateAsync(
            this DbAppContextSankhya ctx)
        {
            return await ctx.TGFVEN.ToListAsync();
        }

    }
}