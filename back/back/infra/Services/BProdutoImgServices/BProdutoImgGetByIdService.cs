using System.Threading.Tasks;
using back.data.entities.BProdutoImg;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.BProdutoImgServices
{
    public static class BProdutoImgGetByIdService
    {
        public static Task<BProdutoImg> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.BProdutoImg.FirstOrDefaultAsync(x => x.Id == id);
    }
}