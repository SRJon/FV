using AutoMapper;
using back.domain.DTO.Informativo;

namespace back.data.entities.Informativo
{
    public static class InformativoMapper
    {
        public static IMapperConfigurationExpression CreateInformativoMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Informativo, InformativoDTOUpdateDTO>();
            cfg.CreateMap<InformativoDTOUpdateDTO, Informativo>();

            return cfg;
        }


    }
}
