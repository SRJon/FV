using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Screen;
using back.data.http;

namespace back.domain.Repositories
{
    public interface ITelaRepository
    {
        public Task<Response<List<Tela>>> GetAllPaginateAsync(int page, int limit);
        public Task<List<Tela>> GetAll(int page, int limit);
        public Task<Tela> GetById(int id);
        public Task<bool> Create(Tela tela);
        public Task<bool> Update(Tela tela);
        public Task<bool> Delete(int id);

        public Tela GetByIdAsync(int id);
        public bool ProductExists(int id);
    }
}