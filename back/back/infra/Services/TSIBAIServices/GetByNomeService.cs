using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TSIBairro;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TSIBAIServices
{
    public static class GetByNomeService
    {
        public static Task<TSIBAI> GetByNomeBaiService(this DbAppContextSankhya ctx, string nomeBai)
        {
            var result = ctx.TSIBAI.FirstOrDefaultAsync(x => x.NomeBai == nomeBai);
            return result;
        }
    }
}