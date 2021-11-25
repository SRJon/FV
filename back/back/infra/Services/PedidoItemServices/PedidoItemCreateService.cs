using System.Threading.Tasks;
using back.data.entities.RequestItem;
using back.infra.Data.Context;

namespace back.infra.Services.PedidoItemServices
{
    public static class PedidoItemCreateService
    {

        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, PedidoItem PedidoItem)
        {


            ctx.PedidoItem.Add(PedidoItem);
            var result = ctx.SaveChanges();


            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}