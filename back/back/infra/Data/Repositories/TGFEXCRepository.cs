using AutoMapper;
using back.data.http;
using back.domain.DTO.TGFEXC;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TGFEXCServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class TGFEXCRepository : ValidPagination, ITGFEXCRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TGFEXCRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }
        public async Task<Response<List<TGFEXCDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<TGFEXCDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.TGFEXC.Skip(base.skip).OrderBy(o => o.NuTab).Take(base.limit);
                List<TGFEXCDTO> dTOs = new List<TGFEXCDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<TGFEXCDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.TGFEXC.CountAsync();
                response.Page = page;
                response.TotalPages = (response.TotalPages / base.limit) + 1;
                response.TotalPages = response.TotalPages == 0 ? 0 : response.TotalPages;
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

        public async Task<TGFEXCDTO> GetByNuTab(int NuTab)
        {
            var res = await this._ctxs.GetSankhya().GetByNuTabService(NuTab);
            var rmapper = _mapper.Map<TGFEXCDTO>(res);

            return rmapper;
        }
    }
}
