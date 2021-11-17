using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BookAnexo;
using back.data.http;
using back.domain.DTO.BookAnexo;

namespace back.domain.Repositories
{
    public interface IBookAnexoRepository
    {
        public Task<Response<List<BookAnexoDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<BookAnexoDTO> GetById(int id);
        public Task<bool> Create(BookAnexo BookAnexo);
        public Task<bool> Delete(int id);
        public Task<bool> Update(BookAnexo BookAnexo);
    }
}