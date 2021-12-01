using System.Threading.Tasks;
using back.data.entities.TSIEndereco;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TSIENDServices
{
    public static class TSIENDGetByIdService
    {
        public static Task<TSIEND> GetByIdService(this DbAppContextSankhya ctx, int id)
        {
            var Result = ctx.TSIEND.FirstOrDefaultAsync(x => x.Codend == id);
            return Result;
        }
    }
}