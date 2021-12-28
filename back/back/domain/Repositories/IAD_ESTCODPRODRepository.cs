using back.data.http;
using back.domain.DTO.AD_Estoque;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface IAD_ESTCODPRODRepository
    {
        public Task<Response<List<AD_ESTCODPRODDTO>>> GetSearchPaginateAsync(int page, int limit, int Produto, int CodGrupoProd, string DescrProd, string ComplDesc);
    }
}
