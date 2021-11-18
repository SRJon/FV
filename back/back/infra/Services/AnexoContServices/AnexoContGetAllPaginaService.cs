using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.AnexoCont;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AnexoContServices
{
    public static class AnexoContGetAllPaginaService
    {
        public static async Task<List<AnexoCont>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.AnexoCont.ToListAsync();
        }

    }
}