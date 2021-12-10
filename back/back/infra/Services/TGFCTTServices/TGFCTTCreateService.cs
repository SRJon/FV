using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TGFContato;
using back.domain.DTO.TGFContatoDTO;
using back.infra.Data.Context;
using back.MappingConfig;

namespace back.infra.Services.TGFCTTServices
{
    public static class TGFCTTCreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        public static Task<bool> Create(this DbAppContextSankhya ctx, TGFCTTDTOCreate comprador)
        {
            ctx.TGFCTT.Add(_mapper.Map<TGFCTT>(comprador));
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }


    }
}