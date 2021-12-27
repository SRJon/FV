using AutoMapper;
using back.domain.DTO.AD_Estoque;

namespace back.data.entities.AD_Estoque
{
    public static class AD_ESTCODPRODMapper
    {
        public static IMapperConfigurationExpression CreateAD_ESTCODPRODMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AD_ESTCODPROD, AD_ESTCODPRODDTOUpdateDTO>();
            cfg.CreateMap<AD_ESTCODPRODDTOUpdateDTO, AD_ESTCODPROD>();

            cfg.CreateMap<AD_ESTCODPROD, AD_ESTCODPRODDTO>();
            cfg.CreateMap<AD_ESTCODPRODDTO, AD_ESTCODPROD>();



            //AD_ESTCODPROD
            return cfg;
        }
    }
}
