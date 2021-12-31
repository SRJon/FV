using System.Threading.Tasks;
using back.data.entities.DataViews.VIEW_AD_EXTRA_PV;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_EXTRA_PVServices
{
    public static class AD_EXTRA_PVGetByNunota
    {
        public static Task<AD_EXTRA_PV> GetByNunotaServices(this DbAppContextSankhya ctx, int Nunota)
        {
            var result =  ctx.AD_EXTRA_PV.FirstOrDefaultAsync(x => x.Nunota == Nunota);

            return result;
        }
    }
}