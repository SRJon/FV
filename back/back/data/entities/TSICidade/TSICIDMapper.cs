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
            cfg.CreateMap<TSICID, TSICIDDTO>();
            cfg.CreateMap<TSICIDDTO, TSICID>();
            cfg.CreateMap<TSICID, TSICIDDTOCreate>();
            cfg.CreateMap<TSICIDDTOCreate, TSICID>();
            cfg.CreateMap<TSICID, TSICIDSACDTO>();
            cfg.CreateMap<TSICIDSACDTO, TSICID>();
            cfg.CreateMap<TSICIDDTO, TSICIDSACDTO>();
            cfg.CreateMap<TSICIDSACDTO, TSICIDDTO>();
            return cfg;
        }
    }
}