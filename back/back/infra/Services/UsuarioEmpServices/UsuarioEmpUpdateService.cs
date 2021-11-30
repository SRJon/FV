using back.domain.DTO.UserEmp;
using back.infra.Data.Context;
using System.Threading.Tasks;

namespace back.infra.Services.UserEmpServices
{
    public static class UsuarioEmpUpdateService
    {
        public static async Task<bool> UpdateUsuarioEmpServices(this DbAppContextFVUDB_TESTE ctx, UsuarioEmpDTOUpdateDTO UsuarioEmp, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(UsuarioEmp);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}
