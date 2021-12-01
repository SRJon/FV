using AutoMapper;
using back.domain.DTO.TSIEMP;

namespace back.data.entities.TSIEMP
{
    public static class TSIEMPMapper
    {
        public static IMapperConfigurationExpression CreateTSIEMPMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TSIEMP, TSIEMPDTOUpdateDTO>();
            cfg.CreateMap<TSIEMPDTOUpdateDTO, TSIEMP>();

            cfg.CreateMap<TSIEMP, TSIEMPDTO>();
            cfg.CreateMap<TSIEMPDTO, TSIEMP>();

            return cfg;
        }
    }
}
