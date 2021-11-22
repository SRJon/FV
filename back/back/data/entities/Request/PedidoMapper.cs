﻿using AutoMapper;
using back.domain.DTO.Request;

namespace back.data.entities.Request
{
    public static class PedidoMapper
    {
        public static IMapperConfigurationExpression CreatePedidoMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Pedido, PedidoDTOUpdateDTO>();
            cfg.CreateMap<PedidoDTOUpdateDTO, Pedido>();

            cfg.CreateMap<Pedido, PedidoDTO>();
            cfg.CreateMap<PedidoDTO, Pedido>();

            cfg.CreateMap<Pedido, PedidoDTOItemless>();
            cfg.CreateMap<PedidoDTOItemless, Pedido>();

            return cfg;
        }


    }
}
