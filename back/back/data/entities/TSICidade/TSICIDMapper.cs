using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.TSICidadeDTO;

namespace back.data.entities.TSICidade
{
    public static class TSICIDMapper
    {
        public static IMapperConfigurationExpression CreateTSICIDMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TSICID, TSICIDDTO>();
            cfg.CreateMap<TSICIDDTO, TSICID>();
            return cfg;
        }
    }
}