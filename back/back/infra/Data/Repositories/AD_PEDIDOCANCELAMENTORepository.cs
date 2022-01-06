using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_PEDIDOCANCELAMENTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_PEDIDOCANCELAMENTOServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AD_PEDIDOCANCELAMENTORepository : ValidPagination, IAD_PEDIDOCANCELAMENTORepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_PEDIDOCANCELAMENTORepository(DbContexts ctxs)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<AD_PEDIDOCANCELAMENTODTO>>> GetAllPaginateAsync(short codVend, string pesquisa, int page, int limit)
        {
            var response = new Response<List<AD_PEDIDOCANCELAMENTODTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                //pesquisa por notaNumNota(int), nomeparc(string), vlrpedido(double) e adStatus(string), todos no mesmo campo do front.
                base.ValidPaginate(page, limit);
                var savedSearchesConsulta = contexto.AD_PEDIDOCANCELAMENTO.Where(p => p.Codvend == codVend).Take(int.MaxValue);
                if (pesquisa != null) savedSearchesConsulta = savedSearchesConsulta.Where(p => p.Status_ped.ToLower().Contains(pesquisa.ToLower()) ||
                                                                           p.PedVlrPedido.ToString().Contains(pesquisa) ||
                                                                           p.Nota_NumNota.ToString().Contains(pesquisa) ||
                                                                           p.PedNomeParc.ToLower().Contains(pesquisa.ToLower())).Take(int.MaxValue);

                List<AD_PEDIDOCANCELAMENTODTO> dTOs = new List<AD_PEDIDOCANCELAMENTODTO>();

                var savedSearches = savedSearchesConsulta.Skip(base.skip).OrderBy(o => o.Pedad_PedidoId).Take(base.limit);
                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<AD_PEDIDOCANCELAMENTODTO>(e)));

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

        public async Task<AD_PEDIDOCANCELAMENTODTO> GetByNumNota(int numNota)
        {
            return _mapper.Map<AD_PEDIDOCANCELAMENTODTO>(await this._ctxs.
            GetSankhya()
            .GetByNuNotaService(numNota));
        }
    }
}