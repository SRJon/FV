using back.data.entities.TGFEXCProduto;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.TGFEXCServices
{
    public static class TGFEXCGetByNuTabService
    {
        public static Task<TGFEXC> GetByNuTabService(this DbAppContextSankhya ctx, int NuTab) => ctx.TGFEXC.FirstOrDefaultAsync(x => x.NuTab == NuTab);
    }
}
