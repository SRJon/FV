using AutoMapper;
using back.domain.DTO.AD_ESTPRODCOR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.data.entities.View_AD_ESTPRODCOR
{
    public static class AD_ESTPRODCORMapper
    {
        public static IMapperConfigurationExpression CreateAD_ESTPRODCORMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_ESTPRODCOR, AD_ESTPRODCORDTOUpdateDTO>();
            cfg.CreateMap<AD_ESTPRODCORDTOUpdateDTO, AD_ESTPRODCOR>();

            cfg.CreateMap<AD_ESTPRODCOR, AD_ESTPRODCORDTO>();
            cfg.CreateMap<AD_ESTPRODCORDTO, AD_ESTPRODCOR>();

            return cfg;
        }
    }
}
