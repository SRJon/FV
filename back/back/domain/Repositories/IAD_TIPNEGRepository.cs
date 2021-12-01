using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.AD_TIPNEG;

namespace back.domain.Repositories
{
    public interface IAD_TIPNEGRepository
    {
        public Task<Response<List<AD_TIPNEGDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<Response<List<AD_TIPNEGDTO>>> GetByDescrTipVendaPaginateAsync(int page, int limit, string DescrTipVenda);
        public Task<AD_TIPNEGDTO> GetByCodTipVenda(int CodTipVenda);
    }
}
