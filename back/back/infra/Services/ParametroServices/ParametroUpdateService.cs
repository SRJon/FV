using System.Threading.Tasks;
using back.domain.DTO.Parametro;
using back.infra.Data.Context;

namespace back.infra.Services.ParametroServices
{
    public static class ParametroUpdateService
    {
        public static async Task<bool> UpdateParametroServices(this DbAppContextFVUDB_TESTE ctx, ParametroDTOUpdateDTO Parametro, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(Parametro);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}