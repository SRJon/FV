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

            cfg.CreateMap<TSIEMP, TSIEMPDTONF>();
            cfg.CreateMap<TSIEMPDTONF, TSIEMP>();

            cfg.CreateMap<TSIEMPDTO, TSIEMPDTONF>();
            cfg.CreateMap<TSIEMPDTONF, TSIEMPDTO>();

            cfg.CreateMap<TSIEMP, TSIEMPDevolucaoDTO>();
            cfg.CreateMap<TSIEMPDevolucaoDTO, TSIEMP>();

            cfg.CreateMap<TSIEMPDTO, TSIEMPDevolucaoDTO>();
            cfg.CreateMap<TSIEMPDevolucaoDTO, TSIEMPDTO>();

            return cfg;
        }
    }
}
