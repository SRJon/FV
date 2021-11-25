using AutoMapper;
using back.domain.DTO.AnexoCont;

namespace back.data.entities.AnexoCont
{
    public static class AnexoContMapper
    {
        public static IMapperConfigurationExpression CreateAnexoContMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AnexoCont, AnexoContDTOUpdateDTO>();
            cfg.CreateMap<AnexoContDTOUpdateDTO, AnexoCont>();
            cfg.CreateMap<AnexoCont, AnexoContDTO>();
            cfg.CreateMap<AnexoContDTO, AnexoCont>();

            cfg.CreateMap<AnexoCont, AnexoContDTO>();
            cfg.CreateMap<AnexoContDTO, AnexoCont>();

            return cfg;
        }
    }
}
