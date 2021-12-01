using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TSICidade;
using back.domain.DTO.TSICidadeDTO;
using back.infra.Data.Context;
using back.MappingConfig;

namespace back.infra.Services.TSICIDServices
{
    public static class TSICIDCreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        public static Task<bool> Create(this DbAppContextSankhya ctx, TSICIDDTO tsicid)
        {
            var lastId = ctx.TSICID.FirstOrDefault(p => p.CodCid == (ctx.TSICID.Max(x => x.CodCid)));
            tsicid.CodCid = lastId.CodCid + 1;
            ctx.TSICID.Add(_mapper.Map<TSICID>(tsicid));
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }
    }
}