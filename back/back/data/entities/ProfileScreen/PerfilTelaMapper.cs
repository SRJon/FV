using AutoMapper;
using back.domain.DTO.ProfileScreenDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.data.entities.ProfileScreen
{
    public static class PerfilTelaMapper
    {
        public static IMapperConfigurationExpression CreatePerfilTelaMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<PerfilTela, PerfilTelaDTO>();
            cfg.CreateMap<PerfilTelaDTO, PerfilTela>();
            cfg.CreateMap<PerfilTela, PerfilTelaDTOCreate>();
            cfg.CreateMap<PerfilTelaDTOCreate, PerfilTela>();
            cfg.CreateMap<PerfilTela, PerfilTelaDTOUpdateDTO>();
            cfg.CreateMap<PerfilTelaDTOUpdateDTO, PerfilTela>();
            cfg.CreateMap<PerfilTela, PerfilTelaDTO>();
            cfg.CreateMap<PerfilTelaDTO, PerfilTela>();
            cfg.CreateMap<PerfilTela, PerfilTelaDTOProfiless>();
            cfg.CreateMap<PerfilTelaDTOProfiless, PerfilTela>();

            return cfg;
        }
    }
}
