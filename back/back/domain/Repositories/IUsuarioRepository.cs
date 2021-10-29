using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.User;

namespace back.domain.Repositories
{
    public interface IUserRepository
    {
        public Task<List<Usuario>> GetAllAsync();
        public Task<Usuario> GetById(int id);
        public Task<bool> Create(Usuario usuario);
        public Task<bool> Update(Usuario usuario);
        public Task<bool> Delete(int id);

    }
}