using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.AD_PEDIDOSDTO;

namespace back.domain.Repositories
{
    public interface IAD_PEDIDOSRepository
    {
        public Task<Response<List<AD_PEDIDOSDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<AD_PEDIDOSDTO> GetByNunota(int Nunota);
    }
}