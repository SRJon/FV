using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.ViewAD_SALDO_PARCEIRODTO;

namespace back.data.entities.View_AD_SALDO_PARCEIRO
{
    public static class AD_SALDO_PARCEIROMapper
    {
        public static IMapperConfigurationExpression CreateAD_SALDO_PARCEIROMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_SALDO_PARCEIRO, AD_SALDO_PARCEIRODTO>();
            cfg.CreateMap<AD_SALDO_PARCEIRODTO, AD_SALDO_PARCEIRO>();

            return cfg;
        }
    }
}