using AutoMapper;
using back.domain.DTO.VersaoProjetos;

namespace back.data.entities.VersaoProjetos
{
    public static class VersaoProjetosMapper
    {
        public static IMapperConfigurationExpression CreateVersaoProjetosMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<VersaoProjetos, VersaoProjetosDTOUpdateDTO>();
            cfg.CreateMap<VersaoProjetosDTOUpdateDTO, VersaoProjetos>();

            return cfg;
        }


    }
}
