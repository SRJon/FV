using AutoMapper;
using back.domain.DTO.TGFPRO;

namespace back.data.entities.TGFPRO
{
    public static class TGFPROMapper
    {
        public static IMapperConfigurationExpression CreateTGFPROMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TGFPRO, TGFPRODTOUpdateDTO>();
            cfg.CreateMap<TGFPRODTOUpdateDTO, TGFPRO>();

            cfg.CreateMap<TGFPRO, TGFPRODTO>();
            cfg.CreateMap<TGFPRODTO, TGFPRO>();

            return cfg;
        }
    }
}