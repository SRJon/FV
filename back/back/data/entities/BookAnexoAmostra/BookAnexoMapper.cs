using AutoMapper;
using back.domain.DTO.BookAnexo;

namespace back.data.entities.BookAnexoAmostra
{
    public static class BookAnexoMapper
    {
        public static IMapperConfigurationExpression CreateBookAnexoMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<BookAnexo, BookAnexoDTOUpdateDTO>();
            cfg.CreateMap<BookAnexoDTOUpdateDTO, BookAnexo>();

            cfg.CreateMap<BookAnexo, BookAnexoDTO>();
            cfg.CreateMap<BookAnexoDTO, BookAnexo>();

            cfg.CreateMap<BookAnexo, BookAnexoAmostraDTO>();
            cfg.CreateMap<BookAnexoAmostraDTO, BookAnexo>();

            cfg.CreateMap<BookAnexoDTO, BookAnexoAmostraDTO>();
            cfg.CreateMap<BookAnexoAmostraDTO, BookAnexoDTO>();


            return cfg;
        }


    }
}
