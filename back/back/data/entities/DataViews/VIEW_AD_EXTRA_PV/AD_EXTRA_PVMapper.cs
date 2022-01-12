using AutoMapper;
using back.domain.DTO.AD_EXTRA_PVDTO;

namespace back.data.entities.DataViews.VIEW_AD_EXTRA_PV
{
    public static class AD_EXTRA_PVMapper
    {
        public static IMapperConfigurationExpression CreateAD_EXTRA_PVDetailsMapper (this IMapperConfigurationExpression cfg){
            cfg.CreateMap<AD_EXTRA_PV, AD_EXTRA_PVDTO>();
            cfg.CreateMap<AD_EXTRA_PVDTO, AD_EXTRA_PV>();

            return cfg;
        }
    }
}