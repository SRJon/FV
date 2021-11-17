using AutoMapper;
using back.domain.DTO.Projetos;

namespace back.data.entities.Projetos
{
    public static class ProjetosMapper
    {
        public static IMapperConfigurationExpression CreateProjetosMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Projetos, ProjetosDTOUpdateDTO>();
            cfg.CreateMap<ProjetosDTOUpdateDTO, Projetos>();

            return cfg;
        }


    }
}
