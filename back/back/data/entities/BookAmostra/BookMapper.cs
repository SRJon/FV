using AutoMapper;
using back.domain.DTO.Book;

namespace back.data.entities.BookAmostra
{
    public static class BookMapper
    {
        public static IMapperConfigurationExpression CreateBookMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Book, BookDTOUpdateDTO>();
            cfg.CreateMap<BookDTOUpdateDTO, Book>();

            cfg.CreateMap<Book, BookDTO>();
            cfg.CreateMap<BookDTO, Book>();

            return cfg;
        }


    }
}
