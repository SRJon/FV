using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_EXTRA_PVDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_EXTRA_PVServices;
using back.MappingConfig;

namespace back.infra.Data.Repositories
{
    public class AD_EXTRA_PVRepository : ValidPagination, IAD_EXTRA_PVRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_EXTRA_PVRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<AD_EXTRA_PVDTO> GetByNunota(int Nunota)
        {
            return _mapper.Map<AD_EXTRA_PVDTO>(await this._ctxs
                .GetSankhya()
                .GetByNunotaServices(Nunota));
        }
    }
}