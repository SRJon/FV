using AutoMapper;
using back.domain.DTO.TSIEmpDTO;

namespace back.data.entities.TSIEmpresa
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
