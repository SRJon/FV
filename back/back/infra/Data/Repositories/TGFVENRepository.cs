using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.TGFVEN;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TGFVENServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class TGFVENRepository : ValidPagination, ITGFVENRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TGFVENRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }
        public async Task<Response<List<TGFVENDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<TGFVENDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.TGFVEN.Skip(base.skip).OrderBy(o => o.CODVEND).Take(base.limit);
                List<TGFVENDTO> dTOs = new List<TGFVENDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<TGFVENDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.TGFVEN.CountAsync();
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

        public async Task<TGFVENDTO> GetByCODVEND(int CODVEND)
        {
            var res = await this._ctxs.GetSankhya().GetByCODVENDService(CODVEND);
            var rmapper = _mapper.Map<TGFVENDTO>(res);

            return rmapper;
        }
    }
}