using AutoMapper;
using back.domain.DTO.UserEmp;

namespace back.data.entities.UserEmp
{
    public static class UsuarioEmpMapper
    {
        public static IMapperConfigurationExpression CreateUsuarioEmpMapper(this IMapperConfigurationExpression cfg)
        {            

            cfg.CreateMap<UsuarioEmp, UsuarioEmpDTOUpdateDTO>();
            cfg.CreateMap<UsuarioEmpDTOUpdateDTO, UsuarioEmp>();

            cfg.CreateMap<UsuarioEmp, UsuarioEmpDTO>();
            cfg.CreateMap<UsuarioEmpDTO, UsuarioEmp>();

            return cfg;
        }

    }
}