using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.SintegraCNPJQuery;
using back.data.entities.TSIBairro;
using back.domain.DTO.TSIBairroDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TSIBAIServices;
using back.MappingConfig;

namespace back.infra.Data.Repositories
{
    public class TSIBAIRepository : ITSIBAIRepository

    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TSIBAIRepository(DbContexts ctxs)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public TSIBAIDTO AtribuicaoValoresCliente(TSIBAIDTO endereco, SintegraCNPJ cnpj)
        {
            endereco.NomeBai = cnpj.Bairro;
            endereco.Codreg = 0;
            endereco.Dtalter = System.DateTime.Now;
            return endereco;
        }

        public Task<bool> Create(TSIBAIDTOCreate tsibai)
        {
            try
            {
                return _ctxs.GetSankhya().Create(tsibai);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public async Task<TSIBAIDTO> GetById(int id)
        {
            var res = await this._ctxs.GetSankhya().GetByIdService(id);
            var rmapper = _mapper.Map<TSIBAIDTO>(res);
            return rmapper;
        }
        public async Task<TSIBAIDTO> GetByNome(string nomeEnd)
        {
            var res = await this._ctxs.GetSankhya().GetByNomeBaiService(nomeEnd);
            var rmapper = _mapper.Map<TSIBAIDTO>(res);
            return rmapper;
        }
    }
}