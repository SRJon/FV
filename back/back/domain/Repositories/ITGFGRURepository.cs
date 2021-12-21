using back.data.http;
using back.domain.DTO.TGFGrupoProduto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
   public interface ITGFGRURepository
    {
        public Task<TGFGRUDTO> GetByCODGRUPOPROD(int CODGRUPOPROD);
        public Task<Response<List<TGFGRUDTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
