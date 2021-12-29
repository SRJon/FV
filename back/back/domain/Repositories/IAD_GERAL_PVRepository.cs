using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.AD_GERAL_PVDTO;

namespace back.domain.Repositories
{
    public interface IAD_GERAL_PVRepository
    {
        // public Task<Response<List<AD_GERAL_PVDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<AD_GERAL_PVDTO> GetByNunota(int Nunota);
    }
}