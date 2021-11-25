using System.Threading.Tasks;
using back.domain.DTO.Request;
using back.infra.Data.Context;

namespace back.infra.Services.PedidoServices
{
    public static class PedidoUpdateService
    {
        public static async Task<bool> UpdatePedidoServices(this DbAppContextFVUDB_TESTE ctx, PedidoDTOUpdateDTO Pedido, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(Pedido);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}