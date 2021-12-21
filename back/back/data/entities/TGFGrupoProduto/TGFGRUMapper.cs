using AutoMapper;
using back.domain.DTO.TGFGrupoProduto;

namespace back.data.entities.TGFGrupoProduto
{
    public  static class TGFGRUMapper
    {
        public static IMapperConfigurationExpression CreateTGFGRUMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TGFGRU, TGFGRUDTOUpdateDTO>();
            cfg.CreateMap<TGFGRUDTOUpdateDTO, TGFGRU>();

            cfg.CreateMap<TGFGRU, TGFGRUDTO>();
            cfg.CreateMap<TGFGRUDTO, TGFGRU>();

            cfg.CreateMap<TGFGRU, TGFGRUDTOList>();
            cfg.CreateMap<TGFGRUDTOList, TGFGRU>();

            return cfg;
        }
    }
}
