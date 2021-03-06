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
        public Task<PerfilDTONome> GetNameById(int id);
        public PerfilDTO GetByIdAsync(int id);
        public Task<bool> Create(PerfilDTOCreate perfil);
        public Task<bool> Delete(int id);
        public Task<bool> Update(PerfilDTOUpdateDTO perfil);
        public Task<Response<List<PerfilDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<Response<List<PerfilDTONome>>> GetAllNamesPaginateAsync(int page, int limit);
    }
}