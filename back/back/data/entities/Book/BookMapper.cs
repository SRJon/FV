using AutoMapper;
using back.domain.DTO.Book;

namespace back.data.entities.Book
{
    public static class BookMapper
    {
        public static IMapperConfigurationExpression CreateBookMapper(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Book, BookDTOUpdateDTO>();
            cfg.CreateMap<BookDTOUpdateDTO, Book>();

            return cfg;
        }


    }
}
