using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_TIPNEG;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_TIPNEGServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AD_TIPNEGRepository : ValidPagination, IAD_TIPNEGRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_TIPNEGRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }
        public async Task<Response<List<AD_TIPNEGDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<AD_TIPNEGDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AD_TIPNEG.Skip(base.skip).OrderBy(o => o.CodTipVenda).Take(base.limit);
                List<AD_TIPNEGDTO> dTOs = new List<AD_TIPNEGDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<AD_TIPNEGDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.AD_TIPNEG.CountAsync();
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

        public async Task<AD_TIPNEGDTO> GetByCodTipVenda(int CodTipVenda)
        {
            var res = await this._ctxs.GetSankhya().GetByCodTipVendaService(CodTipVenda);
            var rmapper = _mapper.Map<AD_TIPNEGDTO>(res);

            return rmapper;
        }

        public async Task<Response<List<AD_TIPNEGDTO>>> GetByDescrTipVendaPaginateAsync(int page, int limit, string DescrTipVenda)
        {
            var response = new Response<List<AD_TIPNEGDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AD_TIPNEG.Where(o => o.DescrTipVenda.Contains(DescrTipVenda)).Skip(skip).OrderBy(o => o.CodTipVenda).Take(base.limit);
                List<AD_TIPNEGDTO> dTOs = new List<AD_TIPNEGDTO>();

                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<AD_TIPNEGDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.AD_TIPNEG.CountAsync();
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
    }
}