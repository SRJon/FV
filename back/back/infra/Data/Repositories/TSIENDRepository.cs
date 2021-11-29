using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.SintegraCNPJQuery;
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

        public TSIENDDTO AtribuicaoValoresCliente(TSIENDDTO endereco, SintegraCNPJ cnpj)
        {
            endereco.Tipo = cnpj.Logradouro.Substring(0, cnpj.Logradouro.IndexOf(" "));
            endereco.Nomeend = cnpj.Logradouro.Substring(cnpj.Logradouro.IndexOf(" ") + 1);
            endereco.Dtalter = System.DateTime.Now;
            return endereco;
        }

        public Task<bool> Create(TSIENDDTO tsiend)
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

        //TODO DELETE ENDEREÇO
        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
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

        public async Task<TSIENDDTO> GetByNome(string nomeEnd)
        {
            var res = await this._ctxs.GetSankhya().GetByNomeEndService(nomeEnd);
            var rmapper = _mapper.Map<TSIENDDTO>(res);
            return rmapper;
        }

        //TODO UPDATE ENDERECO
        public Task<bool> Update(TSIENDDTOUpdateDTO tsiend)
        {
            throw new System.NotImplementedException();
        }
    }
}