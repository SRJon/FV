using back.data.http;
using back.domain.DTO.TGFProdutoDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface ITGFPRORepository
    {
        public Task<TGFPRODTO> GetByCodProd(int CodProd);
        public Task<Response<List<TGFPRODTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
