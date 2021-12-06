using back.data.http;
using back.domain.DTO.AD_FAMGR3;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface IAD_FAMGR3Repository
    {
        public Task<AD_FAMGR3DTO> GetByCodProdgr1(int CodProdgr1);
        public Task<Response<List<AD_FAMGR3DTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
