
using back.data.entities.TGFGrupoProduto;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.TGFGRUServices
{
    public static class TGFGRUGetByCODGRUPOPRODService
    {
        public static Task<TGFGRU> GetByCODGRUPOPRODService(this DbAppContextSankhya ctx, int CODGRUPOPROD) => ctx.TGFGRU.FirstOrDefaultAsync(x => x.CODGRUPOPROD == CODGRUPOPROD);
    }
}
