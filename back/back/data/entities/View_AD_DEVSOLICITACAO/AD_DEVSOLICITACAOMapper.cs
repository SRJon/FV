using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.View_AD_DEVSOLICITACAODTO;

namespace back.data.entities.View_AD_DEVSOLICITACAO
{
    public static class AD_DEVSOLICITACAOMapper
    {
        public static IMapperConfigurationExpression CreateAD_DEVSOLICITACAOMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_DEVSOLICITACAO, AD_DEVSOLICITACAODTO>();
            cfg.CreateMap<AD_DEVSOLICITACAODTO, AD_DEVSOLICITACAO>();

            cfg.CreateMap<AD_DEVSOLICITACAO, AD_DEVSOLICITACAODTODevolucao>();
            cfg.CreateMap<AD_DEVSOLICITACAODTODevolucao, AD_DEVSOLICITACAO>();

            cfg.CreateMap<AD_DEVSOLICITACAO, AD_DEVSOLICITACAOSACDTO>();
            cfg.CreateMap<AD_DEVSOLICITACAOSACDTO, AD_DEVSOLICITACAO>();
            cfg.CreateMap<AD_DEVSOLICITACAODTO, AD_DEVSOLICITACAOSACDTO>();
            cfg.CreateMap<AD_DEVSOLICITACAOSACDTO, AD_DEVSOLICITACAODTO>();

            return cfg;
        }

    }
}