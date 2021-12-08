using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.SintegraCNPJQuery;
using back.data.entities.TGFParceiro;
using back.data.http;
using back.domain.DTO.TGFParceiroDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TGFPARServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class TGFPARRepository : ValidPagination, ITGFPARRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TGFPARRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }
        public async Task<Response<List<TGFPARDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<TGFPARDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.TGFPAR.Skip(base.skip).OrderBy(o => o.Codparc).Take(base.limit);
                List<TGFPARDTO> dTOs = new List<TGFPARDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<TGFPARDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.TGFPAR.CountAsync();
                response.Page = page;
                response.TotalPages = base.getTotalPages(response.TotalPages);
                response.Success = true;
                response.StatusCode = 200;
                return response;

            }
            catch (System.Exception e)
            {

                response.StatusCode = 400;
                response.Message = e.Message;
                return response;
            }

        }

        public async Task<TGFPARDTO> GetByCgc_cpf(string cgc_cpf)
        {
            var res = await this._ctxs.GetSankhya().GetByCNPJService(cgc_cpf);
            var rmapper = _mapper.Map<TGFPARDTO>(res);
            return rmapper;
        }

        public async Task<TGFPARDTO> GetById(int id)
        {
            var res = await this._ctxs.GetSankhya().GetByIdService(id);
            var rmapper = _mapper.Map<TGFPARDTO>(res);

            return rmapper;
        }

        public Task<bool> Create(TGFPARDTOCreate cliente)
        {
            try
            {
                return _ctxs.GetSankhya().Create(cliente);
            }
            catch (Exception)
            {

            }
            return null;
        }

        public TGFPARDTO AtribuicaoValoresCliente(TGFPARDTO cliente, SintegraCNPJ cnpj)
        {
            cliente.Codparcmatriz = cliente.Codparc;
            cliente.Razaosocial = cnpj.Nome;
            cliente.Nomeparc = cnpj.Nome;
            cliente.Tippessoa = 'J';
            cliente.Numend = cnpj.Numero.ToString();
            cliente.Complemento = cnpj.Complemento;
            cliente.Telefone = cnpj.Telefone;
            cliente.Email = cnpj.Email;
            cliente.Cep = cnpj.Cep;
            cliente.Socios = new List<string>();
            foreach (var socio in cnpj.Qsa)
            {
                cliente.Socios.Add(socio.Nome);
            }

            cliente.Cgc_cpf = cnpj.Cnpj;

            return cliente;
        }

        public int GetLastIdCreated()
        {
            return this._ctxs.GetSankhya().GetLastIdCreated();
        }
    }
}