using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.ViewAD_FINCOMDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_FINCOMServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AD_FINCOMRepository : ValidPagination, IAD_FINCOMRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_FINCOMRepository(DbContexts ctxs)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<AD_FINCOMDTO>>> GetAllPaginateAsync(int page, int limit, int codVendedor)
        {
            var response = new Response<List<AD_FINCOMDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AD_FINCOM.Where(u => u.codvend == codVendedor);
                List<AD_FINCOMDTO> dTOs = new List<AD_FINCOMDTO>();

                var AD_FINCOM = await savedSearches.Skip(base.skip).Take(base.limit).OrderBy(u => u.codvend).ToListAsync();
                AD_FINCOM.ForEach(e => dTOs.Add(_mapper.Map<AD_FINCOMDTO>(e)));
                response.Data = dTOs;
                response.TotalPages = await savedSearches.CountAsync();
                response.Page = page;
                response.TotalPages = base.getTotalPages(response.TotalPages);
                response.Success = true;
                response.StatusCode = 200;
                return response;

            }
            catch (System.Exception e)
            {
                response.Data = null;
                response.Message = e.Message;
                response.StatusCode = 400;
                return response;
            }
        }
        public async Task<AD_FINCOMDTO> GetById(int nuFin)
        {
            return _mapper.Map<AD_FINCOMDTO>(await this._ctxs
                .GetSankhya()
                .GetByNuFinService(nuFin));
        }
    }
}