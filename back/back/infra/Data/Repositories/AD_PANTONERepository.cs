using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_PANTONE;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_PANTONEServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class AD_PANTONERepository : ValidPagination, IAD_PANTONERepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_PANTONERepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<AD_PANTONEDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<AD_PANTONEDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AD_PANTONE.Skip(base.skip).OrderBy(o => o.CodCor).Take(base.limit);
                List<AD_PANTONEDTO> dTOs = new List<AD_PANTONEDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<AD_PANTONEDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.AD_PANTONE.CountAsync();
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

        public async Task<AD_PANTONEDTO> GetByCodCor(int CodCor)
        {
            var res = await this._ctxs.GetSankhya().GetByCodCorService(CodCor);
            var rmapper = _mapper.Map<AD_PANTONEDTO>(res);

            return rmapper;
        }
    }
}
