using System.Collections.Generic;
using back.data.entities;
using back.domain.Repositories;

namespace back.infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbAppContext _ctx;


        public UserRepository(DbAppContext ctx)
        {
            _ctx = ctx;

        }
        public bool Create(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Usuario GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}