using AutoMapper;
using back.domain.DTO.AnexoRep;

namespace back.data.entities.AnexoRep
{
    public static class AnexoRepMapper
    {
        public static IMapperConfigurationExpression CreateAnexoRepMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AnexoRep, AnexoRepDTOUpdateDTO>();
            cfg.CreateMap<AnexoRepDTOUpdateDTO, AnexoRep>();

            cfg.CreateMap<AnexoRep, AnexoRepDTO>();
            cfg.CreateMap<AnexoRepDTO, AnexoRep>();

            return cfg;
        }
    }
}
