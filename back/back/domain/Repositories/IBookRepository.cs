using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BookAmostra;
using back.data.http;
using back.domain.DTO.Book;

namespace back.domain.Repositories
{
    public interface IBookRepository
    {
        public Task<Response<List<BookDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<BookDTO> GetById(int id);
        public Task<BookAmostraDTO> GetByCodProd(int codProd);
        public Task<bool> Create(Book Book);
        public Task<bool> Delete(int id);
        public Task<bool> Update(Book Book);
    }
}