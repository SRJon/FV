using AutoMapper;
using back.domain.DTO.TGFProdutoDTO;

namespace back.data.entities.TGFProduto
{
    public static class TGFPROMapper
    {
        public static IMapperConfigurationExpression CreateTGFPROMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TGFPRO, TGFPRODTOUpdateDTO>();
            cfg.CreateMap<TGFPRODTOUpdateDTO, TGFPRO>();

            cfg.CreateMap<TGFPRO, TGFPRODTO>();
            cfg.CreateMap<TGFPRODTO, TGFPRO>();

            cfg.CreateMap<TGFPRO, TGFPROAmostraDTO>();
            cfg.CreateMap<TGFPROAmostraDTO, TGFPRO>();

            cfg.CreateMap<TGFPRODTO, TGFPROAmostraDTO>();
            cfg.CreateMap<TGFPROAmostraDTO, TGFPRODTO>();

            return cfg;
        }
    }
}