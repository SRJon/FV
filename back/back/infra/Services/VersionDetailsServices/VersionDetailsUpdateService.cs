using System.Threading.Tasks;
using back.domain.DTO.VersionDetails;
using back.infra.Data.Context;

namespace back.infra.Services.VersionDetailsServices
{
    public static class VersionDetailsUpdateService
    {
        public static async Task<bool> UpdateVersionDetailsServices(this DbAppContextFVUDB_TESTE ctx, VersionDetailsDTOUpdateDTO VersionDetails, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(VersionDetails);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}