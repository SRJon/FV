using System.Threading.Tasks;
using back.data.entities.DataViews.VIEW_AD_GERAL_PV;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_GERAL_PVServices
{
    public static class AD_GERAL_PVGetByNunota
    {
        public static Task<AD_GERAL_PV> GetByNunotaServices(this DbAppContextSankhya ctx, int Nunota)
        {

            var result =  ctx.AD_GERAL_PV.FirstOrDefaultAsync(x => x.Nunota == Nunota);

            return result;
        }
    }
}