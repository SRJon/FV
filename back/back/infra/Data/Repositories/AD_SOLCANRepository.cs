using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.AD_SOLCANota;
using back.data.http;
using back.domain.DTO.AD_SOLCAN;
using back.domain.DTO.AD_STATUS;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_SOLCANServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AD_SOLCANRepository : ValidPagination, IAD_SOLCANRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_SOLCANRepository(IMapper mapper, DbContexts ctxs)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<AD_SOLCANDTO>>> GetAllPaginateAsync(int codVend, int page, int limit)
        {
            var response = new Response<List<AD_SOLCANDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {

                base.ValidPaginate(page, limit);
                var savedSearchesConsulta = contexto.AD_SOLCAN.Where(p => p.CodVend == codVend).Take(int.MaxValue);

                List<AD_SOLCANDTO> dTOs = new List<AD_SOLCANDTO>();

                var savedSearches = savedSearchesConsulta.Skip(base.skip).OrderBy(o => o.NuNota).Take(base.limit);
                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<AD_SOLCANDTO>(e)));

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

        public async Task<AD_SOLCANDTO> GetByNuNota(int NuNota)
        {
            return _mapper.Map<AD_SOLCANDTO>(await this._ctxs.
            GetSankhya()
            .GetByNuNotaService(NuNota));
        }
    }
}