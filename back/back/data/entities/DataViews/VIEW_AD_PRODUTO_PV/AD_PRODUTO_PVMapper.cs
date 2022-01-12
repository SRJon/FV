using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.AD_PRODUTO_PV;

namespace back.data.entities.DataViews.VIEW_AD_PRODUTO_PV
{
    public static class AD_PRODUTO_PVMapper
    {
        public static IMapperConfigurationExpression CreateAD_PRODUTO_PVDetailsMapper(this IMapperConfigurationExpression cfg){
            cfg.CreateMap<AD_PRODUTO_PV, AD_PRODUTO_PVDTO>();
            cfg.CreateMap<AD_PRODUTO_PVDTO, AD_PRODUTO_PV>();

            return cfg;
        }
    }
}