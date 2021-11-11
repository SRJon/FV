using System.Threading.Tasks;
using back.domain.DTO.ProfileScreenDTO;
using back.infra.Data.Context;

namespace back.infra.Services.PerfilTelaServices
{
    public static class ProfileScreenUpdateService
    {
        public static async Task<bool> UpdatePerfilTelaServices(this DbAppContextFVUDB_TESTE ctx, PerfilTelaDTOUpdateDTO perfilTela, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(perfilTela);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}