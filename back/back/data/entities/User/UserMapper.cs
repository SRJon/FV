using AutoMapper;
using back.data.entities.User;
using back.domain.DTO.User;

namespace back.data.entities.Enterprise
{
    public static class UserMapper
    {

        public static IMapperConfigurationExpression CreateUserMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Usuario, UsuarioDTO>();
            cfg.CreateMap<UsuarioDTO, Usuario>();
            cfg.CreateMap<Usuario, UsuarioDTOUpdateDTO>();
            cfg.CreateMap<UsuarioDTOUpdateDTO, Usuario>();
            cfg.CreateMap<Usuario, UsuarioDTOCreate>();
            cfg.CreateMap<UsuarioDTOCreate, Usuario>();

            return cfg;
        }


    }
}
