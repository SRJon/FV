using back.data.http;
using back.domain.DTO.AD_ESTPRODCOR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface IAD_ESTPRODCORRepository
    {
        public Task<AD_ESTPRODCORDTO> GetByCodEmp(int CodEmp);
        public Task<Response<List<AD_ESTPRODCORDTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
