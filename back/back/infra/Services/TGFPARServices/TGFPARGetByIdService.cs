using System.Threading.Tasks;
using back.data.entities.TGFParceiro;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TGFPARServices
{
    public static class TGFPARGetByIdService
    {
        public static Task<TGFPAR> GetByIdService(this DbAppContextSankhya ctx, int id)
        {
            var b = ctx.TGFPAR.FirstOrDefaultAsync(x => x.Codparc == id);
            return b;
        }
    }
}