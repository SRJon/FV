using System.Threading.Tasks;
using back.domain.DTO.BProdutoImg;
using back.infra.Data.Context;

namespace back.infra.Services.BProdutoImgServices
{
    public static class BProdutoImgUpdateService
    {
        public static async Task<bool> UpdateBProdutoImgServices(this DbAppContextFVUDB_TESTE ctx, BProdutoImgDTOUpdateDTO BProdutoImg, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(BProdutoImg);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}