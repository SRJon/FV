using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.TGFCABNotaDTO;

namespace back.data.entities.TGFCABNota
{
    public static class TGFCABMapper
    {
        public static IMapperConfigurationExpression CreateTGFCABMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TGFCAB, TGFCABDTO>();
            cfg.CreateMap<TGFCABDTO, TGFCAB>();

            cfg.CreateMap<TGFCAB, TGFCABNuNotaDTO>();
            cfg.CreateMap<TGFCABNuNotaDTO, TGFCAB>();

            cfg.CreateMap<TGFCAB, TGFCABDevolucaoDTO>();
            cfg.CreateMap<TGFCABDevolucaoDTO, TGFCAB>();

            cfg.CreateMap<TGFCAB, TGFCABSACDTO>();
            cfg.CreateMap<TGFCABSACDTO, TGFCAB>();
            cfg.CreateMap<TGFCABDTO, TGFCABSACDTO>();
            cfg.CreateMap<TGFCABSACDTO, TGFCABDTO>();

            return cfg;
        }
    }
}