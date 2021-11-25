using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.AnexoDev;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AnexoDevServices
{
    public static class AnexoDevGetAllPaginaService
    {
        public static async Task<List<AnexoDev>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.AnexoDev.ToListAsync();
        }

    }
}