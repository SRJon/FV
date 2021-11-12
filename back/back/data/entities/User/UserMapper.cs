using AutoMapper;
using back.data.entities.User;
using back.domain.DTO.Usuario;

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

            return cfg;
        }


    }
}
