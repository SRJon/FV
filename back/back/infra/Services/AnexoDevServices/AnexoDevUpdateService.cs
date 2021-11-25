using System.Threading.Tasks;
using back.domain.DTO.AnexoDev;
using back.infra.Data.Context;

namespace back.infra.Services.AnexoDevServices
{
    public static class AnexoDevUpdateService
    {
        public static async Task<bool> UpdateAnexoDevServices(this DbAppContextFVUDB_TESTE ctx, AnexoDevDTOUpdateDTO AnexoDev, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(AnexoDev);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}