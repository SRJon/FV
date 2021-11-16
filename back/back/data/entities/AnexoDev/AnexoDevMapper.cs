using AutoMapper;
using back.domain.DTO.AnexoDev;

namespace back.data.entities.AnexoDev
{
    public static class AnexoDevMapper
    {
        public static IMapperConfigurationExpression CreateAnexoDevMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AnexoDev, AnexoDevDTOUpdateDTO>();
            cfg.CreateMap<AnexoDevDTOUpdateDTO, AnexoDev>();

            return cfg;
        }
    }
}
