using AutoMapper;
using back.domain.DTO.VersionDetails;

namespace back.data.entities.VersionDetails
{
    public static class VersionDetailsMapper
    {
        public static IMapperConfigurationExpression CreateVersionDetailsMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<VersionDetails, VersionDetailsDTOUpdateDTO>();
            cfg.CreateMap<VersionDetailsDTOUpdateDTO, VersionDetails>();

            return cfg;
        }


    }
}
