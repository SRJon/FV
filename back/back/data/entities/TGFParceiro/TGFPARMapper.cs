using AutoMapper;
using back.domain.DTO.TGFParceiroDTO;

namespace back.data.entities.TGFParceiro
{
    public static class TGFPARMapper
    {
        public static IMapperConfigurationExpression CreateTGFPARMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TGFPAR, TGFPARDTO>();
            cfg.CreateMap<TGFPARDTO, TGFPAR>();
            cfg.CreateMap<TGFPAR, TGFPARDTOCreate>();
            cfg.CreateMap<TGFPARDTOCreate, TGFPAR>();

            return cfg;
        }
    }
}