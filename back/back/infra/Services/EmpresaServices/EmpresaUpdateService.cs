using System.Threading.Tasks;
using back.domain.DTO.Enterprise;
using back.infra.Data.Context;

namespace back.infra.Services.EmpresaServices
{
    public static class EmpresaUpdateService
    {
        public static async Task<bool> UpdateEmpresaServices(this DbAppContextFVUDB_TESTE ctx, EmpresaDTOUpdateDTO empresa, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(empresa);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}