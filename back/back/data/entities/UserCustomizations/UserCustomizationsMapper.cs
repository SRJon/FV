using AutoMapper;
using back.domain.DTO.UserCustomizations;

namespace back.data.entities.UserCustomizations
{
    public static class UserCustomizationsMapper
    {
        public static IMapperConfigurationExpression CreateUserCustomizationsMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<UserCustomizations, UserCustomizationsDTOUpdateDTO>();
            cfg.CreateMap<UserCustomizationsDTOUpdateDTO, UserCustomizations>();


            cfg.CreateMap<UserCustomizations, UserCustomizationsDTO>();
            cfg.CreateMap<UserCustomizationsDTO, UserCustomizations>();

            return cfg;
        }


    }
}
