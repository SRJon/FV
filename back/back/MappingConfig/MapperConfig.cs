using AutoMapper;
using back.Application.Controllers;

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
            });
            return configuration;
        }
    }
}