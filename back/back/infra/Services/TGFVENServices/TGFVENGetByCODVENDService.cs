using System.Threading.Tasks;
using back.data.entities.TGFVendedor;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TGFVENServices
{
    public static class TGFVENAnexoGetByCODVENDService
    {
        public static Task<TGFVEN> GetByCODVENDService(this DbAppContextSankhya ctx, int CODVEND) => ctx.TGFVEN.FirstOrDefaultAsync(x => x.codvend == CODVEND);
    }
}