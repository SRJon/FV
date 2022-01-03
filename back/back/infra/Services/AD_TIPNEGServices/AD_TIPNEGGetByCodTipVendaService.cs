using System.Threading.Tasks;
using back.data.entities.View_AD_TIPNEG;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_TIPNEGServices
{
    public static class AD_TIPNEGGetByCodTipVendaService
    {
        public static Task<AD_TIPNEG> GetByCodTipVendaService(this DbAppContextSankhya ctx, int CodTipVenda) => ctx.AD_TIPNEG.FirstOrDefaultAsync(x => x.CodTipVenda == CodTipVenda);
    }
}
