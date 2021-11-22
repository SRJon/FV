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

            cfg.CreateMap<BProduto, BProdutoDTO>();
            cfg.CreateMap<BProdutoDTO, BProduto>();

            return cfg;
        }


    }
}
