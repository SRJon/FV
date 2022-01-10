using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.TGFFinanceiroDTO;

namespace back.domain.Repositories
{
    public interface ITGFFINRepository
    {
        public Task<TGFFINClienteDTO> GetByIdFinanceiro(int nufin);
        public Task<TGFFINClienteDTO> GetByIDNumnota(int numnota);
        public Task<Response<List<TGFFINClienteDTO>>> GetAllFinanceiroPaginateAsync(int page, int limit, int codParc);
    }
}