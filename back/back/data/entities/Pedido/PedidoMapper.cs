﻿using AutoMapper;
using back.domain.DTO.Pedido;

namespace back.data.entities.Pedido
{
    public static class PedidoMapper
    {
        public static IMapperConfigurationExpression CreatePedidoMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Pedido, PedidoDTOUpdateDTO>();
            cfg.CreateMap<PedidoDTOUpdateDTO, Pedido>();

            return cfg;
        }


    }
}
