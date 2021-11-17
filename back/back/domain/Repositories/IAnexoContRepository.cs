using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.AnexoCont;
using back.data.http;
using back.domain.DTO.AnexoCont;

namespace back.domain.Repositories
{
    public interface IAnexoContRepository
    {
        public Task<Response<List<AnexoContDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<AnexoContDTO> GetById(int id);
        public Task<bool> Create(AnexoCont AnexoCont);
        public Task<bool> Delete(int id);
        public Task<bool> Update(AnexoCont AnexoCont);
    }
}