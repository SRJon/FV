using back.data.entities.TGFGrupoProdutoVendedor;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Services.TGFRGVServices
{
    public static class TGFRGVGetByCODVENDService
   {
        public static Task<TGFRGV> GetByCODVENDService(this DbAppContextSankhya ctx, short CODVEND) => ctx.TGFRGV.FirstOrDefaultAsync(x => x.CODVEND == CODVEND);
    }
}
