using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.TCSProjetoDTO;

namespace back.data.entities.TCSProjeto
{
    public static class TCSPRJMapper
    {
        public static IMapperConfigurationExpression CreateTCSPRJMapper(this IMapperConfigurationExpression cfg)
        {

            cfg.CreateMap<TCSPRJ, TCSPRJDTO>();
            cfg.CreateMap<TCSPRJDTO, TCSPRJ>();
            return cfg;
        }
    }
}