using System.Threading.Tasks;
using back.domain.DTO.Book;
using back.infra.Data.Context;

namespace back.infra.Services.BookServices
{
    public static class BookAnexoUpdateService
    {
        public static async Task<bool> UpdateBookServices(this DbAppContextFVUDB_TESTE ctx, BookDTOUpdateDTO Book, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(Book);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}