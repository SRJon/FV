using back.data.http;
using back.domain.DTO.TGFIPI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.domain.Repositories
{
    public interface ITGFIPIRepository
    {
        public Task<TGFIPIDTO> GetByCodIpi(int CodIpi);
        public Task<Response<List<TGFIPIDTO>>> GetAllPaginateAsync(int page, int limit);
    }
}
