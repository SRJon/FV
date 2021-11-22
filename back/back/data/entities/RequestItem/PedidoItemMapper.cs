using AutoMapper;
using back.domain.DTO.RequestItem;

namespace back.data.entities.RequestItem
{
    public static class PedidoItemItemMapper
    {
        public static IMapperConfigurationExpression CreatePedidoItemMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<PedidoItem, PedidoItemDTOUpdateDTO>();
            cfg.CreateMap<PedidoItemDTOUpdateDTO, PedidoItem>();

            cfg.CreateMap<PedidoItem, PedidoItemDTO>();
            cfg.CreateMap<PedidoItemDTO, PedidoItem>();

            return cfg;
        }


    }
}