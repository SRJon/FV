using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Informativo;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.InformativoServices
{
    public static class InformativoGetAllPaginaService
    {
        public static async Task<List<Informativo>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.Informativo.ToListAsync();
        }

    }
}