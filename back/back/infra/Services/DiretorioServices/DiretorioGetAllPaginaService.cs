using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Diretorio;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.DiretorioServices
{
    public static class DiretorioGetAllPaginaService
    {
        public static async Task<List<Diretorio>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.Diretorio.ToListAsync();
        }

    }
}