using AutoMapper;
using back.data.http;
using back.domain.DTO.TGFProdutoDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TGFPROServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class TGFPRORepository : ValidPagination, ITGFPRORepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TGFPRORepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<TGFPRODTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<TGFPRODTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.TGFPRO.Skip(base.skip).OrderBy(o => o.codprod).Take(base.limit);
                List<TGFPRODTO> dTOs = new List<TGFPRODTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<TGFPRODTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.TGFPRO.CountAsync();
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

        public async Task<TGFPRODTO> GetByCodProd(int CodProd)
        {
            var res = await this._ctxs.GetSankhya().GetByCodProdService(CodProd);
            var rmapper = _mapper.Map<TGFPRODTO>(res);

            return rmapper;
        }
    }
}
