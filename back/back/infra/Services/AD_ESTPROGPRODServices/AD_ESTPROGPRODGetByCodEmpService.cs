using back.data.entities.AD_ESTPROGPROD;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.AD_ESTPROGPRODServices
{
    public static class AD_ESTPROGPRODGetByCodEmpService
    {
        public static Task<AD_ESTPROGPROD> GetByCodEmpService(this DbAppContextSankhya ctx, int CodEmp) => ctx.AD_ESTPROGPROD.FirstOrDefaultAsync(x => x.CodEmp == CodEmp);
    }
}
