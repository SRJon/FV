using AutoMapper;
using back.domain.DTO.TGFRGV;

namespace back.data.entities.TGFGrupoProdutoVendedor
{
    public static class TGFRGVMapper
    {

        public static IMapperConfigurationExpression CreateTGFRGVMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TGFRGV, TGFRGVDTOUpdateDTO>();
            cfg.CreateMap<TGFRGVDTOUpdateDTO, TGFRGV>();

            cfg.CreateMap<TGFRGV, TGFRGVDTO>();
            cfg.CreateMap<TGFRGVDTO, TGFRGV>();

            return cfg;
        }
    }
}
