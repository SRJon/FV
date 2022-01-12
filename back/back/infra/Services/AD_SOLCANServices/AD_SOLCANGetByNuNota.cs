using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.AD_SOLCANota;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_SOLCANServices
{
    public static class AD_SOLCANGetByNuNota
    {
        public static Task<AD_SOLCAN> GetByNuNotaService(this DbAppContextSankhya ctx, int nuNota) => ctx.AD_SOLCAN.FirstOrDefaultAsync(x => x.NuNota == nuNota);
    }
}