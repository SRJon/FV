using back.data.entities.TSIEmpresa;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.infra.Services.TSIEMPServices
{
    public static class TSIEMPGetAllPaginaService
    {
        public static async Task<List<TSIEMP>> GetAllPaginateAsync(
            this DbAppContextSankhya ctx)
        {
            return await ctx.TSIEMP.ToListAsync();
        }
    }
}
