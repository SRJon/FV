using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_PEDIDOSDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_PEDIDOSServices;
using back.MappingConfig;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AD_PEDIDOSRepository : ValidPagination, IAD_PEDIDOSRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;


        public AD_PEDIDOSRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        // public async Task<Response<List<AD_PEDIDOSDTO>>> GetAllPaginateAsync(int page, int limit){
        //     var response = new Response<List<AD_PEDIDOSDTO>>();
        //     var contexto = _ctxs.GetSankhya();
        //     try{
        //         base.ValidPaginate(page, limit);
        //         var savedSearches = contexto.AD_PEDIDOS.Skip(base.skip).OrderBy(o => o.DtEmisssao).Take(base.limit);
        //         List<AD_PEDIDOSDTO> dTOs = new List<AD_PEDIDOSDTO>();

        //         var pedidos = await savedSearches.ToListAsync();
        //         pedidos.ForEach(e => dTOs.Add(_mapper.Map<AD_PEDIDOSDTO>(e)));
        //         response.Data = dTOs;
        //         response.TotalPages = await savedSearches.CountAsync();
        //         response.Page = page;
        //         response.TotalPages = base.getTotalPages(response.TotalPages);
        //         response.Success = true;
        //         response.StatusCode = 200;
        //         return response; 
        //     } catch (System.Exception e){
        //         response.Data = null;
        //         response.Message = e.Message;
        //         response.StatusCode = 400;
        //         return response;
        //     }
        // }
        public async Task<AD_PEDIDOSDTO> GetByNunota(int Nunota)
        {
            return _mapper.Map<AD_PEDIDOSDTO>(await this._ctxs
                .GetSankhya()
                .GetByNunotaServices(Nunota));
        }

    }
}