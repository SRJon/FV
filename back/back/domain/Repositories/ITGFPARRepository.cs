using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.TGFParceiroDTO;

namespace back.domain.Repositories
{
    public interface ITGFPARRepository
    {
        public Task<TGFPARDTO> GetById(int id);
        public Task<Response<List<TGFPARDTO>>> GetAllPaginateAsync(int page, int limit);

    }
}