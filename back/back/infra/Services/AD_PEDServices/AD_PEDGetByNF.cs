using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.View_AD_PED;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_PEDServices
{
    public static class AD_PEDGetByNF
    {
        public static Task<AD_PED> GetByNFService(this DbAppContextSankhya ctx, int numNota) => ctx.AD_PED.FirstOrDefaultAsync(x => x.notaNumnota == numNota);
    }
}