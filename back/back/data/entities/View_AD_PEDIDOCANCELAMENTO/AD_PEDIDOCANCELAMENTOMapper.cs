using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.AD_PEDIDOCANCELAMENTO;

namespace back.data.entities.View_AD_PEDIDOCANCELAMENTO
{
    public static class AD_PEDIDOCANCELAMENTOMapper
    {
        public static IMapperConfigurationExpression CreateAD_PEDIDOCANCELAMENTOMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_PEDIDOCANCELAMENTO, AD_PEDIDOCANCELAMENTODTO>();
            cfg.CreateMap<AD_PEDIDOCANCELAMENTODTO, AD_PEDIDOCANCELAMENTO>();

            return cfg;
        }
    }
}