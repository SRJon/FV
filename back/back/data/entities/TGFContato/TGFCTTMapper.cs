using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.TGFContatoDTO;

namespace back.data.entities.TGFContato
{
    public static class TGFCTTMapper
    {
        public static IMapperConfigurationExpression CreateTGFCTTMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TGFCTT, TGFCTTDTO>();
            cfg.CreateMap<TGFCTTDTO, TGFCTT>();

            cfg.CreateMap<TGFCTT, TGFCTTDTOCreate>();
            cfg.CreateMap<TGFCTTDTOCreate, TGFCTT>();
            return cfg;
        }
    }
}