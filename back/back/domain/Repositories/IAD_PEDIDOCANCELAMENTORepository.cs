using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.AD_PEDIDOCANCELAMENTO;

namespace back.domain.Repositories
{
    public interface IAD_PEDIDOCANCELAMENTORepository
    {
        public Task<Response<List<AD_PEDIDOCANCELAMENTODTO>>> GetAllPaginateAsync(short codVend, string pesquisa, int page, int limit);
        public Task<AD_PEDIDOCANCELAMENTODTO> GetByNumNota(int numNota);

    }
}