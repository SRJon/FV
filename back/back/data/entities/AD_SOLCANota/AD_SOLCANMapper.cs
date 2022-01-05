using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.AD_SOLCAN;

namespace back.data.entities.AD_SOLCANota
{
    public static class AD_SOLCANMapper
    {
        public static IMapperConfigurationExpression CreateAD_SOLCANMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_SOLCAN, AD_SOLCANDTO>();
            cfg.CreateMap<AD_SOLCANDTO, AD_SOLCAN>();

            return cfg;
        }
    }
}