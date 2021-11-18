using System.Threading.Tasks;
using back.data.entities.BProduto;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.BProdutoServices
{
    public static class BProdutoGetByIdService
    {
        public static Task<BProduto> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.BProduto.FirstOrDefaultAsync(x => x.Id == id);
    }
}