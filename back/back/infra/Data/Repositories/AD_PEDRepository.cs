using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.View_AD_PED;
using back.data.http;
using back.domain.DTO.View_AD_PEDDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_PEDServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AD_PEDRepository : ValidPagination, IAD_PEDRepository
    {//TODO AD_PEDREPOSITORY
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_PEDRepository(DbContexts ctxs)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<AD_PEDPedidoDTO>>> GetAllPaginateAsync(short codvend, string pesquisa, int page, int limit)
        {
            var response = new Response<List<AD_PEDPedidoDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                //pesquisa por notaNumNota(int), nomeparc(string), vlrpedido(double) e adStatus(string), todos no mesmo campo do front.
                base.ValidPaginate(page, limit);
                var savedSearchesConsulta = contexto.AD_PED.Where(p => p.codvend == codvend).Take(int.MaxValue);
                if (pesquisa != null) savedSearchesConsulta = savedSearchesConsulta.Where(p => p.statusPed.ToLower().Contains(pesquisa.ToLower()) ||
                                                                           p.vlrpedido.ToString().Contains(pesquisa) ||
                                                                           p.notaNumnota.ToString().Contains(pesquisa) ||
                                                                           p.nomeparc.ToLower().Contains(pesquisa.ToLower())).Take(int.MaxValue);

                List<AD_PEDPedidoDTO> dTOs = new List<AD_PEDPedidoDTO>();

                var savedSearches = savedSearchesConsulta.Skip(base.skip).OrderBy(o => o.adPedidoid).Take(base.limit);
                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<AD_PEDPedidoDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await savedSearchesConsulta.CountAsync();
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

        public async Task<AD_PEDDTO> GetByNomeParc(string nomeParc)
        {
            return _mapper.Map<AD_PEDDTO>(await this._ctxs.
            GetSankhya()
            .GetByNomeService(nomeParc));
        }

        public async Task<AD_PEDDTO> GetByNumNota(int numNota)
        {
            return _mapper.Map<AD_PEDDTO>(await this._ctxs.
            GetSankhya()
            .GetByNFService(numNota));
        }
        public async Task<AD_PEDDTO> GetByPedidoId(int pedidoId)
        {
            return _mapper.Map<AD_PEDDTO>(await this._ctxs.
            GetSankhya()
            .GetByPedidoIdService(pedidoId));
        }

        public async Task<AD_PEDDTO> GetBySituacao(string status)
        {
            return _mapper.Map<AD_PEDDTO>(await this._ctxs.
            GetSankhya()
            .GetBySituacaoService(status));
        }

        public async Task<AD_PEDDTO> GetByValor(double valor)
        {
            return _mapper.Map<AD_PEDDTO>(await this._ctxs.
             GetSankhya()
             .GetByValorService(valor));
        }
    }
}