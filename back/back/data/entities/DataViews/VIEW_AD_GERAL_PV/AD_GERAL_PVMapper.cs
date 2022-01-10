using AutoMapper;
using back.domain.DTO.AD_GERAL_PVDTO;

namespace back.data.entities.DataViews.VIEW_AD_GERAL_PV
{
    public static class AD_GERAL_PVMapper
    {
        public static IMapperConfigurationExpression CreateAD_GERAL_PVDetailsMapper (this IMapperConfigurationExpression cfg){
            cfg.CreateMap<AD_GERAL_PV, AD_GERAL_PVDTO>();
            cfg.CreateMap<AD_GERAL_PVDTO, AD_GERAL_PV>();

            return cfg;
        }
    }
}