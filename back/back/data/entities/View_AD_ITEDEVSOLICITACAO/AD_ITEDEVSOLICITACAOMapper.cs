using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.AD_ItemDEVSOLICITACAO;

namespace back.data.entities.View_AD_ITEDEVSOLICITACAO
{
    public static class AD_ITEDEVSOLICITACAOMapper
    {
        public static IMapperConfigurationExpression CreateAD_ITEDEVSOLICITACAOMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_ITEDEVSOLICITACAO, AD_ITEDEVSOLICITACAODTO>();
            cfg.CreateMap<AD_ITEDEVSOLICITACAODTO, AD_ITEDEVSOLICITACAO>();

            return cfg;
        }

    }
}