using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.VersionDetails;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.VersionDetailsServices
{
    public static class VersionDetailsGetAllPaginaService
    {
        public static async Task<List<VersionDetails>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.VersionDetails.ToListAsync();
        }

    }
}