using AutoMapper;
using back.data.http;
using back.domain.DTO.VGFTAB;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.VGFTABServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class VGFTABRepository : ValidPagination, IVGFTABRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public VGFTABRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<VGFTABDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<VGFTABDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.VGFTAB.Skip(base.skip).OrderBy(o => o.CodTab).Take(base.limit);
                List<VGFTABDTO> dTOs = new List<VGFTABDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<VGFTABDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.VGFTAB.CountAsync();
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

        public async Task<VGFTABDTO> GetByCodTab(int CodTab)
        {
            var res = await this._ctxs.GetSankhya().GetByCodTabService(CodTab);
            var rmapper = _mapper.Map<VGFTABDTO>(res);

            return rmapper;
        }
    }
}
