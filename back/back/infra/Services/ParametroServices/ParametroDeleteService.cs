using System.Threading.Tasks;
using back.infra.Data.Context;

namespace back.infra.Services.ParametroServices
{
    public static class ParametroDeleteService
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