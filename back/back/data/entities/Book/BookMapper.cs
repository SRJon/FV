using AutoMapper;
using back.domain.DTO.Book;
using back.domain.DTO.Pedido;

namespace back.data.entities.Pedido
{
    public static class BookMapper
    {
        public static IMapperConfigurationExpression CreateBookMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Pedido, PedidoDTOUpdateDTO>();
            cfg.CreateMap<PedidoDTOUpdateDTO, Pedido>();

            return cfg;
        }


    }
}
