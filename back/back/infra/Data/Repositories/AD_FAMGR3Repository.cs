using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_FAMGR3;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_FAMGR3Services;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class AD_FAMGR3Repository : ValidPagination, IAD_FAMGR3Repository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_FAMGR3Repository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<AD_FAMGR3DTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<AD_FAMGR3DTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AD_FAMGR3.Skip(base.skip).OrderBy(o => o.CodProdgr1).Take(base.limit);
                List<AD_FAMGR3DTO> dTOs = new List<AD_FAMGR3DTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<AD_FAMGR3DTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.AD_FAMGR3.CountAsync();
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

        public async Task<AD_FAMGR3DTO> GetByCodProdgr1(int CodProdgr1)
        {
            var res = await this._ctxs.GetSankhya().GetByCodProdgr1Service(CodProdgr1);
            var rmapper = _mapper.Map<AD_FAMGR3DTO>(res);

            return rmapper;
        }
    }
}
