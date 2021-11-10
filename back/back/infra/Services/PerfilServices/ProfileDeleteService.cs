
using System.Threading.Tasks;
using back.infra.Data.Context;
namespace back.infra.Services.PerfilServices
{
    public static class ProfileDeleteService
    {
        public static async Task<bool> Delete(this DbAppContextFVUDB_TESTE ctx, int id)
        {
            var carnDelete = await ctx.GetByIdService(id);
            if (carnDelete == null)
            {
                return false;
            }
            ctx.Remove(carnDelete);
            var result = await ctx.SaveChangesAsync();

            return result > 0;
        }
    }
}