using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BProdutoImg;
using back.data.http;
using back.domain.DTO.BProdutoImg;

namespace back.domain.Repositories
{
    public interface IBProdutoImgRepository
    {
        public Task<Response<List<BProdutoImgDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<BProdutoImgDTO> GetById(int id);
        public Task<bool> Create(BProdutoImg BProdutoImg);
        public Task<bool> Delete(int id);
        public Task<bool> Update(BProdutoImg BProdutoImg);
    }
}