using AutoMapper;
using back.domain.DTO.PerfilTela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.data.entities.PerfilTela
{
    public static class PerfilTelaMapper
    {
        public static IMapperConfigurationExpression CreatePerfilTelaMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<PerfilTela, PerfilTelaDTOUpdateDTO>();
            cfg.CreateMap<PerfilTelaDTOUpdateDTO, PerfilTela>();

            return cfg;
        }
    }
}
