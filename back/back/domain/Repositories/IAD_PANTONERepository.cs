using back.data.http;
using back.domain.DTO.AD_PANTONE;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface IAD_PANTONERepository
    {
        public Task<AD_PANTONEDTO> GetByCodCor(int CodCor);
        public Task<Response<List<AD_PANTONEDTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
