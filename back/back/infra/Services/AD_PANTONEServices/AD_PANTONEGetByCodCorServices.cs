using back.data.entities.AD_PANTONE;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.AD_PANTONEServices
{
    public static class AD_PANTONEGetByCodCorServices
    {
        public static Task<AD_PANTONE> GetByCodCorService(this DbAppContextSankhya ctx, int CodCor) => ctx.AD_PANTONE.FirstOrDefaultAsync(x => x.CodCor == CodCor);
    }
}
