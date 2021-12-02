using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.UserEmp;
using back.data.http;
using back.domain.DTO.UserEmp;

namespace back.domain.Repositories
{
    public interface IUsuarioEmpRepository
    {
        public Task<Response<List<UsuarioEmpDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<UsuarioEmpDTO> GetById(int id);
        public Task<bool> Create(UsuarioEmp UsuarioEmp);
        public Task<bool> Delete(int id);
        public Task<bool> Update(UsuarioEmp UsuarioEmp);
    }
}