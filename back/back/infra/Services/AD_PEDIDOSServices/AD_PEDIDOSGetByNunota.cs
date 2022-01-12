using System.Threading.Tasks;
using back.data.entities.DataViews.VIEW_AD_PEDIDOS;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_PEDIDOSServices
{
    public static class AD_PEDIDOSGetByNunonta
    {
        public static Task<AD_PEDIDOS> GetByNunotaServices(this DbAppContextSankhya ctx, int Nunota)
        {

            var result =  ctx.AD_PEDIDOS.FirstOrDefaultAsync(x => x.Nunota == Nunota);

            return result;
        }
    }
}
