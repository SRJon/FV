using AutoMapper;
using back.domain.DTO.AD_VGFRPVDTO;

namespace back.data.entities.VIEW_AD_VGFRPV
{
    public static class AD_VGFRPVMapper
    {
        public static IMapperConfigurationExpression CreateAD_VGFRPVDetailsMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_VGFRPV, AD_VGFRPVDTO>();
            cfg.CreateMap<AD_VGFRPVDTO, AD_VGFRPV>();

            cfg.CreateMap<AD_VGFRPV, AD_VGFRPVSaldoDTO>();
            cfg.CreateMap<AD_VGFRPVSaldoDTO, AD_VGFRPV>();

            return cfg;
        }
    }
}