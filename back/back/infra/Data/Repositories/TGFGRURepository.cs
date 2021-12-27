using AutoMapper;
using back.data.http;
using back.domain.DTO.TGFGrupoProduto;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TGFGRUServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class TGFGRURepository : ValidPagination, ITGFGRURepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TGFGRURepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<TGFGRUDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<TGFGRUDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.TGFGRU.Skip(base.skip).OrderBy(o => o.CODGRUPOPROD).Take(base.limit);
                List<TGFGRUDTO> dTOs = new List<TGFGRUDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<TGFGRUDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.TGFGRU.CountAsync();
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

        public async Task<TGFGRUDTO> GetByCODGRUPOPROD(int CODGRUPOPROD)
        {
            var res = await this._ctxs.GetSankhya().GetByCODGRUPOPRODService(CODGRUPOPROD);
            var rmapper = _mapper.Map<TGFGRUDTO>(res);
            return rmapper;
        }
    }
}
