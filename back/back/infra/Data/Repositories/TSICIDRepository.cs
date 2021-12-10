using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.SintegraCNPJQuery;
using back.domain.DTO.TSICidadeDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TSICIDServices;
using back.MappingConfig;

namespace back.infra.Data.Repositories
{
    public class TSICIDRepository : ITSICIDRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TSICIDRepository(DbContexts ctxs)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public TSICIDDTO AtribuicaoValoresCliente(TSICIDDTO endereco, SintegraCNPJ cnpj)
        {
            endereco.NomeCid = cnpj.Municipio;
            endereco.Dtalter = DateTime.Now;
            return endereco;
        }

        public Task<bool> Create(TSICIDDTOCreate tsicid)
        {
            try
            {
                return _ctxs.GetSankhya().Create(tsicid);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<TSICIDDTO> GetById(int id)
        {
            var res = await this._ctxs.GetSankhya().GetByIdService(id);
            var rmapper = _mapper.Map<TSICIDDTO>(res);
            return rmapper;
        }

        public async Task<TSICIDDTO> GetByNome(string nomeCid)
        {
            var res = await this._ctxs.GetSankhya().GetByNomeCidService(nomeCid);
            var rmapper = _mapper.Map<TSICIDDTO>(res);
            return rmapper;
        }
    }
}