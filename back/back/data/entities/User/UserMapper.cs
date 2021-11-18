using AutoMapper;
using back.data.entities.User;
using back.domain.DTO.User;
using back.DTO.Authentication;

namespace back.data.entities.Enterprise
{
    public static class UserMapper
    {

        public static IMapperConfigurationExpression CreateUserMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Usuario, UsuarioDTO>();
            cfg.CreateMap<UsuarioDTO, Usuario>();
            cfg.CreateMap<UserAuthenticateDto, UsuarioDTO>();
            cfg.CreateMap<UsuarioDTO, UserAuthenticateDto>();
            cfg.CreateMap<Usuario, UsuarioDTOUpdateDTO>();
            cfg.CreateMap<UsuarioDTOUpdateDTO, Usuario>();
            cfg.CreateMap<Usuario, UsuarioDTOCreate>();
            cfg.CreateMap<UsuarioDTOCreate, Usuario>();
            cfg.CreateMap<Usuario, UsuarioDTOProfiless>();
            cfg.CreateMap<UsuarioDTOProfiless, Usuario>();

            return cfg;
        }


    }
}
