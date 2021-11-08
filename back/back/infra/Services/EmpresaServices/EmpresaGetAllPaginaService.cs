using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Enterprise;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.EmpresaServices
{
    public static class EmpresaGetAllPaginaService
    {
        public static async Task<List<Empresa>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.Empresa.ToListAsync();
        }

    }
}