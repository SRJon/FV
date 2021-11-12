using AutoMapper;
using back.domain.DTO.BookAnexo;

namespace back.data.entities.BookAnexo
{
    public static class BookAnexoMapper
    {
        public static IMapperConfigurationExpression CreateBookAnexoMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<BookAnexo, BookAnexoDTOUpdateDTO>();
            cfg.CreateMap<BookAnexoDTOUpdateDTO, BookAnexo>();

            return cfg;
        }


    }
}
