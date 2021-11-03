using AutoMapper;
using back.data.entities.User;
using back.DTO.Authentication;


namespace back.domain.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UserAuthenticateDto>();
            CreateMap<UserAuthenticateDto, Usuario>();
        }
    }

}