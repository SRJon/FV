using System.Threading.Tasks;
using back.domain.DTO.VersaoProjetos;
using back.infra.Data.Context;

namespace back.infra.Services.VersaoProjetosServices
{
    public static class VersaoProjetosUpdateService
    {
        public static async Task<bool> UpdateVersaoProjetosServices(this DbAppContextFVUDB_TESTE ctx, VersaoProjetosDTOUpdateDTO VersaoProjetos, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(VersaoProjetos);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}