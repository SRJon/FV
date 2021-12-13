using back.data.entities.TSIEmpresa;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.TSIEMPServices
{
    public static class TSIEMPGetByCODEMPService
    {
        public static Task<TSIEMP> GetByCODEMPService(this DbAppContextSankhya ctx, int CODEMP) => ctx.TSIEMP.FirstOrDefaultAsync(x => x.CODEMP == CODEMP);
    }
}
