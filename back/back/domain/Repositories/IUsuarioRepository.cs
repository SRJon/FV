using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.User;
using back.data.http;

namespace back.domain.Repositories
{
    public interface IUserRepository
    {
        public Task<Response<List<Usuario>>> GetAllAsync(int page, int limit);
        public Task<Response<Usuario>> GetById(int id);
        public Task<Response<bool>> Create(Usuario usuario);
        public Task<Response<bool>> Update(Usuario usuario);
        public Task<Response<bool>> Delete(int id);

        public Response<Usuario> GetByIdAsync(int id);
        public bool ProductExists(int id);

    }
}