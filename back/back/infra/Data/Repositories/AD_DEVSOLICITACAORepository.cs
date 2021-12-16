using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.View_AD_DEVSOLICITACAODTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_DEVSOLICITACAOServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AD_DEVSOLICITACAORepository : ValidPagination, IAD_DEVSOLICITACAORepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_DEVSOLICITACAORepository(DbContexts ctxs) : base()
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<AD_DEVSOLICITACAODTODevolucao>>> GetAllDevolucaoPaginateAsync(int page, int limit, int codParc)
        {
            var response = new Response<List<AD_DEVSOLICITACAODTODevolucao>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AD_DEVSOLICITACAO.Include(o => o.TGFCAB)
                                                   .Where(u => u.CodParc == codParc)
                                                   .OrderBy(u => u.Nusoldev);

                List<AD_DEVSOLICITACAODTODevolucao> dTOs = new List<AD_DEVSOLICITACAODTODevolucao>();

                var notas = await savedSearches.ToListAsync();
                notas.ForEach(e => dTOs.Add(_mapper.Map<AD_DEVSOLICITACAODTODevolucao>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.AD_DEVSOLICITACAO.CountAsync();
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

        public async Task<AD_DEVSOLICITACAODTODevolucao> GetDevolucaoByNuSoldev(int nuSoldev)
        {
            var res = await this._ctxs.GetSankhya().GetDevolucaoByNuDev(nuSoldev);
            var rmapper = _mapper.Map<AD_DEVSOLICITACAODTODevolucao>(res);

            return rmapper;
        }
    }
}