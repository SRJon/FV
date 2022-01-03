using back.data.entities.View_AD_TIPNEG;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.infra.Services.AD_TIPNEGServices
{
    public static class AD_TIPNEGGetAllPaginaService
    {
        public static async Task<List<AD_TIPNEG>> GetAllPaginateAsync(this DbAppContextSankhya ctx) => await ctx.AD_TIPNEG.ToListAsync();
    }
}
