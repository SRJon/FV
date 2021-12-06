using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_ESTPRODCOR;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_ESTPRODCORServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class AD_ESTPRODCORRepository : ValidPagination, IAD_ESTPRODCORRepository
    {

        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_ESTPRODCORRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<AD_ESTPRODCORDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<AD_ESTPRODCORDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AD_ESTPRODCOR.Skip(base.skip).OrderBy(o => o.CodEmp).Take(base.limit);
                List<AD_ESTPRODCORDTO> dTOs = new List<AD_ESTPRODCORDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<AD_ESTPRODCORDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.AD_ESTPRODCOR.CountAsync();
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

        public async Task<AD_ESTPRODCORDTO> GetByCodEmp(int CodEmp)
        {
            var res = await this._ctxs.GetSankhya().GetByCodEmpService(CodEmp);
            var rmapper = _mapper.Map<AD_ESTPRODCORDTO>(res);

            return rmapper;
        }
    }
}