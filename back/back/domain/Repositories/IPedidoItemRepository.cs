using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.PedidoItem;
using back.data.http;
using back.domain.DTO.PedidoItem;

namespace back.domain.Repositories
{
    public interface IPedidoItemRepository
    {
        public Task<Response<List<PedidoItemDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<PedidoItemDTO> GetById(int id);
        public Task<bool> Create(PedidoItem PedidoItem);
        public Task<bool> Delete(int id);
        public Task<bool> Update(PedidoItem PedidoItem);       
        
    }
}