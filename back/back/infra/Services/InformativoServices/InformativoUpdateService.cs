using System.Threading.Tasks;
using back.domain.DTO.Informativo;
using back.infra.Data.Context;

namespace back.infra.Services.InformativoServices
{
    public static class InformativoUpdateService
    {
        public static async Task<bool> UpdateInformativoServices(this DbAppContextFVUDB_TESTE ctx, InformativoDTOUpdateDTO Informativo, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(Informativo);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}