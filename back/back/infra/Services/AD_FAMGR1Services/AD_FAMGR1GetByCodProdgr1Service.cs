using back.data.entities.AD_FAMGR1;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.AD_FAMGR1Services
{
    public static class AD_FAMGR1GetByCodProdgr1Service
    {
        public static Task<AD_FAMGR1> GetByCodProdgr1Service(this DbAppContextSankhya ctx, int CodProdgr1) => ctx.AD_FAMGR1.FirstOrDefaultAsync(x => x.CodProdgr1 == CodProdgr1);
    }
}
