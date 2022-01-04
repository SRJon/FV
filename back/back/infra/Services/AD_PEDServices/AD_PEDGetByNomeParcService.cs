using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.View_AD_PED;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_PEDServices
{
    public static class AD_PEDGetByNomeParcService
    {
        public static Task<AD_PED> GetByNomeService(this DbAppContextSankhya ctx, string nomeParc) => ctx.AD_PED.FirstOrDefaultAsync(x => x.nomeparc == nomeParc);
    }
}