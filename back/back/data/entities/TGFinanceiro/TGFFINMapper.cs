using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.TGFFinanceiroDTO;

namespace back.data.entities.TGFinanceiro
{
    public static class TGFFINMapper
    {
        public static IMapperConfigurationExpression CreateTGFFINMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TGFFIN, TGFFINDTO>();
            cfg.CreateMap<TGFFINDTO, TGFFIN>();

            cfg.CreateMap<TGFFIN, TGFFINClienteDTO>();
            cfg.CreateMap<TGFFINClienteDTO, TGFFIN>();

            cfg.CreateMap<TGFFINDTO, TGFFINClienteDTO>();
            cfg.CreateMap<TGFFINClienteDTO, TGFFINDTO>();

            return cfg;
        }

    }
}