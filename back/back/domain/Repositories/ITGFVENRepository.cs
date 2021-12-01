using back.data.http;
using back.domain.DTO.TGFVEN;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface ITGFVENRepository
    {        
        public Task<TGFVENDTO> GetByCODVEND(int CODVEND);
        public Task<Response<List<TGFVENDTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
