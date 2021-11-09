using AutoMapper;
using back.Application.Controllers;
using back.data.entities.Enterprise;
using back.data.entities.Screen;
using back.domain.DTO.Empresa;
using back.domain.DTO.ScreenDTO;

namespace back.MappingConfig
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Teste, testeDTO>();
                cfg.CreateMap<testeDTO, Teste>();
                cfg.CreateMap<Empresa, EmpresaDTO>();
                cfg.CreateMap<EmpresaDTO, Empresa>();
                cfg.CreateMap<Tela, TelaDTO>();
                cfg.CreateMap<TelaDTO, Tela>();
                cfg.CreateMap<Tela, TelaDTOUpdateDTO>();
                cfg.CreateMap<TelaDTOUpdateDTO, Tela>();
                cfg.CreateMap<Empresa, EmpresaDTOUpdateDTO>();
                cfg.CreateMap<EmpresaDTOUpdateDTO, Empresa>();
            });
            return configuration;
        }
    }
}