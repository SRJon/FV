using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.TSIBairroDTO;

namespace back.data.entities.TSIBairro
{
    public static class TSIBAIMapper
    {
        public static IMapperConfigurationExpression CreateTSIBAIMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TSIBAI, TSIBAIDTO>();
            cfg.CreateMap<TSIBAIDTO, TSIBAI>();
            return cfg;
        }

    }
}