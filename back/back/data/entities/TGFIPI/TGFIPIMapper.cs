using AutoMapper;
using back.domain.DTO.TGFIPI;

namespace back.data.entities.TGFIPI
{
    public static class TGFIPIMapper
    {
        public static IMapperConfigurationExpression CreateTGFIPIMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TGFIPI, TGFIPIDTOUpdateDTO>();
            cfg.CreateMap<TGFIPIDTOUpdateDTO, TGFIPI>();

            cfg.CreateMap<TGFIPI, TGFIPIDTO>();
            cfg.CreateMap<TGFIPIDTO, TGFIPI>();

            return cfg;
        }
    }
}
