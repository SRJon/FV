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
        //TODO CREATE AD_VGFRPV
        public Task<bool> Create(AD_VGFRPV AD_VGFRPV)
        {
            throw new System.NotImplementedException();
        }

        //TODO DELETE AD_VGFRPV
        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Response<List<AD_VGFRPVDTO>>> GetAllPaginateAsync(int page, int limit, int codVendedor)
        {
            var response = new Response<List<AD_VGFRPVDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AD_VGFRPV.Where(u => u.Codvend == codVendedor).Skip(base.skip).Take(base.limit);
                List<AD_VGFRPVDTO> dTOs = new List<AD_VGFRPVDTO>();

                var AD_VGFRPV = await savedSearches.ToListAsync();
                AD_VGFRPV.ForEach(e => dTOs.Add(_mapper.Map<AD_VGFRPVDTO>(e)));
                response.Data = dTOs;
                response.TotalPages = await contexto.AD_VGFRPV.CountAsync();
                response.Page = page;
                response.TotalPages = (response.TotalPages / base.limit) + 1;
                response.TotalPages = response.TotalPages == 0 ? 0 : response.TotalPages;
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

        //TODO GETBYID AD_VGFRPV
        public async Task<AD_VGFRPVDTO> GetById(Int16 codVend)
        {
            return _mapper.Map<AD_VGFRPVDTO>(await this._ctxs.
            GetSankhya()
            .GetByIdService(codVend));
        }

        //TODO UPDATE AD_VGFRPV
        public Task<bool> Update(AD_VGFRPV AD_VGFRPV)
        {
            throw new System.NotImplementedException();
        }
    }
}