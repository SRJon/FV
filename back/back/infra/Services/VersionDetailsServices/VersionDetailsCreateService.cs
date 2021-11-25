using System.Threading.Tasks;
using back.data.entities.VersionDetails;
using back.infra.Data.Context;

namespace back.infra.Services.VersionDetailsServices
{
    public static class VersionDetailsCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, VersionDetails VersionDetails)
        {
            ctx.VersionDetails.Add(VersionDetails);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}