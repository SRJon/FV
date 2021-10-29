using AutoMapper;
using back.data.entities.User;
using back.DTO.Authentication;

namespace back.Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserAuthenticateDto, Usuario>();
        }
    }
}