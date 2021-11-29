using System.Threading.Tasks;
using back.data.entities.TSIEndereco;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TSIENDServices
{
    public static class TSIENDGetByNomeService
    {
        public static Task<TSIEND> GetByNomeEndService(this DbAppContextSankhya ctx, string nomeEnd)
        {
            var Result = ctx.TSIEND.FirstOrDefaultAsync(x => x.Nomeend == nomeEnd);
            return Result;
        }
    }
}