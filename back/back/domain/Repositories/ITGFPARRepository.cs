using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.TGFParceiro;
using back.domain.DTO.TGFParceiroDTO;

namespace back.domain.Repositories
{
    public interface ITGFPARRepository
    {
        public Task<List<TGFPAR>> GetAllPaginateAsync(int page, int limit);
        public Task<TGFPARDTO> GetById(int id);
    }
}