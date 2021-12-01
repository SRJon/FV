using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TGFContato;
using back.domain.DTO.TGFContatoDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.MappingConfig;
using back.infra.Data.Repositories;
using back.infra.Services.TGFCTTServices;

namespace back.infra.Data.Repositories
{
    public class TGFCTTRepository : ITGFCTTRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TGFCTTRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public Task<bool> Create(TGFCTTDTOCreate comprador)
        {
            try
            {
                return _ctxs.GetSankhya().Create(comprador);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public async Task<TGFCTTDTO> GetById(int codParc, int codContato)
        {
            var res = await this._ctxs.GetSankhya().GetByIdService(codParc, codContato);
            var rmapper = _mapper.Map<TGFCTTDTO>(res);

            return rmapper;
        }

        public int GetLastIdCreated(int codParc)
        {
            return this._ctxs.GetSankhya().GetLastIdCreated(codParc);
        }
    }
}