using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TGFCABNota;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TGFCABServices
{
    public static class TGFCABGetById
    {

        public static Task<TGFCAB> GetByIdService(this DbAppContextSankhya ctx, int numNota)
        {
            var result = ctx.TGFCAB.FirstOrDefaultAsync(x => x.numnota == numNota);
            return result;
        }

    }
}