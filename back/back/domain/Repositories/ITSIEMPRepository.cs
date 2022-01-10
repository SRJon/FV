using back.data.http;
using back.domain.DTO.TSIEmpDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface ITSIEMPRepository
    {

        public Task<TSIEMPDTO> GetByCODEMP(int CODVEND);
        public Task<Response<List<TSIEMPDTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
