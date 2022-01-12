using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.AD_PRODUTO_PV;

namespace back.domain.Repositories
{
    public interface IAD_PRODUTO_PVRepository
    {
        public Task<AD_PRODUTO_PVDTO> GetByNunota(int Nunota);
    }
}