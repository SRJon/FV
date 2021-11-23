using System;
using System.Threading.Tasks;
using back.data.entities.VIEW_AD_VGFRPV;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_VGFRPVServices
{
    public static class AD_VGFRPVGetByIdService
    {
        public static Task<AD_VGFRPV> GetByIdService(this DbAppContextSankhya ctx, Int16 codVend)
        {
            var b = ctx.AD_VGFRPV.FirstOrDefaultAsync(x => x.CODVEND == codVend);

            return b;
        }
    }
}