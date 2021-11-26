using AutoMapper;
using back.domain.DTO.TGFVEN;

namespace back.data.entities.TGFVEN
{
    public static class TGFVENMapper
    {
        public static IMapperConfigurationExpression CreateTGFVENMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TGFVEN, TGFVENDTOUpdateDTO>();
            cfg.CreateMap<TGFVENDTOUpdateDTO, TGFVEN>();

            cfg.CreateMap<TGFVEN, TGFVENDTO>();
            cfg.CreateMap<TGFVENDTO, TGFVEN>();

            return cfg;
        }
    }
}
