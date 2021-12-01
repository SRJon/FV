using System.Threading.Tasks;
using back.data.entities.TGFParceiro;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TGFPARServices
{
    public static class TGFPARGetByCgc_cpfService
    {
        public static Task<TGFPAR> GetByCNPJService(this DbAppContextSankhya ctx, string cgc_cpf)
        {
            var result = ctx.TGFPAR.FirstOrDefaultAsync(x => x.Cgc_cpf == cgc_cpf);
            return result;
        }
    }
}