using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.TSIEnderecoDTO;

namespace back.domain.Repositories
{
    public interface ITSIENDRepository
    {
        public Task<TSIENDDTO> GetById(int id);
        public Task<Response<List<TSIENDDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<bool> Create(TSIENDDTOCreate tela);
    }
}