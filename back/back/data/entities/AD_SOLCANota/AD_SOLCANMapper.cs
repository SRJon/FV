using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.AD_SOLCAN;

namespace back.data.entities.AD_SOLCANota
{
    /// <summary>
    /// Classe responsável pela mapeamento da SOLCAN para seus DTOS
    /// </summary>
    public static class AD_SOLCANMapper
    {
        /// <summary>
        /// função que realiza o mapeamento
        /// </summary>
        /// <param name="cfg"></param>
        /// <returns>cfg</returns>
        public static IMapperConfigurationExpression CreateAD_SOLCANMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_SOLCAN, AD_SOLCANDTO>();
            cfg.CreateMap<AD_SOLCANDTO, AD_SOLCAN>();

            cfg.CreateMap<AD_SOLCAN, AD_SOLCancelamentoDTO>();
            cfg.CreateMap<AD_SOLCancelamentoDTO, AD_SOLCAN>();
            cfg.CreateMap<AD_SOLCANDTO, AD_SOLCancelamentoDTO>();
            cfg.CreateMap<AD_SOLCancelamentoDTO, AD_SOLCANDTO>();

            cfg.CreateMap<AD_SOLCAN, AD_SOLCANPropostaDTO>();
            cfg.CreateMap<AD_SOLCANPropostaDTO, AD_SOLCAN>();
            cfg.CreateMap<AD_SOLCANDTO, AD_SOLCANPropostaDTO>();
            cfg.CreateMap<AD_SOLCANPropostaDTO, AD_SOLCANDTO>();

            cfg.CreateMap<AD_SOLCAN, CancelamentoFaturadoDTO>();
            cfg.CreateMap<CancelamentoFaturadoDTO, AD_SOLCAN>();
            cfg.CreateMap<AD_SOLCANDTO, CancelamentoFaturadoDTO>();
            cfg.CreateMap<CancelamentoFaturadoDTO, AD_SOLCANDTO>();

            cfg.CreateMap<AD_SOLCAN, AD_SOLCANCreateDTO>();
            cfg.CreateMap<AD_SOLCANCreateDTO, AD_SOLCAN>();

            return cfg;
        }
    }
}