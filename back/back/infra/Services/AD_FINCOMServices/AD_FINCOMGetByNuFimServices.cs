using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.ViewAD_FINCOM;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_FINCOMServices
{
    public static class AD_FINCOMGetByNuFimServices
    {
        public static Task<AD_FINCOM> GetByNuFinService(this DbAppContextSankhya ctx, int nuFin)
        {
            var b = ctx.AD_FINCOM.FirstOrDefaultAsync(x => x.nufim == nuFin);

            return b;
        }
    }
}