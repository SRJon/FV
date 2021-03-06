using AutoMapper;
using back.domain.DTO.Diretorio;

namespace back.data.entities.Diretorio
{
    public static class DiretorioMapper
    {
        public static IMapperConfigurationExpression CreateDiretorioMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Diretorio, DiretorioDTOUpdateDTO>();
            cfg.CreateMap<DiretorioDTOUpdateDTO, Diretorio>();

            cfg.CreateMap<Diretorio, DiretorioDTO>();
            cfg.CreateMap<DiretorioDTO, Diretorio>();

            return cfg;
        }


    }
}
