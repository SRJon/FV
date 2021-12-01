using AutoMapper;
using back.domain.DTO.TSIEnderecoDTO;

namespace back.data.entities.TSIEndereco
{
    public static class TSIENDMapper
    {
        public static IMapperConfigurationExpression CreateTSIENDMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TSIEND, TSIENDDTO>();
            cfg.CreateMap<TSIENDDTO, TSIEND>();
            cfg.CreateMap<TSIEND, TSIENDDTOCreate>();
            cfg.CreateMap<TSIENDDTOCreate, TSIEND>();


            return cfg;
        }
    }
}