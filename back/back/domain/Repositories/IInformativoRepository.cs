using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Informativo;
using back.data.http;
using back.domain.DTO.Informativo;

namespace back.domain.Repositories
{
    public interface IInformativoRepository
    {
        public Task<Response<List<InformativoDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<InformativoDTO> GetById(int id);
        public Task<bool> Create(Informativo Informativo);
        public Task<bool> Delete(int id);
        public Task<bool> Update(Informativo Informativo);
    }
}