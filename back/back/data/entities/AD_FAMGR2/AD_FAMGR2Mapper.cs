using AutoMapper;
using back.domain.DTO.AD_FAMGR2;

namespace back.data.entities.AD_FamiliaGR2
{
    public static class AD_FAMGR2Mapper
    {
        public static IMapperConfigurationExpression CreateAD_FAMGR2Mapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_FAMGR2, AD_FAMGR2DTOUpdateDTO>();
            cfg.CreateMap<AD_FAMGR2DTOUpdateDTO, AD_FAMGR2>();

            cfg.CreateMap<AD_FAMGR2, AD_FAMGR2DTO>();
            cfg.CreateMap<AD_FAMGR2DTO, AD_FAMGR2>();

            return cfg;
        }
    }
}
