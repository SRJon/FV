using System.Threading.Tasks;
using back.domain.DTO.AnexoRep;
using back.infra.Data.Context;

namespace back.infra.Services.AnexoRepServices
{
    public static class AnexoRepUpdateService
    {
        public static async Task<bool> UpdateAnexoRepServices(this DbAppContextFVUDB_TESTE ctx, AnexoRepDTOUpdateDTO AnexoRep, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(AnexoRep);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}