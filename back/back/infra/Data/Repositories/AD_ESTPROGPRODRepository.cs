using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_ESTPROGPROD;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_ESTPROGPRODServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class AD_ESTPROGPRODRepository : ValidPagination, IAD_ESTPROGPRODRepository
    {

        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_ESTPROGPRODRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<AD_ESTPROGPRODDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<AD_ESTPROGPRODDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AD_ESTPROGPROD.Skip(base.skip).OrderBy(o => o.CodEmp).Take(base.limit);
                List<AD_ESTPROGPRODDTO> dTOs = new List<AD_ESTPROGPRODDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<AD_ESTPROGPRODDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.AD_ESTPROGPROD.CountAsync();
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

        public async Task<AD_ESTPROGPRODDTO> GetByCodEmp(int CodEmp)
        {
            var res = await this._ctxs.GetSankhya().GetByCodEmpService(CodEmp);
            var rmapper = _mapper.Map<AD_ESTPROGPRODDTO>(res);

            return rmapper;
        }
    }
}
