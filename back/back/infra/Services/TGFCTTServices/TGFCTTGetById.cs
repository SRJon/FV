using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TGFContato;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TGFCTTServices
{
    public static class TGFCTTGetById
    {
        public static Task<TGFCTT> GetByIdService(this DbAppContextSankhya ctx, int codParc, int CodContato)
        {
            var result = ctx.TGFCTT.FirstOrDefaultAsync(x => x.Codparc == codParc && x.CodContato == CodContato);
            return result;
        }
    }
}