using AutoMapper;
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
            cfg.CreateMap<Perfil, PerfilDTO>();
            cfg.CreateMap<PerfilDTO, Perfil>();
            cfg.CreateMap<Perfil, PerfilDTOUserless>();
            cfg.CreateMap<PerfilDTOUserless, Perfil>();
            cfg.CreateMap<Perfil, PerfilDTOCreate>();
            cfg.CreateMap<PerfilDTOCreate, Perfil>();
            cfg.CreateMap<Perfil, PerfilDTOUserProfilessDTO>();
            cfg.CreateMap<PerfilDTOUserProfilessDTO, Perfil>();
            cfg.CreateMap<Perfil, PerfilDTONome>();
            cfg.CreateMap<PerfilDTONome, Perfil>();
            cfg.CreateMap<Perfil, PerfilDTOPerfil>();
            cfg.CreateMap<PerfilDTOPerfil, Perfil>();

            return cfg;
        }


    }
}
