using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BProduto;
using back.data.http;
using back.domain.DTO.BProduto;

namespace back.domain.Repositories
{
    public interface IBProdutoRepository
    {
        public Task<Response<List<BProdutoDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<BProdutoDTO> GetById(int id);
        public Task<bool> Create(BProduto BProduto);
        public Task<bool> Delete(int id);
        public Task<bool> Update(BProduto BProduto);
    }
}