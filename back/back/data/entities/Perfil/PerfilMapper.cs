using AutoMapper;
using back.domain.DTO.Perfil;

namespace back.data.entities.Perfil
{
    public static class PerfilMapper
    {

        public static IMapperConfigurationExpression CreatePerfilMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Perfil, PerfilDTOUpdateDTO>();
            cfg.CreateMap<PerfilDTOUpdateDTO, Perfil>();

            return cfg;
        }


    }
}
