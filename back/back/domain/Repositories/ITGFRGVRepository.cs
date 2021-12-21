using back.data.http;
using back.domain.DTO.TGFRGV;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface ITGFRGVRepository
    {
        public Task<TGFRGVDTO> GetByCODGRUPOPROD(int CODGRUPOPROD);
        public Task<Response<List<TGFRGVDTO>>> GetByCODVEND(short CODVEND);
        public Task<Response<List<TGFRGVDTO>>> GetAllPaginateAsync(int page, int limit);

    }
}
