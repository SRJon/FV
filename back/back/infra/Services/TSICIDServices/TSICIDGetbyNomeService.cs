using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TSICidade;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TSICIDServices
{
    public static class TSICIDGetbyNomeService
    {
        public static Task<TSICID> GetByNomeCidService(this DbAppContextSankhya ctx, string nomeCid)
        {
            var result = ctx.TSICID.FirstOrDefaultAsync(x => x.NomeCid == nomeCid);
            return result;
        }
    }
}