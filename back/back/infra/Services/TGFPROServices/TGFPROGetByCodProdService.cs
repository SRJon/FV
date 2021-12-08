using back.data.entities.TGFPRO;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.TGFPROServices
{
    public static class TGFPROGetByCodProdService
    {
        public static Task<TGFPRO> GetByCodProdService(this DbAppContextSankhya ctx, int CodProd) => ctx.TGFPRO.FirstOrDefaultAsync(x => x.CodProd == CodProd);
    }
}
