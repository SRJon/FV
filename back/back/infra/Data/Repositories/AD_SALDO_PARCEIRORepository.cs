using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.View_AD_SALDO_PARCEIRO;
using back.domain.DTO.ViewAD_SALDO_PARCEIRODTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_SALDO_PARCEIROServices;
using back.MappingConfig;

namespace back.infra.Data.Repositories
{
    public class AD_SALDO_PARCEIRORepository : IAD_SALDO_PARCEIRORepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_SALDO_PARCEIRORepository(IMapper mapper, DbContexts ctxs)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<AD_SALDO_PARCEIRODTO> GetById(int codParc)
        {
            var result = await this._ctxs.
            GetSankhya()
            .GetByIdService(codParc);

            return _mapper.Map<AD_SALDO_PARCEIRODTO>(result);
        }
    }
}