using AutoMapper;
using back.domain.DTO.AD_ESTPROGPROD;

namespace back.data.entities.View_AD_ESTPROGPROD
{
    public static class AD_ESTPROGPRODMapper
    {
        public static IMapperConfigurationExpression CreateAD_ESTPROGPRODMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_ESTPROGPROD, AD_ESTPROGPRODDTOUpdateDTO>();
            cfg.CreateMap<AD_ESTPROGPRODDTOUpdateDTO, AD_ESTPROGPROD>();

            cfg.CreateMap<AD_ESTPROGPROD, AD_ESTPROGPRODDTO>();
            cfg.CreateMap<AD_ESTPROGPRODDTO, AD_ESTPROGPROD>();

            return cfg;
        }
    }
}
