using AutoMapper;
using back.data.http;
using back.domain.DTO.TSIEmpDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TSIEMPServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class TSIEMPRepository : ValidPagination, ITSIEMPRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TSIEMPRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }
        public async Task<Response<List<TSIEMPDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<TSIEMPDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.TSIEMP.Skip(base.skip).OrderBy(o => o.codemp).Take(base.limit);
                List<TSIEMPDTO> dTOs = new List<TSIEMPDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<TSIEMPDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.TSIEMP.CountAsync();
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

        public async Task<TSIEMPDTO> GetByCODEMP(int CODEMP)
        {
            var res = await this._ctxs.GetSankhya().GetByCODEMPService(CODEMP);
            var rmapper = _mapper.Map<TSIEMPDTO>(res);

            return rmapper;
        }
    }
}

