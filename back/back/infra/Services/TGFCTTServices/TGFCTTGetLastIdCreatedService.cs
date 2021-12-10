using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.infra.Data.Context;

namespace back.infra.Services.TGFCTTServices
{
    public static class TGFCTTGetLastIdCreatedService
    {
        public static int GetLastIdCreated(this DbAppContextSankhya ctx, int codParc)
        {
            var lastId = ctx.TGFCTT.OrderBy(p => p.CodContato).LastOrDefault(p => p.Codparc == codParc);
            if (lastId == null)
            {
                return 0;
            }
            return lastId.CodContato;
        }
    }
}