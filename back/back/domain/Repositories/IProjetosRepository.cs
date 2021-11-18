using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Projetos;
using back.data.http;
using back.domain.DTO.Projetos;

namespace back.domain.Repositories
{
    public interface IProjetosRepository
    {
        public Task<Response<List<ProjetosDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<ProjetosDTO> GetById(int id);
        public Task<bool> Create(Projetos Projetos);
        public Task<bool> Delete(int id);
        public Task<bool> Update(Projetos Projetos);
    }
}