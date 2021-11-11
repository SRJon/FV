using AutoMapper;
using back.domain.DTO.PedidoItem;

namespace back.data.entities.PedidoItem
{
    public static class PedidoItemItemMapper
    {
        public static IMapperConfigurationExpression CreatePedidoItemItemMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<PedidoItem, PedidoItemDTOUpdateDTO>();
            cfg.CreateMap<PedidoItemDTOUpdateDTO, PedidoItem>();

            return cfg;
        }


    }
}