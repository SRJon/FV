using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.TGFFinanceiroDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TGFFINServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class TGFFINRepository : ValidPagination, ITGFFINRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TGFFINRepository(DbContexts ctxs)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }


        public async Task<Response<List<TGFFINClienteDTO>>> GetAllFinanceiroPaginateAsync(int page, int limit, int codParc)
        {
            var response = new Response<List<TGFFINClienteDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.TGFFIN.Include(o => o.Empresa).Include(o => o.TGFCAB)
                                                   .Where(u => u.codparc == codParc && u.recdesp == 1 && u.provisao == "N" && u.dhbaixa == null)
                                                   .OrderBy(o => o.numnota);

                List<TGFFINClienteDTO> dTOs = new List<TGFFINClienteDTO>();

                var notas = await savedSearches.ToListAsync();
                notas.ForEach(e => dTOs.Add(_mapper.Map<TGFFINClienteDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.TGFFIN.CountAsync();
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

        public async Task<TGFFINClienteDTO> GetByIdFinanceiro(int nufin)
        {
            var res = await this._ctxs.GetSankhya().GetByIdFinanceiroService(nufin);

            var rmapper = _mapper.Map<TGFFINClienteDTO>(res);
            return rmapper;
        }

        public async Task<TGFFINClienteDTO> GetByIDNumnota(int numnota)
        {
            var res = await this._ctxs.GetSankhya().GetByNumNotaFinanceiroService(numnota);

            var rmapper = _mapper.Map<TGFFINClienteDTO>(res);
            return rmapper;
        }
    }
}