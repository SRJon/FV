using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Projetos;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.ProjetosServices
{
    public static class ProjetosGetAllPaginaService
    {
        public static async Task<List<Projetos>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.Projetos.ToListAsync();
        }

    }
}