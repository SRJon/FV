using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TSICidade;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TSICIDServices
{
    public static class TSICIDGetByIdService
    {
        public static Task<TSICID> GetByIdService(this DbAppContextSankhya ctx, int id)
        {
            var Result = ctx.TSICID.FirstOrDefaultAsync(x => x.CodCid == id);
            return Result;
        }

    }
}