using AutoMapper;
using back.data.entities.User;
using back.DTO.Authentication;

namespace back.Application.Mappings
{

    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UserAuthenticateDto>();
        }
    }

}