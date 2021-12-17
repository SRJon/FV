using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.View_AD_DEVSOLICITACAO;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_DEVSOLICITACAOServices
{
    public static class GetDevolucaoByNuDevService
    {
        public static Task<AD_DEVSOLICITACAO> GetDevolucaoByNuDev(this DbAppContextSankhya ctx, int nusoldev)
        {
            var result = ctx.AD_DEVSOLICITACAO.Include(p => p.TGFCAB).FirstOrDefaultAsync(x => x.Nusoldev == nusoldev);
            return result;
        }
    }
}