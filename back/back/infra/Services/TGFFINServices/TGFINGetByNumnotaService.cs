using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TGFinanceiro;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TGFFINServices
{
    public static class TGFINGetByNumnotaService
    {
        public static Task<TGFFIN> GetByNumNotaFinanceiroService(this DbAppContextSankhya ctx, int numnota)
        {
            var result = ctx.TGFFIN.Include(u => u.Empresa).Include(p => p.TGFCAB).FirstOrDefaultAsync(x => x.numnota == numnota);
            return result;
        }
    }
}