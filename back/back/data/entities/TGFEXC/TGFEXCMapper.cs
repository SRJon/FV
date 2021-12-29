using AutoMapper;
using back.domain.DTO.TGFEXC;

namespace back.data.entities.TGFEXCProduto
{
    public static class TGFEXCMapper
    {
        public static IMapperConfigurationExpression CreateTGFEXCMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TGFEXC, TGFEXCDTOUpdateDTO>();
            cfg.CreateMap<TGFEXCDTOUpdateDTO, TGFEXC>();

            cfg.CreateMap<TGFEXC, TGFEXCDTO>();
            cfg.CreateMap<TGFEXCDTO, TGFEXC>();

            return cfg;
        }
    }
}
