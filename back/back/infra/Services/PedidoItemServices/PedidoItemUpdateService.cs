using System.Threading.Tasks;
using back.domain.DTO.RequestItem;
using back.infra.Data.Context;

namespace back.infra.Services.PedidoItemServices
{
    public static class PedidoItemUpdateService
    {
        public static async Task<bool> UpdatePedidoItemServices(this DbAppContextFVUDB_TESTE ctx, PedidoItemDTOUpdateDTO PedidoItem, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(PedidoItem);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}