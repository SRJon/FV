using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_GERAL_PVDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_GERAL_PVServices;
using back.MappingConfig;

namespace back.infra.Data.Repositories
{
    public class AD_GERAL_PVRepository : ValidPagination, IAD_GERAL_PVRepository 
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;
        public AD_GERAL_PVRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<AD_GERAL_PVDTO> GetByNunota(int Nunota)
        {
            return _mapper.Map<AD_GERAL_PVDTO>(await this._ctxs
                .GetSankhya()
                .GetByNunotaServices(Nunota));
        }
    }

}