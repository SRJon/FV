using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TGFTPVenda;
using back.domain.DTO.TGFTPVendaDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TGFTPVServices;
using back.MappingConfig;

namespace back.infra.Data.Repositories
{
    public class TGFTPVRepository : ITGFTPVRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TGFTPVRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<TGFTPVDTO> GetByCODTIPVENDA(int CODTIPVENDA, DateTime DHALTER)
        {

            var res = await this._ctxs.GetSankhya().GetByIdService(CODTIPVENDA, DHALTER);
            var rmapper = _mapper.Map<TGFTPVDTO>(res);
            return rmapper;
        }
    }
}