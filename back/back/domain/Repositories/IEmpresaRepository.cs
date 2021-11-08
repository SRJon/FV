using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.Empresa;

namespace back.domain.Repositories
{
    public interface IEmpresaRepository
    {
        public Task<Response<List<EmpresaDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<EmpresaDTO> GetById(int id);
        public Task<bool> Create(Empresa empresa);
        public Task<bool> Delete(int id);
        public Task<bool> Update(Empresa empresa);
    }
}