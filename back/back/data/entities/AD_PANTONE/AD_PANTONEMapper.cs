using AutoMapper;
using back.domain.DTO.AD_PANTONE;

namespace back.data.entities.AD_PANTONE_Cor
{
    public static class AD_PANTONEMapper
    {
        public static IMapperConfigurationExpression CreateAD_PANTONEMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_PANTONE, AD_PANTONEDTOUpdateDTO>();
            cfg.CreateMap<AD_PANTONEDTOUpdateDTO, AD_PANTONE>();

            cfg.CreateMap<AD_PANTONE, AD_PANTONEDTO>();
            cfg.CreateMap<AD_PANTONEDTO, AD_PANTONE>();

            return cfg;
        }
    }
}
