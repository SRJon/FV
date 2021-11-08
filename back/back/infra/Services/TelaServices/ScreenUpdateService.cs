using back.data.entities.Screen;
using back.domain.DTO.Tela;
using back.infra.Data.Context;
using System.Threading.Tasks;

namespace back.infra.Services.TelaServices
{
    public static class ScreenUpdateeService
    {
        public static async Task<bool> UpdateScreenServices(this DbAppContextFVUDB_TESTE ctx, TelaDTOUpdateDTO tela, int id)
        {

            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(tela);
            var result = ctx.SaveChanges();


            return result > 0 ? true : false;

        }

    }
}