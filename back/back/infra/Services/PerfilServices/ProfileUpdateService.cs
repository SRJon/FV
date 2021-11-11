using System.Threading.Tasks;
using back.domain.DTO.ProfileDTO;
using back.infra.Data.Context;

namespace back.infra.Services.PerfilServices
{
    public static class ProfileUpdateService
    {
        public static async Task<bool> UpdatePerfilServices(this DbAppContextFVUDB_TESTE ctx, PerfilDTOUpdateDTO perfil, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(perfil);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }

    }
}