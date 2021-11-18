using System.Threading.Tasks;
using back.domain.DTO.AnexoCont;
using back.infra.Data.Context;

namespace back.infra.Services.AnexoContServices
{
    public static class AnexoContUpdateService
    {
        public static async Task<bool> UpdateAnexoContServices(this DbAppContextFVUDB_TESTE ctx, AnexoContDTOUpdateDTO AnexoCont, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(AnexoCont);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}