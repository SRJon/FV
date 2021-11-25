using System.Threading.Tasks;
using back.domain.DTO.Diretorio;
using back.infra.Data.Context;

namespace back.infra.Services.DiretorioServices
{
    public static class DiretorioUpdateService
    {
        public static async Task<bool> UpdateDiretorioServices(this DbAppContextFVUDB_TESTE ctx, DiretorioDTOUpdateDTO Diretorio, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(Diretorio);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}