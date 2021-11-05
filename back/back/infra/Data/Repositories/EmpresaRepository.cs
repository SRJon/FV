using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.Repositories;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class EmpresaRepository : ValidPagination, IEmpresaRepository
    {
        private readonly DbContexts _ctxs;

        public EmpresaRepository(DbContexts ctxs) : base()
        {
            _ctxs = ctxs;

        }

        public Task<Response<List<Empresa>>> GetAllPaginateAsync(int page, int limit)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Empresa> GetById(int id)
        {
            return await this._ctxs.GetVFU().Empresa.FirstOrDefaultAsync(x => x.Id == (decimal)id);
        }
    }
}