using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TSIBairro;
using back.domain.DTO.TSIBairroDTO;
using back.infra.Data.Context;
using back.MappingConfig;

namespace back.infra.Services.TSIBAIServices
{
    public static class TSIBAICreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();

        public static Task<bool> Create(this DbAppContextSankhya ctx, TSIBAIDTO tsibai)
        {
            var lastId = ctx.TSIBAI.FirstOrDefault(p => p.CodBai == (ctx.TSIBAI.Max(x => x.CodBai)));
            tsibai.CodBai = lastId.CodBai + 1;
            ctx.TSIBAI.Add(_mapper.Map<TSIBAI>(tsibai));
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }
    }
}