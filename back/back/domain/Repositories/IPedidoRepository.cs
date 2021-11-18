using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Pedido;
using back.data.http;
using back.domain.DTO.Pedido;

namespace back.domain.Repositories
{
    public interface IPedidoRepository
    {
        public Task<Response<List<PedidoDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<PedidoDTO> GetById(int id);
        public Task<bool> Create(Pedido Pedido);
        public Task<bool> Delete(int id);
        public Task<bool> Update(Pedido Pedido);
    }
}