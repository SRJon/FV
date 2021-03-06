using System.Linq;
using System.Threading.Tasks;
using back.infra.Data.Context;

namespace back.infra.Services.TGFPARServices
{
    public static class TGFPARGetLastIdCreatedService
    {
        public static int GetLastIdCreated(this DbAppContextSankhya ctx)
        {
            var lastId = ctx.TGFPAR.FirstOrDefault(p => p.codparc == (ctx.TGFPAR.Max(x => x.codparc)));
            return lastId.codparc;
        }
    }
}