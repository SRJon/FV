using back.data.entities.TGFIPI;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.TGFIPIServices
{
    public static class TGFIPIGetByCodIpiService
    {
        public static Task<TGFIPI> GetByCodIpiService(this DbAppContextSankhya ctx, int CodIpi) => ctx.TGFIPI.FirstOrDefaultAsync(x => x.CodIpi == CodIpi);
    }
}
