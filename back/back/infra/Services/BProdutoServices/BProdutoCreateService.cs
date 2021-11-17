using System.Threading.Tasks;
using back.data.entities.BProduto;
using back.infra.Data.Context;

namespace back.infra.Services.BProdutoServices
{
    public static class BProdutoCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, BProduto BProduto)
        {
            ctx.BProduto.Add(BProduto);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}