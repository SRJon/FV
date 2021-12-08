using back.data.http;
using back.domain.DTO.AD_FAMGR1;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface IAD_FAMGR1Repository
    {
        public Task<AD_FAMGR1DTO> GetByCodProdgr1(int CodProdgr1);
        public Task<Response<List<AD_FAMGR1DTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
