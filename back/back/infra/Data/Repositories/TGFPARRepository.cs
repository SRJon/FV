using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.TGFParceiro;
using back.domain.DTO.TGFParceiroDTO;
using back.domain.Repositories;

namespace back.infra.Data.Repositories
{
    public class TGFPARRepository : ITGFPARRepository
    {
        public Task<List<TGFPAR>> GetAllPaginateAsync(int page, int limit)
        {
            throw new System.NotImplementedException();
        }

        public Task<TGFPARDTO> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}