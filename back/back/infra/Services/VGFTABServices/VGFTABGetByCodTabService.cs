using back.data.entities.View_VGFTAB;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.VGFTABServices
{
    public static class VGFTABGetByCodTabService
    {
        public static Task<VGFTAB> GetByCodTabService(this DbAppContextSankhya ctx, int CodTab) => ctx.VGFTAB.FirstOrDefaultAsync(x => x.CodTab == CodTab);
    }
}
