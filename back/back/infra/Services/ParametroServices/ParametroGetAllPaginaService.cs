using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Parametro;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.ParametroServices
{
    public static class ParametroGetAllPaginaService
    {
        public static async Task<List<Parametro>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.Parametro.ToListAsync();
        }

    }
}