using back.data.entities.AD_FAMGR3;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.AD_FAMGR3Services
{
    public static class AD_FAMGR2GetByCodProdgr1Service
    {
        public static Task<AD_FAMGR3> GetByCodProdgr1Service(this DbAppContextSankhya ctx, int CodProdgr1) => ctx.AD_FAMGR3.FirstOrDefaultAsync(x => x.CodProdgr1 == CodProdgr1);
    }
}
