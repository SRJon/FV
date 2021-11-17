using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.AnexoRep;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AnexoRepServices
{
    public static class AnexoRepGetAllPaginaService
    {
        public static async Task<List<AnexoRep>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.AnexoRep.ToListAsync();
        }

    }
}