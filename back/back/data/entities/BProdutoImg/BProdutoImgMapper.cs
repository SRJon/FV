using AutoMapper;
using back.domain.DTO.BProdutoImg;

namespace back.data.entities.BProdutoImg
{
    public static class BProdutoImgMapper
    {
        public static IMapperConfigurationExpression CreateBProdutoImgMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<BProdutoImg, BProdutoImgDTOUpdateDTO>();
            cfg.CreateMap<BProdutoImgDTOUpdateDTO, BProdutoImg>();

            cfg.CreateMap<BProdutoImg, BProdutoImgDTO>();
            cfg.CreateMap<BProdutoImgDTO, BProdutoImg>();

            return cfg;
        }


    }
}