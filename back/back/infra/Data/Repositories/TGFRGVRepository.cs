using AutoMapper;
using back.data.http;
using back.domain.DTO.TGFRGV;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TGFRGVServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class TGFRGVRepository : ValidPagination, ITGFRGVRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TGFRGVRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }


        public async Task<Response<List<TGFRGVDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<TGFRGVDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.TGFRGV.Skip(base.skip).OrderBy(o => o.CODGRUPOPROD).Take(base.limit);
                List<TGFRGVDTO> dTOs = new List<TGFRGVDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<TGFRGVDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.TGFRGV.CountAsync();
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

        public async Task<TGFRGVDTO> GetByCODGRUPOPROD(int CODGRUPOPROD)
        {
            var res = await this._ctxs.GetSankhya().GetByCODGRUPOPRODService(CODGRUPOPROD);
            var rmapper = _mapper.Map<TGFRGVDTO>(res);
            return rmapper;
        }

        public async Task<Response<List<TGFRGVDTO>>> GetByCODVEND(short CODVEND)
        {

            var response = new Response<List<TGFRGVDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {  
                
                // CONDIÇÕES DO SELECT UTILIZADAS NO AMBIENTE ATUAL DE PRODUÇÃO
                var savedSearches = contexto.TGFRGV.Where(o => o.CODVEND == CODVEND && o.CODGRUPOPROD  > 0 && o.CODGRUPOPROD != 960000000).Include(u=>u.TGFGRU).OrderBy(o => o.CODGRUPOPROD);
                List<TGFRGVDTO> dTOs = new List<TGFRGVDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<TGFRGVDTO>(e)));

                response.Data = dTOs;                
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
    }
}
