using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TSIBairro;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TSIBAIServices
{
    public static class TSIBAIGetByIdService
    {
        public static Task<TSIBAI> GetByIdService(this DbAppContextSankhya ctx, int id)
        {
            var result = ctx.TSIBAI.FirstOrDefaultAsync(x => x.CodBai == id);
            return result;
        }
    }
}