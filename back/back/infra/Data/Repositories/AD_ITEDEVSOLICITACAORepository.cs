using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_ItemDEVSOLICITACAO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_ITEDEVSOLICITACAOServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AD_ITEDEVSOLICITACAORepository : ValidPagination, IAD_ITEDEVSOLICITACAORepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_ITEDEVSOLICITACAORepository(DbContexts ctxs)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<AD_ITEDEVSOLICITACAODTO> GetDevolucaoByNuSoldev(int nuSoldev)
        {
            var res = await this._ctxs.GetSankhya().GetDevolucaoByNuDev(nuSoldev);
            var rmapper = _mapper.Map<AD_ITEDEVSOLICITACAODTO>(res);

            return rmapper;
        }
        public async Task<List<AD_ITEDEVSOLICITACAODTO>> GetAllIteDevolucaoSac(int nuSolDev)
        {
            var contexto = _ctxs.GetSankhya();
            try
            {
                var savedSearches = contexto.AD_ITEDEVSOLICITACAO
                                                    .Where(u => u.nusoldev == nuSolDev)
                                                    .OrderBy(u => u.sequencia);

                List<AD_ITEDEVSOLICITACAODTO> dTOs = new List<AD_ITEDEVSOLICITACAODTO>();

                var notas = await savedSearches.ToListAsync();
                notas.ForEach(e => dTOs.Add(_mapper.Map<AD_ITEDEVSOLICITACAODTO>(e)));
                return dTOs;

            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}