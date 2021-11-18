using System.Threading.Tasks;
using back.domain.DTO.BProduto;
using back.infra.Data.Context;

namespace back.infra.Services.BProdutoServices
{
    public static class BProdutoUpdateService
    {
        public static async Task<bool> UpdateBProdutoServices(this DbAppContextFVUDB_TESTE ctx, BProdutoDTOUpdateDTO BProduto, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(BProduto);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}