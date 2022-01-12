using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_PRODUTO_PV;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_PRODUTO_PVServices;
using back.MappingConfig;

namespace back.infra.Data.Repositories
{
    public class AD_PRODUTO_PVRepository : ValidPagination, IAD_PRODUTO_PVRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_PRODUTO_PVRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<AD_PRODUTO_PVDTO> GetByNunota(int Nunota)
        {
            return _mapper.Map<AD_PRODUTO_PVDTO>(await this._ctxs
            .GetSankhya()
            .GetByNunotaServices(Nunota));
        }

    }
}