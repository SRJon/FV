using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.ViewAD_FINCOMDTO;

namespace back.data.entities.ViewAD_FINCOM
{
    public static class AD_FINCOMMapper
    {
        public static IMapperConfigurationExpression CreateAD_FINCOMMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_FINCOM, AD_FINCOMDTO>();
            cfg.CreateMap<AD_FINCOM, AD_FINCOMDTO>();

            return cfg;
        }

    }
}