using AutoMapper;
using back.domain.DTO.BProduto;

namespace back.data.entities.BProduto
{
    public static class BProdutoMapper
    {
        public static IMapperConfigurationExpression CreateBProdutoMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<BProduto, BProdutoDTOUpdateDTO>();
            cfg.CreateMap<BProdutoDTOUpdateDTO, BProduto>();

            return cfg;
        }


    }
}
