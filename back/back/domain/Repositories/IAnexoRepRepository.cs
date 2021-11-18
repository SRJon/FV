using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.AnexoRep;
using back.data.http;
using back.domain.DTO.AnexoRep;

namespace back.domain.Repositories
{
    public interface IAnexoRepRepository
    {
        public Task<Response<List<AnexoRepDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<AnexoRepDTO> GetById(int id);
        public Task<bool> Create(AnexoRep AnexoRep);
        public Task<bool> Delete(int id);
        public Task<bool> Update(AnexoRep AnexoRep);
    }
}