using back.data.http;
using back.domain.DTO.AD_ESTPROGPROD;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface IAD_ESTPROGPRODRepository
    {
        public Task<AD_ESTPROGPRODDTO> GetByCodEmp(int CodEmp);
        public Task<Response<List<AD_ESTPROGPRODDTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
