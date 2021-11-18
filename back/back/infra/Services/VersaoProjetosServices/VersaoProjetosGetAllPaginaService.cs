using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.VersaoProjetos;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.VersaoProjetosServices
{
    public static class VersaoProjetosGetAllPaginaService
    {
        public static async Task<List<VersaoProjetos>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.VersaoProjetos.ToListAsync();
        }

    }
}