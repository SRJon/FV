using AutoMapper;
using back.data.http;
using back.domain.DTO.TGFIPI;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TGFIPIServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class TGFIPIRepository : ValidPagination, ITGFIPIRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TGFIPIRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }
        public async Task<Response<List<TGFIPIDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<TGFIPIDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.TGFIPI.Skip(base.skip).OrderBy(o => o.CodIpi).Take(base.limit);
                List<TGFIPIDTO> dTOs = new List<TGFIPIDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<TGFIPIDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.TGFIPI.CountAsync();
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

        public async Task<TGFIPIDTO> GetByCodIpi(int CodIpi)
        {
            var res = await this._ctxs.GetSankhya().GetByCodIpiService(CodIpi);
            var rmapper = _mapper.Map<TGFIPIDTO>(res);

            return rmapper;
        }
    }
}
