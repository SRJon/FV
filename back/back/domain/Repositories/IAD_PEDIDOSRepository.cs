using System.Collections.Generic;
using System.Threading.Tasks;
using back.domain.DTO.AD_PEDIDOSDTO;


namespace back.domain.Repositories
{
    public interface IAD_PEDIDOSRepository
    {
        public Task<AD_PEDIDOSDTO> GetByNunota(int Nunota);
    }
}