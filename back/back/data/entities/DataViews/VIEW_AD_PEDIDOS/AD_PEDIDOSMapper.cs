using AutoMapper;
using back.domain.DTO.AD_PEDIDOSDTO;

namespace back.data.entities.DataViews.VIEW_AD_PEDIDOS
{
    public static class AD_PEDIDOSMapper
    {
        public static IMapperConfigurationExpression CreateAD_PEDIDOSDetailsMapper (this IMapperConfigurationExpression cfg){
            cfg.CreateMap<AD_PEDIDOS, AD_PEDIDOSDTO>();
            cfg.CreateMap<AD_PEDIDOSDTO, AD_PEDIDOS>();

            return cfg;
        }
    }
}