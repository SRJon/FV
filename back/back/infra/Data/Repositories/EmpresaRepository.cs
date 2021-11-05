using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.Empresa;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.EmpresaServices;
using back.MappingConfig;

namespace back.infra.Data.Repositories
{
    public class EmpresaRepository : ValidPagination, IEmpresaRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public EmpresaRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public Task<Response<List<Empresa>>> GetAllPaginateAsync(int page, int limit)
        {
            throw new System.NotImplementedException();
        }

        public async Task<EmpresaDTO> GetById(int id)
        {
            return _mapper.Map<EmpresaDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }
    }
}