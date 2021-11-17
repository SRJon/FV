﻿using AutoMapper;
using back.domain.DTO.ProfileDTO;

namespace back.data.entities.Profile
{
    public static class PerfilMapper
    {

        public static IMapperConfigurationExpression CreatePerfilMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Perfil, PerfilDTO>();
            cfg.CreateMap<PerfilDTO, Perfil>();
            cfg.CreateMap<Perfil, PerfilDTOUpdateDTO>();
            cfg.CreateMap<PerfilDTOUpdateDTO, Perfil>();
            cfg.CreateMap<Perfil, PerfilDTOCreate>();
            cfg.CreateMap<PerfilDTOCreate, Perfil>();

            return cfg;
        }


    }
}
