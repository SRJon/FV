using AutoMapper;
using back.domain.DTO.VGFTAB;

namespace back.data.entities.VGFTAB
{
    public static class VGFTABMapper
    {
        public static IMapperConfigurationExpression CreateVGFTABMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<VGFTAB, VGFTABDTOUpdateDTO>();
            cfg.CreateMap<VGFTABDTOUpdateDTO, VGFTAB>();

            cfg.CreateMap<VGFTAB, VGFTABDTO>();
            cfg.CreateMap<VGFTABDTO, VGFTAB>();

            return cfg;
        }
    }
}
