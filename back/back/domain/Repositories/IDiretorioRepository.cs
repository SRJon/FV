using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Diretorio;
using back.data.http;
using back.domain.DTO.Diretorio;

namespace back.domain.Repositories
{
    public interface IDiretorioRepository
    {
        public Task<Response<List<DiretorioDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<DiretorioDTO> GetById(int id);
        public Task<bool> Create(Diretorio Diretorio);
        public Task<bool> Delete(int id);
        public Task<bool> Update(Diretorio Diretorio);
    }
}