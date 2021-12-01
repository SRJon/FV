using AutoMapper;
using back.domain.DTO.AD_FAMGR1;

namespace back.data.entities.AD_FAMGR1
{
    public static class AD_FAMGR1Mapper
    {
        public static IMapperConfigurationExpression CreateAD_FAMGR1Mapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_FAMGR1, AD_FAMGR1DTOUpdateDTO>();
            cfg.CreateMap<AD_FAMGR1DTOUpdateDTO, AD_FAMGR1>();

            cfg.CreateMap<AD_FAMGR1, AD_FAMGR1DTO>();
            cfg.CreateMap<AD_FAMGR1DTO, AD_FAMGR1>();

            return cfg;
        }
    }
}
