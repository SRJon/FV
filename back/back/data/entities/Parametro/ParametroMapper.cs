using AutoMapper;
using back.domain.DTO.Parametro;

namespace back.data.entities.Parametro
{
    public static class ParametroMapper
    {
        public static IMapperConfigurationExpression CreateParametroMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Parametro, ParametroDTOUpdateDTO>();
            cfg.CreateMap<ParametroDTOUpdateDTO, Parametro>();

            cfg.CreateMap<Parametro, ParametroDTO>();
            cfg.CreateMap<ParametroDTO, Parametro>();

            return cfg;
        }


    }
}
