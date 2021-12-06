using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.VIEW_AD_VGFRPV;
using back.data.http;
using back.domain.DTO.AD_VGFRPVDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_VGFRPVServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AD_VGFRPVRepository : ValidPagination, IAD_VGFRPVRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_VGFRPVRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }



        public async Task<Response<List<AD_VGFRPVSaldoDTO>>> GetAllPaginateAsync(int page, int limit, int codVendedor)
        {
            var response = new Response<List<AD_VGFRPVSaldoDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AD_VGFRPV.Where(u => u.Codvend == codVendedor);
                // .Skip(base.skip).Take(base.limit);
                List<AD_VGFRPVSaldoDTO> dTOs = new List<AD_VGFRPVSaldoDTO>();

                var AD_VGFRPV = await savedSearches.Skip(base.skip).Take(base.limit).ToListAsync();
                AD_VGFRPV.ForEach(e => dTOs.Add(_mapper.Map<AD_VGFRPVSaldoDTO>(e)));
                response.Data = dTOs;
                response.TotalPages = await savedSearches.CountAsync();
                response.Page = page;
                response.TotalPages = base.getTotalPages(response.TotalPages);
                response.Success = true;
                response.StatusCode = 200;
                return response;

            }
            catch (System.Exception e)
            {
                response.Data = null;
                response.Message = e.Message;
                response.StatusCode = 400;
                return response;
            }
        }

        public async Task<AD_VGFRPVDTO> GetById(Int16 codVend)
        {
            return _mapper.Map<AD_VGFRPVDTO>(await this._ctxs.
            GetSankhya()
            .GetByIdService(codVend));
        }

        public async Task<AD_VGFRPVDTO> GetById(int codParc)
        {
            return _mapper.Map<AD_VGFRPVDTO>(await this._ctxs
                .GetSankhya()
                .GetByIdService(codParc));
        }
    }
}