using back.data.http;
using back.domain.DTO.AD_FAMGR2;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface IAD_FAMGR2Repository
    {
        public Task<AD_FAMGR2DTO> GetByCodProdgr1(int CodProdgr1);
        public Task<Response<List<AD_FAMGR2DTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
