using System.Threading.Tasks;
using back.data.entities.BProdutoImg;
using back.infra.Data.Context;

namespace back.infra.Services.BProdutoImgServices
{
    public static class BProdutoImgCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, BProdutoImg BProdutoImg)
        {
            ctx.BProdutoImg.Add(BProdutoImg);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}