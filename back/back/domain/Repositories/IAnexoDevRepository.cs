using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.AnexoDev;
using back.data.http;
using back.domain.DTO.AnexoDev;

namespace back.domain.Repositories
{
    public interface IAnexoDevRepository
    {
        public Task<Response<List<AnexoDevDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<AnexoDevDTO> GetById(int id);
        public Task<bool> Create(AnexoDev AnexoDev);
        public Task<bool> Delete(int id);
        public Task<bool> Update(AnexoDev AnexoDev);
    }
}