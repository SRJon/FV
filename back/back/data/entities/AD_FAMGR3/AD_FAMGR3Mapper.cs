using AutoMapper;
using back.domain.DTO.AD_FAMGR3;

namespace back.data.entities.AD_FamiliaGR3
{
    public static class AD_FAMGR3Mapper
    {
        public static IMapperConfigurationExpression CreateAD_FAMGR3Mapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_FAMGR3, AD_FAMGR3DTOUpdateDTO>();
            cfg.CreateMap<AD_FAMGR3DTOUpdateDTO, AD_FAMGR3>();

            cfg.CreateMap<AD_FAMGR3, AD_FAMGR3DTO>();
            cfg.CreateMap<AD_FAMGR3DTO, AD_FAMGR3>();

            return cfg;
        }
    }
}
