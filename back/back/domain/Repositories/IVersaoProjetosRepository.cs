using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.VersaoProjetos;
using back.data.http;
using back.domain.DTO.VersaoProjetos;

namespace back.domain.Repositories
{
    public interface IVersaoProjetosRepository
    {
        public Task<Response<List<VersaoProjetosDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<VersaoProjetosDTO> GetById(int id);
        public Task<bool> Create(VersaoProjetos VersaoProjetos);
        public Task<bool> Delete(int id);
        public Task<bool> Update(VersaoProjetos VersaoProjetos);
    }
}