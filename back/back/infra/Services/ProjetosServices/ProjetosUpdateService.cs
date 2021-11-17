using System.Threading.Tasks;
using back.domain.DTO.Projetos;
using back.infra.Data.Context;

namespace back.infra.Services.ProjetosServices
{
    public static class ProjetosUpdateService
    {
        public static async Task<bool> UpdateProjetosServices(this DbAppContextFVUDB_TESTE ctx, ProjetosDTOUpdateDTO Projetos, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(Projetos);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}