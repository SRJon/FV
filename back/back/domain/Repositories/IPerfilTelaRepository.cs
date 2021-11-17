using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.ProfileScreen;
using back.data.http;
using back.domain.DTO.ProfileScreenDTO;

namespace back.domain.Repositories
{
    public interface IPerfilTelaRepository
    {
        public Task<PerfilTelaDTO> GetById(int id);
        public PerfilTelaDTO GetByIdAsync(int id);
        public Task<bool> Create(PerfilTelaDTOCreate perfilTela);
        public Task<bool> Delete(int id);
        public Task<bool> Update(PerfilTela perfilTela);
        public Task<Response<List<PerfilTelaDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<Response<List<PerfilTelaDTO>>> GetByUsuarioId(int userId);
    }
}