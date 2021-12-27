using System.Threading.Tasks;
using back.data.entities.BookAmostra;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.BookServices
{
    public static class BookAnexoGetByIdService
    {
        public static Task<Book> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.Book.FirstOrDefaultAsync(x => x.Id == id);
    }
}