using back.data.http;
using back.domain.DTO.TGFEXC;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface ITGFEXCRepository
    {
        public Task<TGFEXCDTO> GetByNuTab(int NuTab);
        public Task<Response<List<TGFEXCDTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
