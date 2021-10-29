using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.User;
using back.domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class UserRepository : ValidPagination, IUserRepository
    {
        private readonly DbAppContext _ctx;


        public UserRepository(DbAppContext ctx) : base()
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

        public async Task<List<Usuario>> GetAllAsync(int page, int limit)
        {
            base.ValidPaginate(page, limit);
            var savedSearches = _ctx.Usuario.Skip(base.skip).OrderBy(o => o.UsuarioId).Take(base.limit);//.Include(x => x.Parameters);
            System.Console.WriteLine(base.page);
            return await savedSearches.ToListAsync();
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