using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.TCSProjetoDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TCSPRJServices;
using back.MappingConfig;

namespace back.infra.Data.Repositories
{
    public class TCSPRJRepository : ITCSPRJRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TCSPRJRepository(DbContexts ctxs)
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<TCSPRJDTO> GetByCODTIPVENDA(int Codproj)
        {
            var res = await this._ctxs.GetSankhya().GetByIdService(Codproj);
            var rmapper = _mapper.Map<TCSPRJDTO>(res);
            return rmapper;
        }
    }
}