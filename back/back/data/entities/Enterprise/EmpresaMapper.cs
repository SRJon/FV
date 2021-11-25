using AutoMapper;
using back.domain.DTO.Enterprise;

namespace back.data.entities.Enterprise
{
    public static class EmpresaMapper
    {

        public static IMapperConfigurationExpression CreateEmpresaMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Empresa, EmpresaDTO>();
            cfg.CreateMap<EmpresaDTO, Empresa>();
            cfg.CreateMap<Empresa, EmpresaDTOUpdateDTO>();
            cfg.CreateMap<EmpresaDTOUpdateDTO, Empresa>();

            return cfg;
        }


    }
}
