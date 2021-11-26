using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.TSIEnderecoDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TSIENDServices;
using back.MappingConfig;

namespace back.infra.Data.Repositories
{
    public class TSIENDRepository : ITSIENDRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TSIENDRepository(IMapper mapper, DbContexts ctxs)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        //TODO CREATE ENDERECO
        public Task<bool> Create(TSIENDDTOCreate tsiend)
        {
            try
            {
                return _ctxs.GetSankhya().Create(tsiend);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        //TODO GET ALL ENDERECO
        public Task<Response<List<TSIENDDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TSIENDDTO> GetById(int id)
        {
            var res = await this._ctxs.GetSankhya().GetByIdService(id);
            var rmapper = _mapper.Map<TSIENDDTO>(res);
            return rmapper;
        }
    }
}