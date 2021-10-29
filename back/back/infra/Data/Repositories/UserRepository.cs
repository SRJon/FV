using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.User;
using back.domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbAppContext _ctx;


        public UserRepository(DbAppContext ctx)
        {
            _ctx = ctx;

        }

        public Task<bool> Create(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Usuario>> GetAllAsync()
        {
            return await _ctx.Usuario.ToListAsync();
        }

        public Task<Usuario> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}