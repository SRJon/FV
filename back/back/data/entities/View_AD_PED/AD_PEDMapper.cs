using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.View_AD_PEDDTO;

namespace back.data.entities.View_AD_PED
{
    public static class AD_PEDMapper
    {
        public static IMapperConfigurationExpression CreateAD_PEDMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_PED, AD_PEDDTO>();
            cfg.CreateMap<AD_PEDDTO, AD_PED>();

            cfg.CreateMap<AD_PED, AD_PEDPedidoDTO>();
            cfg.CreateMap<AD_PEDPedidoDTO, AD_PED>();
            cfg.CreateMap<AD_PEDDTO, AD_PEDPedidoDTO>();
            cfg.CreateMap<AD_PEDPedidoDTO, AD_PEDDTO>();

            cfg.CreateMap<AD_PED, AD_PEDFaturadoDTO>();
            cfg.CreateMap<AD_PEDFaturadoDTO, AD_PED>();
            cfg.CreateMap<AD_PEDDTO, AD_PEDFaturadoDTO>();
            cfg.CreateMap<AD_PEDFaturadoDTO, AD_PEDDTO>();

            return cfg;
        }
    }
}