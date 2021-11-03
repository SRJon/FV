using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Login;
using back.data.entities.User;
using back.data.http;

namespace back.domain.Repositories
{
    public interface IUserRepository
    {
        public Task<Response<List<Usuario>>> GetAllPaginateAsync(int page, int limit);
        public Task<Usuario> GetById(int id);
        public Task<bool> Create(Usuario usuario);
        public Task<bool> Update(Usuario usuario);
        public Task<bool> Delete(int id);

        public Usuario GetByIdAsync(int id);
        public bool ProductExists(int id);
        public decimal UserValidation(LoginEntity user);

    }
}