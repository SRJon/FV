using AutoMapper;
using back.data.entities.Screen;
using back.domain.DTO.ScreenDTO;

namespace back.data.entities.Enterprise
{
    public static class TelaMapper
    {

        public static IMapperConfigurationExpression CreateTelaMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Tela, TelaDTO>();
            cfg.CreateMap<TelaDTO, Tela>();
            cfg.CreateMap<Tela, TelaDTOUpdateDTO>();
            cfg.CreateMap<TelaDTOUpdateDTO, Tela>();
            cfg.CreateMap<Tela, TelaDTOChild>();
            cfg.CreateMap<TelaDTOCreate, Tela>();
            cfg.CreateMap<Tela, TelaDTOCreate>();

            return cfg;
        }


    }
}
