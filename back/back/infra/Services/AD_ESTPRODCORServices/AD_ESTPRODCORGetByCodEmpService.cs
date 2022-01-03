using back.data.entities.View_AD_ESTPRODCOR;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.AD_ESTPRODCORServices
{
    public static class AD_ESTPRODCORGetByCodEmpService
    {
        public static Task<AD_ESTPRODCOR> GetByCodEmpService(this DbAppContextSankhya ctx, int CodEmp) => ctx.AD_ESTPRODCOR.FirstOrDefaultAsync(x => x.CodEmp == CodEmp);
    }
}
