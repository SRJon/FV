using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Screen;
using back.data.http;
using back.domain.DTO.ScreenDTO;

namespace back.domain.Repositories
{
    public interface ITelaRepository
    {
        public Task<Response<List<TelaDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<List<Tela>> GetAll(int page, int limit);
        public Task<TelaDTO> GetById(int id);
        public Task<bool> Create(TelaDTOCreate tela);
        public Task<bool> Update(Tela tela);
        public Task<bool> Delete(int id);

        public TelaDTO GetByIdAsync(int id);
        public bool ProductExists(int id);
    }
}