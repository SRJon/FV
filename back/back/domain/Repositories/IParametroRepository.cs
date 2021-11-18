using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Parametro;
using back.data.http;
using back.domain.DTO.Parametro;

namespace back.domain.Repositories
{
    public interface IParametroRepository
    {
        public Task<Response<List<ParametroDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<ParametroDTO> GetById(int id);
        public Task<bool> Create(Parametro Parametro);
        public Task<bool> Delete(int id);
        public Task<bool> Update(Parametro Parametro);
    }
}