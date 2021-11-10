using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Profile;
using back.data.http;
using back.domain.DTO.ProfileDTO;

namespace back.domain.Repositories
{
    public interface IPerfilRepository
    {
        public Task<PerfilDTO> GetById(int id);
        public PerfilDTO GetByIdAsync(int id);
        public Task<bool> Create(Perfil perfil);
        public Task<bool> Delete(int id);
        public Task<bool> Update(Perfil perfil);
        public Task<Response<List<PerfilDTO>>> GetAllPaginateAsync(int page, int limit);
    }
}