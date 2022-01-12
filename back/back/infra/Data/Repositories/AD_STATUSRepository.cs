using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_STATUS;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_STATUSServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AD_STATUSRepository : ValidPagination, IAD_STATUSRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_STATUSRepository(DbContexts ctxs)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }
        /// <summary>
        /// Função que retorna todos os Status da tabela AD_STATUS do sankhya
        /// </summary>
        /// <param name="page">pagina atual</param>
        /// <param name="limit">limite de itens por pagina</param>
        /// <returns>Lista de AD_STATUS</returns>
        public async Task<Response<List<AD_STATUSDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<AD_STATUSDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearchesConsulta = contexto.AD_STATUS.Take(int.MaxValue);

                List<AD_STATUSDTO> dTOs = new List<AD_STATUSDTO>();

                var savedSearches = savedSearchesConsulta.Skip(base.skip).OrderBy(o => o.Nunota).Take(base.limit);
                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<AD_STATUSDTO>(e)));

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
        /// <summary>
        /// Função que retorna o status via NuNota
        /// </summary>
        /// <param name="NuNota">NuNota a ser buscado</param>
        /// <returns>STATUS</returns>
        public async Task<AD_STATUSDTO> GetByNuNota(int NuNota)
        {
            return _mapper.Map<AD_STATUSDTO>(await this._ctxs.
            GetSankhya()
            .GetByNuNotaService(NuNota));
        }
        /// <summary>
        /// Função que busca STATUS via NuNota
        /// Se a nota já estiver Faturada (FAT) retorna true;Se não retorna false
        /// </summary>
        /// <param name="NuNota">NuNota a ser buscada</param>
        /// <returns>bool</returns>
        public async Task<bool> GetFaturado(int NuNota)
        {
            bool faturado = false;
            var status = _mapper.Map<AD_STATUSDTO>(await this._ctxs.
            GetSankhya()
            .GetByNuNotaService(NuNota));
            if (status.StatusLit == "FAT" || status.StatusLit == "CA")
                faturado = true;
            else
                faturado = false;
            return faturado;
        }
    }
}