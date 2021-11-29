using back.infra.Data.Context;
using back.infra.Services.AnexoContServices;
using System.Threading.Tasks;

namespace back.infra.Services.UserEmpServices
{
    public static class UsuarioEmpDeleteService
    {
        public static async Task<bool> Delete(this DbAppContextFVUDB_TESTE ctx, int id)
        {
            var canDelete = await ctx.GetByIdService(id);
            if (canDelete == null)
            {
                return false;
            }

            ctx.Remove(canDelete);
            var result = await ctx.SaveChangesAsync();

            return result > 0;
        }
    }
}
