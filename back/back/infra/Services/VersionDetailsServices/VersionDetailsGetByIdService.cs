using System.Threading.Tasks;
using back.data.entities.VersionDetails;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.VersionDetailsServices
{
    public static class VersionDetailsGetByIdService
    {
        public static Task<VersionDetails> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.VersionDetails.FirstOrDefaultAsync(x => x.Id == id);
    }
}