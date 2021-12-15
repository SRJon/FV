using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TGFCABNota;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TGFCABServices
{
    public static class TGFCABGetByIdNF
    {
        public static Task<TGFCAB> GetByIdServiceNF(this DbAppContextSankhya ctx, int numNota)
        {
            var result = ctx.TGFCAB.Include(u => u.Empresa).Include(p => p.TGFTPV).FirstOrDefaultAsync(x => x.numnota == numNota);
            return result;
        }
    }
}