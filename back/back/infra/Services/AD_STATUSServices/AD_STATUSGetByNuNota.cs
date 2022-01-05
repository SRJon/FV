using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.AD_STATUSLit;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_STATUSServices
{
    public static class AD_STATUSGetByNuNota
    {
        public static Task<AD_STATUS> GetByNuNotaService(this DbAppContextSankhya ctx, int nuNota) => ctx.AD_STATUS.FirstOrDefaultAsync(x => x.Nunota == nuNota);
    }
}