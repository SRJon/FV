using back.data.http;
using back.domain.DTO.VGFTAB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface IVGFTABRepository
    {
        public Task<VGFTABDTO> GetByCodTab(int CodTab);
        public Task<Response<List<VGFTABDTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
