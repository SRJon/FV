using System.Threading.Tasks;
using back.data.entities.BookAmostra;
using back.infra.Data.Context;

namespace back.infra.Services.BookServices
{
    public static class BookAnexoCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, Book Book)
        {
            ctx.Book.Add(Book);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}