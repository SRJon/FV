using AutoMapper;
using back.domain.DTO.AD_TIPNEG;

namespace back.data.entities.View_AD_TIPNEG
{
    public static class AD_TIPNEGMapper
    {
        public static IMapperConfigurationExpression CreateAD_TIPNEGMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_TIPNEG, AD_TIPNEGDTOUpdateDTO>();
            cfg.CreateMap<AD_TIPNEGDTOUpdateDTO, AD_TIPNEG>();

            cfg.CreateMap<AD_TIPNEG, AD_TIPNEGDTO>();
            cfg.CreateMap<AD_TIPNEGDTO, AD_TIPNEG>();

            return cfg;
        }
    }
}
