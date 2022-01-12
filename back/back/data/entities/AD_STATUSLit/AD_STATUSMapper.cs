using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.AD_STATUS;

namespace back.data.entities.AD_STATUSLit
{
    public static class AD_STATUSMapper
    {
        public static IMapperConfigurationExpression CreateAD_STATUSMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_STATUS, AD_STATUSDTO>();
            cfg.CreateMap<AD_STATUSDTO, AD_STATUS>();

            return cfg;
        }
    }
}