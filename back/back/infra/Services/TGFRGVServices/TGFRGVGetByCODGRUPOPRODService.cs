
using back.data.entities.TGFGrupoProdutoVendedor;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.TGFRGVServices
{
    public static class TGFRGVGetByCODGRUPOPRODService
    {
        public static Task<TGFRGV> GetByCODGRUPOPRODService(this DbAppContextSankhya ctx, int CODGRUPOPROD) => ctx.TGFRGV.FirstOrDefaultAsync(x => x.CODGRUPOPROD == CODGRUPOPROD);
    }
}
