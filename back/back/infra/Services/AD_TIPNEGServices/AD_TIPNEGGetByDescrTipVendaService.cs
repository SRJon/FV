using back.data.entities.AD_TIPNEG;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Services.AD_TIPNEGServices
{
    public static class AD_TIPNEGGetByDescrTipVendaService
    {
        public static async Task<List<AD_TIPNEG>> GetByDescrTipVendaAsync(this DbAppContextSankhya ctx, string text) => await ctx.AD_TIPNEG.Where(x => x.DescrTipVenda.Contains(text)).ToListAsync();
    }
}
