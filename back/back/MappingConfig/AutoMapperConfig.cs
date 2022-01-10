using System;
using back.Application.Mappings;
using back.domain.Profiles;
using Microsoft.Extensions.DependencyInjection;



namespace back.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection service)
        {

            if (service == null) throw new ArgumentException(nameof(service));


            service.AddAutoMapper(typeof(UsuarioProfile));
            service.AddAutoMapper(typeof(DomainToViewModelMappingProfile),
                                  typeof(ViewModelToDomainMappingProfile));
        }
    }
}