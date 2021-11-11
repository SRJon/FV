using AutoMapper;
using back.Application.Controllers;
using back.data.entities.Enterprise;
using back.data.entities.Profile;
using back.data.entities.ProfileScreen;
using back.data.entities.Screen;
using back.data.entities.User;
using back.domain.DTO.Empresa;
using back.domain.DTO.ProfileDTO;
using back.domain.DTO.ProfileScreenDTO;
using back.domain.DTO.ScreenDTO;
using back.domain.DTO.Usuario;

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
                cfg.CreateMap<Tela, TelaDTOChild>();
                cfg.CreateMap<TelaDTOChild, Tela>();
                cfg.CreateMap<Empresa, EmpresaDTOUpdateDTO>();
                cfg.CreateMap<EmpresaDTOUpdateDTO, Empresa>();
                cfg.CreateMap<Usuario, UsuarioDTO>();
                cfg.CreateMap<UsuarioDTO, Usuario>();
                cfg.CreateMap<Usuario, UsuarioDTOUpdateDTO>();
                cfg.CreateMap<UsuarioDTOUpdateDTO, Usuario>();
                cfg.CreateMap<Perfil, PerfilDTO>();
                cfg.CreateMap<PerfilDTO, Perfil>();
                cfg.CreateMap<PerfilTela, PerfilTelaDTO>();
                cfg.CreateMap<PerfilTelaDTO, PerfilTela>();
                cfg.CreateMap<PerfilTela, PerfilTelaDTOUpdateDTO>();
                cfg.CreateMap<PerfilTelaDTOUpdateDTO, PerfilTela>();
            });
            return configuration;
        }
    }
}