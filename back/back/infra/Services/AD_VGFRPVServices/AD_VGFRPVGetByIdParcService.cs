using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.VIEW_AD_VGFRPV;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_VGFRPVServices
{
    public static class AD_VGFRPVGetByIdParcService
    {
        public static Task<AD_VGFRPV> GetByIdService(this DbAppContextSankhya ctx, int codParc)
        {
            var b = ctx.AD_VGFRPV.FirstOrDefaultAsync(x => x.Codparc == codParc);

            return b;
        }
    }
}