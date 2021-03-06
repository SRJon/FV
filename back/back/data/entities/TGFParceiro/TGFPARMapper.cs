using AutoMapper;
using back.domain.DTO.TGFParceiroDTO;

namespace back.data.entities.TGFParceiro
{
    public static class TGFPARMapper
    {
        public static IMapperConfigurationExpression CreateTGFPARMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TGFPAR, TGFPARDTO>();
            cfg.CreateMap<TGFPARDTO, TGFPAR>();
            cfg.CreateMap<TGFPAR, TGFPARDTOCreate>();
            cfg.CreateMap<TGFPARDTOCreate, TGFPAR>();
            cfg.CreateMap<TGFPARDTO, TGFPARDTOCreate>();
            cfg.CreateMap<TGFPARDTOCreate, TGFPARDTO>();
            cfg.CreateMap<TGFPAR, TGFPARDTOPedido>();
            cfg.CreateMap<TGFPARDTOPedido, TGFPAR>();
            cfg.CreateMap<TGFPARDTO, TGFPARDTOPedido>();
            cfg.CreateMap<TGFPARDTOPedido, TGFPARDTO>();

            cfg.CreateMap<TGFPARDTO, TGFPARSACDTO>();
            cfg.CreateMap<TGFPARSACDTO, TGFPARDTO>();
            cfg.CreateMap<TGFPAR, TGFPARSACDTO>();
            cfg.CreateMap<TGFPARSACDTO, TGFPAR>();
            cfg.CreateMap<TGFPARDTO, TGFPARClienteBasicoDTO>();
            cfg.CreateMap<TGFPARClienteBasicoDTO, TGFPARDTO>();
            cfg.CreateMap<TGFPAR, TGFPARClienteBasicoDTO>();
            cfg.CreateMap<TGFPARClienteBasicoDTO, TGFPAR>();

            cfg.CreateMap<TGFPARDTO, TGFPARPedidoClienteDTO>();
            cfg.CreateMap<TGFPARPedidoClienteDTO, TGFPARDTO>();
            cfg.CreateMap<TGFPAR, TGFPARPedidoClienteDTO>();
            cfg.CreateMap<TGFPARPedidoClienteDTO, TGFPAR>();

            return cfg;
        }
    }
}