using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.View_AD_ITEDEVSOLICITACAO;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_ITEDEVSOLICITACAOServices
{
    public static class AD_ITEDEVSOLICITACAOGetByNuSolDevService
    {
        public static Task<AD_ITEDEVSOLICITACAO> GetDevolucaoByNuDev(this DbAppContextSankhya ctx, int nusoldev)
        {
            var result = ctx.AD_ITEDEVSOLICITACAO.FirstOrDefaultAsync(x => x.nusoldev == nusoldev);
            return result;
        }
    }
}