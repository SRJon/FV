using System.Collections.Generic;
using back.data.entities;

namespace back.domain.Repositories
{
    public interface IUsuarioRepository
    {
        public List<Usuario> GetAll();
        public Usuario GetById(int id);
        public bool Create(Usuario usuario);
        public bool Update(Usuario usuario);
        public bool Delete(int id);

    }
}